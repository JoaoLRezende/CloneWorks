% Extract loop constructs from source files.
% Based on c-extract-functions.txl.

% TODO: the markup generated by this program reports that nearly every fragment
% ends one line later than it actually ends. This is most likely because,
% in the definition of loop, the second occurence of [srclinenumber]
% captures the line number of the token that comes after it, rather
% than of the preceding occurence of [loop_statement].
% See how c-extract-functions.txl deals with this: the final [srclinenumber]
% appears right before the block's closing curly brace. This causes
% the line number of the closing curly brace itself to be captured, rather
% than the line number of what comes after it.
% Change this program accordingly.
% Until then, we are manually decrementing reported end-line numbers by one.

% Using Gnu C grammar
include "c.grm"

% Ignore BOM headers from Windows
include "bom.grm"

define xml_source_coordinate
    '< [SPOFF] 'source [SP] 'file=[stringlit] [SP] 'startline=[stringlit] [SP] 'endline=[stringlit] '> [SPON] [NL]
end define

define end_xml_source_coordinate
    [NL] '< [SPOFF] '/ 'source '> [SPON] [NL]
end define

define loop_statement
	[for_statement]
	| [while_statement]
	| [do_statement]
end define

define loop
	% input form
	[srcfilename] [srclinenumber]	% Keep track of starting file and line number.
	[loop_statement]
	[srcfilename] [srclinenumber]	% Keep track of ending file and line number.
	|
	% output form
		[not token]
	[opt xml_source_coordinate]
	[loop_statement]
	[opt end_xml_source_coordinate]
end define

% Redefine structured_statement to produce the loop symbol defined above
% (instead of producing for_statement, while_statement and do_statement
% directly, as it does in c.grm).
redefine structured_statement
	[if_statement]
	| 	[loop]
    |   [switch_statement]
    |   [block]
#ifdef GNU
    |   [asm_statement]
#endif
end define

redefine program
	...
    | [repeat loop]
end redefine

% Main function: extract and mark up loops from parsed input program.
function main
    replace [program]
	P [program]
    construct Loops [repeat loop]
    	_ [^ P]			% Extract all loops from program.
		[convertLoops]	% Mark up with pseudo-XML.
    by 
    	Loops [removeOptSemis]
			[removeEmptyStatements]
end function

rule convertLoops
    % Find each loop and match its input source coordinates.
    replace [loop]
	FileName [srcfilename] LineNumber [srclinenumber]
	LoopStatement [loop_statement]
	EndFileName [srcfilename] EndLineNumber [srclinenumber]

    % Convert file name and line numbers to strings for XML
    construct FileNameString [stringlit]
	_ [quote FileName] 
    construct LineNumberString [stringlit]
	_ [quote LineNumber]
    construct EndLineNumberString [stringlit]
	_ [quote EndLineNumber]
	% Decrement reported end-line number by one.
	construct EndLinePred [number]
	_ [parse EndLineNumberString] [- 1]
	construct EndLinePredString [stringlit]
	_ [quote EndLinePred]

    % Output is XML form with attributes indicating input source coordinates
    construct XmlHeader [xml_source_coordinate]
	<source file=FileNameString startline=LineNumberString endline=EndLinePredString>
    by
	XmlHeader
	LoopStatement [unmarkEmbeddedLoops]
	</source>
end rule

% Prevent nested loops from being marked up.
rule unmarkEmbeddedLoops
    replace [loop]
	FileName [srcfilename] LineNumber [srclinenumber]
	LoopStatement [loop_statement]
	EndFileName [srcfilename] EndLineNumber [srclinenumber]
    by
	LoopStatement 
end rule

rule removeOptSemis
    replace [opt ';]
	';
    by
	% none
end rule

rule removeEmptyStatements
    replace [repeat declaration_or_statement]
	';
	More [repeat declaration_or_statement]
    by
	More
end rule
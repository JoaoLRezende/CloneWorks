% Example using TXL 10.5a source coordinate extensions to extract
% a table of all function definitions with source coordinates

% Jim Cordy, January 2008

% Revised Aug 2012 - disallow ouput forms in input parse - JRC
% Revised July 2011 - ignore BOM headers in source
% Revised 30.04.08 - unmark embedded functions - JRC

% Using Gnu C grammar
include "c.grm"

% Ignore BOM headers from Windows
include "bom.grm"

redefine for_statement
	...
	| [while_statement]
	| [do_statement]
end define

redefine program
	...
    | [repeat for_statement]
end redefine

function main
    replace [program]
	P [program]
    construct Loops [repeat for_statement]
    	_ [^ P]
    by 
    	Loops
end function
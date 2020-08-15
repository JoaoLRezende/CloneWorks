% Extract loop constructs from source files.
% Based on c-extract-functions.txl.

% TODO: Cause this program to format its output appropriately, with
% XML-style markup, as is done by c-extract-functions.txl. Also look at
% the older versions of this file (also in this directory) for inspiration.
% After making sure you've reutilized every useful part of the older versions
% of this program in this directory, delete them. (Make sure to
% either deal with or copy the TODOs contained in them, too.)

% TODO: rename names of symbols defined herein properly. Create new symbols instead
% of redefining existing ones in ways that make their names misleading. (E.g., for_statements
% should be for statements. Create and use a new symbol named "loop" to represent
% every loop construct.)
% (Do this while testing the code at every step. Weird stuff happens sometimes.)

% TODO: Comment this program properly.

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
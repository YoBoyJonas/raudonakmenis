grammar Grammar;

compileUnit: EOF;

program: line* EOF;

line: statement | ifBlock | whileBlock | classDeclaration | methodDeclaration | classCall;

statement: (assignment | functionCall | ) ';';

assignment: type? IDENTIFIER funkyOp expression;

functionCall: IDENTIFIER '(' (expression (',' expression)*)? ')';

ifBlock: 'if' expression blockas ('else' elseIfBlock)?;

blockas: block | blockWithReturn;

elseIfBlock: block | ifBlock | blockWithReturn;

whileBlock: WHILE expression blockas ;

WHILE: 'while' | 'until';

expression: 
    constant 
    | IDENTIFIER 
    | functionCall 
    | classFunctionCall
    | '(' expression ')' 
    | '!' expression 
    | expression multOp expression 
    | expression addOp expression 
    | expression compareOp expression 
    | expression boolOp expression;
    
funkyOp: '=' | '%%' | '$$' | '@@' |  '--' | '+=' |  '-=' | '+++' | '---' |  '/=' | '*=' | '%=' | '^=';

multOp: '*' | '/' | '%';
addOp: '+' | '-' ;
compareOp: '==' | '!=' | '>' | '<' | '>=' | '<=';
boolOp: BOOL_OPERATOR;

BOOL_OPERATOR: 'and' | 'or' | 'xor';

constant: INTEGER | FLOAT | STRING | BOOL | NULL;

INTEGER: '-'?[0-9]+;
FLOAT: '-'?[0-9]+ '.' [0-9]+;
STRING: '"' ~'"'* '"';
BOOL: 'true' | 'false';
NULL: 'null';

block: '{' line* '}';

classDeclaration: 'class' className '{' classBody '}';

className: IDENTIFIER;

classBody: classMember*;

classMember: fieldDeclaration | methodDeclaration;

classCall: className IDENTIFIER '=' 'new' className'('')'';'; 

classFunctionCall: IDENTIFIER '.' methodName'(' parameterList? ')' ;

fieldDeclaration: type fieldName ';';

fieldName: IDENTIFIER;

methodDeclaration: type methodName '(' parameterList? ')' methodBody;

methodName: IDENTIFIER;

parameterList: parameter (',' parameter)*;

parameter: type parameterName;

parameterName: IDENTIFIER;

type: 'int' | 'float' | 'string' | 'bool' | 'void' | className;

methodBody: blockWithReturn;

blockWithReturn: '{' line* returnStatement? '}';

returnStatement: 'return' expression? ';';

WS: [ \t\r\n]+ -> skip;
IDENTIFIER: [a-zA-Z_][a-zA-Z0-9_]*;

grammar Grammar;

compileUnit: EOF;

program: line* EOF;

line: statement | ifBlock | printStatement | whileBlock | classDeclaration | methodDeclaration;

statement: (assignment | assignment2 | functionCall) ';';

assignment: type IDENTIFIER '=' expression;

assignment2: IDENTIFIER '=' expression;

functionCall: IDENTIFIER '(' (expression (',' expression)*)? ')';

ifBlock: 'if' expression blockas ('else' elseIfBlock);

blockas: block | ifBlock | blockWithReturn;

elseIfBlock: block | ifBlock | blockWithReturn;

printStatement: 'print' expression ';';

whileBlock: WHILE expression block ('else' elseIfBlock);

WHILE: 'while' | 'until';

expression: 
    constant 
    | IDENTIFIER 
    | functionCall 
    | '(' expression ')' 
    | '!' expression 
    | expression multOp expression 
    | expression addOp expression 
    | expression compareOp expression 
    | expression boolOp expression;

multOp: '*' | '/' | '%';
addOp: '+' | '-' | '++' | '--' | '+=' | '-='; 
compareOp: '==' | '!=' | '>' | '<' | '>=' | '<=';
boolOp: BOOL_OPERATOR;

BOOL_OPERATOR: 'and' | 'or' | 'xor';

constant: INTEGER | FLOAT | STRING | BOOL | NULL;

INTEGER: [0-9]+;
FLOAT: [0-9]+ '.' [0-9]+;
STRING: '"' ~'"'* '"';
BOOL: 'true' | 'false';
NULL: 'null';

block: '{' line* '}';

classDeclaration: 'class' className '{' classBody '}';

className: IDENTIFIER;

classBody: classMember*;

classMember: fieldDeclaration | methodDeclaration;

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

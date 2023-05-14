using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raudonakmenis.obj.Debug
{
    public class RedstoneVisitor : GrammarBaseVisitor<Object>
    {
        private SymbolTable symbolTable;
        public RedstoneVisitor(SymbolTable symbolTbl) { this.symbolTable = symbolTbl; }
        public override object VisitCompileUnit(GrammarParser.CompileUnitContext context) {


            return Visit(context);
        }
        public override object VisitProgram(GrammarParser.ProgramContext context) {
            foreach (GrammarParser.LineContext line in context.line())
            {
                Visit(line);
            }
            return null;
        }
        public override object VisitLine(GrammarParser.LineContext context) {
            return VisitChildren(context);
        }
        public override object VisitStatement(GrammarParser.StatementContext context) {
            return null;
        }
        public override object VisitAssignment(GrammarParser.AssignmentContext context) {
            string typeName = context.type().GetText();
            object value = Visit(context.expression());
            string varName = context.IDENTIFIER().GetText();

            if (typeName != null && !this.symbolTable.contains(varName))
            {
                this.symbolTable.put(varName, value);
            }
            else if (this.symbolTable.contains(varName))
            {
                this.symbolTable.put(varName, value);
            }
            else
            {
                throw new Exception("Undeclared value");
            }
            return VisitChildren(context);
        }

    }
}
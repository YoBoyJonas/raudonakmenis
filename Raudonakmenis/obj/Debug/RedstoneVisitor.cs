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
        StringBuilder builder = new StringBuilder();
        //public override object VisitCompileUnit(GrammarParser.CompileUnitContext context) {
        //    foreach (var lineContext in context.())
        //    {
        //        VisitLine(lineContext);
        //    }

        //    return null;
        //}
        public override object VisitProgram(GrammarParser.ProgramContext context) {
            base.VisitProgram(context);
            return builder.ToString();
        }
        public override object VisitStatement(GrammarParser.StatementContext context) {
            if (context.assignment() != null)
            {
                return VisitAssignment(context.assignment());
            }
            else if (context.functionCall() != null)
            {
                return VisitFunctionCall(context.functionCall());
            }
            return null;
        }
        public override object VisitLine(GrammarParser.LineContext context) {
            if (context.statement() != null)
            {
                return VisitStatement(context.statement());
            }
            else if (context.ifBlock() != null)
            {
                return VisitIfBlock(context.ifBlock());
            }
            else if (context.whileBlock() != null)
            {
                return VisitWhileBlock(context.whileBlock());
            }
            else if (context.classDeclaration() != null)
            {
                return VisitClassDeclaration(context.classDeclaration());
            }
            else if (context.methodDeclaration() != null)
            {
                return VisitMethodDeclaration(context.methodDeclaration());
            }
            else if (context.classCall() != null)
            {
                return VisitClassCall(context.classCall());
            }

            return null;
        }
        public override object VisitAssignment(GrammarParser.AssignmentContext context) {
            string typeName = context.type().GetText();
            var value = VisitExpression(context.expression());
            //var op = VisitExpression(context.funkyOp());
            string varName = context.IDENTIFIER().GetText();
            //switch (op)
            //{
            //    case "=":
            //        symbolTable[varName] = value;
            //        break;
            //    case "+=":
            //        symbolTable[varName] += value;
            //        break;
            //    case "-=":
            //        symbolTable.add(varName, int.Parse(symbolTable.get(varName).ToString()) - int.Parse(value.ToString()) -= value;
            //        break;
            //    // Handle other funky operators if necessary
            //    default:
            //        Console.WriteLine($"Unknown funky operator: {op}");
            //        break;
            //}
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
        public override object VisitIdExpression(GrammarParser.IdExpressionContext context) {
            string idname = context.IDENTIFIER().GetText();
            return this.symbolTable.get(idname);
        }
        public override object VisitAddExpression(GrammarParser.AddExpressionContext context)
        {
            var val1 = VisitExpression(context.expression(0));
            var val2 = VisitExpression(context.expression(1));
            string operatorText = context.addOp().GetText();
            switch (operatorText)
            {
                case "+":
                    return (int)val1 + (int)val2;
                case "-":
                    return (int)val1 - (int)val2;
                default:
                    throw new InvalidOperationException($"Unsupported intAddOp: {operatorText}");
            }
        }
    
        public override object VisitBoolExpression(GrammarParser.BoolExpressionContext context) {
            var val1 = VisitExpression(context.expression(0));
            var val2 = VisitExpression(context.expression(1));
            string operatorText = context.boolOp().GetText();
            switch (operatorText)
            {
                case "and":
                    return (bool)val1 && (bool)val2;
                case "or":
                    return (bool)val1 || (bool)val2;
                case "xor":
                    return (bool)val1 ^ (bool)val2;
                default:
                    throw new InvalidOperationException($"Unsupported intAddOp: {operatorText}");
            }
        }
        public override object VisitClassExpression(GrammarParser.ClassExpressionContext context) {
            string className = context.classFunctionCall().IDENTIFIER().GetText();
            string methodName = context.classFunctionCall().methodName().GetText();
            List<object> arguments = new List<object>();

            if (context.classFunctionCall().expression().Length > 0)
            {
                foreach (var expressionContext in context.classFunctionCall().expression())
                {
                    object argument = VisitExpression(expressionContext);
                    arguments.Add(argument);
                }
            }
            return VisitChildren(context);
        }
        public override object VisitMultExpression( GrammarParser.MultExpressionContext context) {
            var val1 = VisitExpression(context.expression(0));
            var val2 = VisitExpression(context.expression(1));
            string operatorText = context.multOp().GetText();
            switch (operatorText)
            {
                case "*":
                    return (int)val1 * (int)val2;
                case "/":
                    return (int)val1 / (int)val2;
                case "%":
                    return (int)val1 % (int)val2;
                default:
                    throw new InvalidOperationException($"Unsupported intAddOp: {operatorText}");
            }
        }
        public override object VisitNotExpression( GrammarParser.NotExpressionContext context) {
            var val1 = VisitExpression(context.expression());
            return !(bool)val1;
        }
        public override object VisitFunctionExpression(GrammarParser.FunctionExpressionContext context) {
            var functionName = context.functionCall().IDENTIFIER().GetText();
            List<object> arguments = new List<object>();

            if (context.functionCall().expression().Length > 0)
            {
                foreach (var expressionContext in context.functionCall().expression())
                {
                    object argument = VisitExpression(expressionContext);
                    arguments.Add(argument);
                }
            }
            return null;
        }
        public override object VisitPrintStatement(GrammarParser.PrintStatementContext context) {
            string text = VisitExpression(context.expression()).ToString();
            builder.Append(text).Append("\n");
            return null;
        }
        public override object VisitParanthesesExpression( GrammarParser.ParanthesesExpressionContext context) {
            return VisitExpression(context.expression());
        }
        public override object VisitIfBlock( GrammarParser.IfBlockContext context) {
            var condition = VisitExpression(context.expression());
            var ifBlock = VisitBlockas(context.blockas());
            var elseBlock = context.elseIfBlock() != null ? VisitElseIfBlock(context.elseIfBlock()) : null;

            if ((bool)condition)
            {
                // Execute the if block
                VisitBlockas(context.blockas());
            }
            else if (elseBlock != null)
            {
                // Execute the else block
                VisitElseIfBlock(context.elseIfBlock());
            }

            return null;
        }
        public override object VisitElseIfBlock(GrammarParser.ElseIfBlockContext context) {
            if (context.ifBlock() != null)
            {
                return VisitIfBlock(context.ifBlock());
            }
            else if (context.blockWithReturn() != null)
            {
                return VisitBlockWithReturn(context.blockWithReturn());
            }

            return null;
        }
    }

}

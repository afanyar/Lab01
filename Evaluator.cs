using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01._2.MyGrammar
{
    public class Evaluator : MyGrammarBaseVisitor<double>
    {
        private readonly Dictionary<string, string> cell_expressions;

        public Evaluator(Dictionary<string, string> cell_expressions)
        {
            this.cell_expressions = cell_expressions;
        }

        public double Evaluate(string expression)
        {
            var lexer = new MyGrammarLexer(new AntlrInputStream(expression));
            var tokens = new CommonTokenStream(lexer);
            var parser = new MyGrammarParser(tokens);

            var tree = parser.expression();

            ValidateTree(tree);

            return Visit(tree);
        }

        public override double VisitMultiplicativeExpression(MyGrammarParser.MultiplicativeExpressionContext context)
        {
            var left = Visit(context.left);
            var right = Visit(context.right);

            return context.GetChild(1).GetText() switch
            {
                "*" => left * right,
                "/" => DivideOrModuloLeftByRight(left, right, "/"),
                "div" => Math.Floor(DivideOrModuloLeftByRight(left, right, "/")),
                "mod" => DivideOrModuloLeftByRight(left, right, "mod"),
                _ => throw new InvalidOperationException("Invalid multiplicative operator")
            };
        }

        public override double VisitAdditiveExpression(MyGrammarParser.AdditiveExpressionContext context)
        {
            var left = Visit(context.left);
            var right = Visit(context.right);

            return context.GetChild(1).GetText() switch
            {
                "+" => left + right,
                "-" => left - right,
                _ => throw new InvalidOperationException("Invalid additive operator")
            };
        }

        public override double VisitUnaryExpression(MyGrammarParser.UnaryExpressionContext context)
        {
            var right = Visit(context.right);

            if (context.op.Text == "-")
            {
                return -right;
            }

            if (context.op.Text == "+")
            {
                return right;
            }

            throw new InvalidOperationException("Invalid unary operator");
        }

        /*public override double VisitIncrementExpression(MyGrammarParser.IncrementExpressionContext context)
        { 
            var value = Visit(context.expression()); 
            return value + 1; 
        }
        public override double VisitDecrementExpression(MyGrammarParser.DecrementExpressionContext context)
        { 
            var value = Visit(context.expression()); 
            return value - 1; 
        }*/

        public override double VisitNumber(MyGrammarParser.NumberContext context)
        {
            if (double.TryParse(context.GetText(), System.Globalization.NumberStyles.Float,
                                System.Globalization.CultureInfo.InvariantCulture, out double result))
            {
                return result;
            }

            return 0;
        }

        public override double VisitParenthesizedExpression(MyGrammarParser.ParenthesizedExpressionContext context)
        {
            return Visit(context.expression());
        }


        public override double VisitCell(MyGrammarParser.CellContext context)
        {
            string cell_name = context.GetText()[1..];

            if (cell_expressions.ContainsKey(cell_name))
            {
                string expr = cell_expressions[cell_name];
                return Evaluate(expr);
            }
            else
            {
                throw new InvalidDataException($"Не існує клітинки {cell_name}");
            }
        }

        public static double DivideOrModuloLeftByRight(double left, double right, string operation)
        {
            if (operation == "mod")
            {
                return right == 0 ? throw new DivideByZeroException("Операція mod: правий операнд не може дорівнювати нулю.") : (left % right);
            }

            if (operation == "/")
            {
                return right == 0 ? throw new DivideByZeroException("Операція ділення: правий операнд не може дорівнювати нулю.") : (left / right);
            }

            throw new InvalidOperationException("Невідомий оператор ділення");
        }

        public void ValidateTree(IParseTree tree)
        {
            if (tree is TerminalNodeImpl terminal_node && terminal_node.Symbol.Type == MyGrammarLexer.INVALID)
            {
                throw new InvalidDataException("Введено невідомий символ");
            }

            for (int i = 0; i < tree.ChildCount; i++)
            {
                ValidateTree(tree.GetChild(i));
            }
        }

        public static void HandleEmptyExpression(string expr)
        {
            if (string.IsNullOrEmpty(expr) || string.IsNullOrWhiteSpace(expr))
            {
                throw new ArgumentNullException(nameof(expr), "Введений вираз пустий.");
            }
        }
    }
}

using Lab01._2.MyGrammar;

namespace UnitTests
{
    public class EvaluatorTests
    {
        [Fact]
        public void Evaluate_ValidExpression_ReturnsValidResult()
        {
            var evaluator = new Evaluator(new Dictionary<string, string>());

            var result1 = evaluator.Evaluate("2 + -3 * (9 mod 7)");

            Assert.Equal(-4, result1);
        }

        [Fact]
        public void Evaluate_InvalidExpression_ThrowsDivideByZeroException()
        {
            var evaluator = new Evaluator(new Dictionary<string, string>());

            var exception = Assert.Throws<DivideByZeroException>(() => evaluator.Evaluate("2 / 0"));

            Assert.Equal("Îïåðàö³ÿ ä³ëåííÿ: ïðàâèé îïåðàíä íå ìîæå äîð³âíþâàòè íóëþ.", exception.Message);
        }

        [Fact]
        public void Evaluate_InvalidExpression_ThrowsInvalidDataException()
        {
            var evaluator = new Evaluator(new Dictionary<string, string>());

            var exception = Assert.Throws<InvalidDataException>(() => evaluator.Evaluate("8 + helloworld 9 -2..0 + 2 * 0 / 2"));

            Assert.Equal("Ââåäåíî íåâ³äîìèé ñèìâîë", exception.Message);
        }
    }
}
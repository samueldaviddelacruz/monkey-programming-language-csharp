using Microsoft.VisualStudio.TestTools.UnitTesting;

using monkey_programming_language_csharp.Token;

namespace monkey_programming_language_csharp.lexer_test;

[TestClass]
public class LexerTest
{
    [TestMethod]
    public void TestNextToken()
    {
        var tests = new []
        {
            new {expectedType = TokenTypes.ASSIGN, expectedLiteral = "="},
            new {expectedType = TokenTypes.PLUS, expectedLiteral = "+"},
            new {expectedType = TokenTypes.LPAREN, expectedLiteral = "("},
            new {expectedType = TokenTypes.RPAREN, expectedLiteral = ")"},
            new {expectedType = TokenTypes.LBRACE, expectedLiteral = "{"},
            new {expectedType = TokenTypes.RBRACE, expectedLiteral = "}"},
            new {expectedType = TokenTypes.COMMA, expectedLiteral = ","},
            new {expectedType = TokenTypes.SEMICOLON, expectedLiteral = ";"},
            new {expectedType = TokenTypes.EOF, expectedLiteral = ""},
        };
        var input = @"=+(){},;";
        var l = new Lexer.Lexer(input);
        foreach (var t in tests)
        {
            var tok = l.NextToken();
            Assert.AreEqual(t.expectedLiteral, tok.Literal);
            Assert.AreEqual(t.expectedType, tok.Type);
        }
    }
}
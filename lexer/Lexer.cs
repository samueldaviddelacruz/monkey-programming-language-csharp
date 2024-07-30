using monkey_programming_language_csharp.Token;

namespace monkey_programming_language_csharp.Lexer;


public class Lexer
{
    private string Input { get; }
    public int Position { get; set; } // current position in input (points to current char)
    private int ReadPosition { get; set; } // current reading position in input (after current char)
    private byte Ch { get; set; }  // current char under examination
    public Lexer(string input)
    {
        Input = input;
        ReadChar();
    }

    private void ReadChar()
    {
        if (ReadPosition >= Input.Length)
        {
            Ch = 0;
        }
        else
        {
            Ch = (byte)Input[ReadPosition];
        }
        Position = ReadPosition;
        ReadPosition += 1;
    }
    public Token.Token NextToken()
    {
        var tok = new Token.Token();
        switch (Ch)
        {
            case (byte)'=':
                tok = NewToken(TokenTypes.ASSIGN, Ch);
                break;
            case (byte)';':
                tok = NewToken(TokenTypes.SEMICOLON, Ch);
                break;
            case (byte)'(':
                tok = NewToken(TokenTypes.LPAREN, Ch);
                break;
            case (byte)')':
                tok = NewToken(TokenTypes.RPAREN, Ch);
                break;
            case (byte)',':
                tok = NewToken(TokenTypes.COMMA, Ch);
                break;
            case (byte)'+':
                tok = NewToken(TokenTypes.PLUS, Ch);
                break;
            case (byte)'{':
                tok = NewToken(TokenTypes.LBRACE, Ch);
                break;
            case (byte)'}':
                tok = NewToken(TokenTypes.RBRACE, Ch);
                break;
            case 0:
                tok.Literal = "";
                tok.Type = TokenTypes.EOF;
            break;
        }
        ReadChar();
        return tok;
    }

    private Token.Token NewToken(string tokenType, byte ch)
    {
        return new Token.Token{Literal = $"{(char)ch}", Type = tokenType  };
    }
}
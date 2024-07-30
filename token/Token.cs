namespace monkey_programming_language_csharp.Token;


public static class TokenTypes
{
    public const string ILLEGAL = "ILLEGAL";
    public const string EOF = "EOF";
    // Identifiers + literals
    public const string IDENT = "IDENT"; // add, foobar, x, y, ...
    public const string INT = "INT";
    // Operators
    public const string ASSIGN = "=";
    public const string PLUS = "+";
    // Delimiters
    public const string COMMA = ",";
    public const string SEMICOLON = ";";
    public const string LPAREN = "(";
    public const string RPAREN = ")";
    public const string LBRACE = "{";
    public const string RBRACE = "}";
    // Keywords
    // 1343456
    public const string FUNCTION = "FUNCTION";
    public const string LET = "LET";
}
public class Token
{

    public string Literal { get; set; } = "";
    public string Type {get;set;} = "";
}
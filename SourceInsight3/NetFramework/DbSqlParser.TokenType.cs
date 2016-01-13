public class TokenType : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, System.IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(System.IFormatProvider provider) {}
	public virtual System.TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public TokenType Null;
	public TokenType Identifier;
	public TokenType QuotedIdentifier;
	public TokenType String;
	public TokenType Other;
	public TokenType Other_Comma;
	public TokenType Other_Period;
	public TokenType Other_LeftParen;
	public TokenType Other_RightParen;
	public TokenType Other_Star;
	public TokenType Keyword;
	public TokenType Keyword_ALL;
	public TokenType Keyword_AS;
	public TokenType Keyword_COMPUTE;
	public TokenType Keyword_CROSS;
	public TokenType Keyword_DISTINCT;
	public TokenType Keyword_FOR;
	public TokenType Keyword_FROM;
	public TokenType Keyword_FULL;
	public TokenType Keyword_GROUP;
	public TokenType Keyword_HAVING;
	public TokenType Keyword_INNER;
	public TokenType Keyword_INTERSECT;
	public TokenType Keyword_INTO;
	public TokenType Keyword_JOIN;
	public TokenType Keyword_LEFT;
	public TokenType Keyword_MINUS;
	public TokenType Keyword_NATURAL;
	public TokenType Keyword_ON;
	public TokenType Keyword_ORDER;
	public TokenType Keyword_OUTER;
	public TokenType Keyword_RIGHT;
	public TokenType Keyword_SELECT;
	public TokenType Keyword_TOP;
	public TokenType Keyword_UNION;
	public TokenType Keyword_USING;
	public TokenType Keyword_WHERE;
}


public class LexKind : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public LexKind Comma;
	public LexKind Slash;
	public LexKind At;
	public LexKind Dot;
	public LexKind LParens;
	public LexKind RParens;
	public LexKind LBracket;
	public LexKind RBracket;
	public LexKind Star;
	public LexKind Plus;
	public LexKind Minus;
	public LexKind Eq;
	public LexKind Lt;
	public LexKind Gt;
	public LexKind Bang;
	public LexKind Dollar;
	public LexKind Apos;
	public LexKind Quote;
	public LexKind Union;
	public LexKind Ne;
	public LexKind Le;
	public LexKind Ge;
	public LexKind And;
	public LexKind Or;
	public LexKind DotDot;
	public LexKind SlashSlash;
	public LexKind Name;
	public LexKind String;
	public LexKind Number;
	public LexKind Axe;
	public LexKind Eof;
}


public class UnicodeCategory : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public UnicodeCategory UppercaseLetter;
	public UnicodeCategory LowercaseLetter;
	public UnicodeCategory TitlecaseLetter;
	public UnicodeCategory ModifierLetter;
	public UnicodeCategory OtherLetter;
	public UnicodeCategory NonSpacingMark;
	public UnicodeCategory SpacingCombiningMark;
	public UnicodeCategory EnclosingMark;
	public UnicodeCategory DecimalDigitNumber;
	public UnicodeCategory LetterNumber;
	public UnicodeCategory OtherNumber;
	public UnicodeCategory SpaceSeparator;
	public UnicodeCategory LineSeparator;
	public UnicodeCategory ParagraphSeparator;
	public UnicodeCategory Control;
	public UnicodeCategory Format;
	public UnicodeCategory Surrogate;
	public UnicodeCategory PrivateUse;
	public UnicodeCategory ConnectorPunctuation;
	public UnicodeCategory DashPunctuation;
	public UnicodeCategory OpenPunctuation;
	public UnicodeCategory ClosePunctuation;
	public UnicodeCategory InitialQuotePunctuation;
	public UnicodeCategory FinalQuotePunctuation;
	public UnicodeCategory OtherPunctuation;
	public UnicodeCategory MathSymbol;
	public UnicodeCategory CurrencySymbol;
	public UnicodeCategory ModifierSymbol;
	public UnicodeCategory OtherSymbol;
	public UnicodeCategory OtherNotAssigned;
}


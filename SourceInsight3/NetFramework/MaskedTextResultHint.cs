public class MaskedTextResultHint : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public MaskedTextResultHint Unknown;
	public MaskedTextResultHint CharacterEscaped;
	public MaskedTextResultHint NoEffect;
	public MaskedTextResultHint SideEffect;
	public MaskedTextResultHint Success;
	public MaskedTextResultHint AsciiCharacterExpected;
	public MaskedTextResultHint AlphanumericCharacterExpected;
	public MaskedTextResultHint DigitExpected;
	public MaskedTextResultHint LetterExpected;
	public MaskedTextResultHint SignedDigitExpected;
	public MaskedTextResultHint InvalidInput;
	public MaskedTextResultHint PromptCharNotAllowed;
	public MaskedTextResultHint UnavailableEditPosition;
	public MaskedTextResultHint NonEditPosition;
	public MaskedTextResultHint PositionOutOfRange;
}


public class OperandType : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public OperandType InlineBrTarget;
	public OperandType InlineField;
	public OperandType InlineI;
	public OperandType InlineI8;
	public OperandType InlineMethod;
	public OperandType InlineNone;
	public OperandType InlinePhi;
	public OperandType InlineR;
	public OperandType InlineSig;
	public OperandType InlineString;
	public OperandType InlineSwitch;
	public OperandType InlineTok;
	public OperandType InlineType;
	public OperandType InlineVar;
	public OperandType ShortInlineBrTarget;
	public OperandType ShortInlineI;
	public OperandType ShortInlineR;
	public OperandType ShortInlineVar;
}


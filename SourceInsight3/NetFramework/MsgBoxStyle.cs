public class MsgBoxStyle : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public MsgBoxStyle OkOnly;
	public MsgBoxStyle OkCancel;
	public MsgBoxStyle AbortRetryIgnore;
	public MsgBoxStyle YesNoCancel;
	public MsgBoxStyle YesNo;
	public MsgBoxStyle RetryCancel;
	public MsgBoxStyle Critical;
	public MsgBoxStyle Question;
	public MsgBoxStyle Exclamation;
	public MsgBoxStyle Information;
	public MsgBoxStyle DefaultButton1;
	public MsgBoxStyle DefaultButton2;
	public MsgBoxStyle DefaultButton3;
	public MsgBoxStyle ApplicationModal;
	public MsgBoxStyle SystemModal;
	public MsgBoxStyle MsgBoxHelp;
	public MsgBoxStyle MsgBoxRight;
	public MsgBoxStyle MsgBoxRtlReading;
	public MsgBoxStyle MsgBoxSetForeground;
}


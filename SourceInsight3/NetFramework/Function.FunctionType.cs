public class FunctionType : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public FunctionType FuncLast;
	public FunctionType FuncPosition;
	public FunctionType FuncCount;
	public FunctionType FuncID;
	public FunctionType FuncLocalName;
	public FunctionType FuncNameSpaceUri;
	public FunctionType FuncName;
	public FunctionType FuncString;
	public FunctionType FuncBoolean;
	public FunctionType FuncNumber;
	public FunctionType FuncTrue;
	public FunctionType FuncFalse;
	public FunctionType FuncNot;
	public FunctionType FuncConcat;
	public FunctionType FuncStartsWith;
	public FunctionType FuncContains;
	public FunctionType FuncSubstringBefore;
	public FunctionType FuncSubstringAfter;
	public FunctionType FuncSubstring;
	public FunctionType FuncStringLength;
	public FunctionType FuncNormalize;
	public FunctionType FuncTranslate;
	public FunctionType FuncLang;
	public FunctionType FuncSum;
	public FunctionType FuncFloor;
	public FunctionType FuncCeiling;
	public FunctionType FuncRound;
	public FunctionType FuncUserDefined;
}


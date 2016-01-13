public class JSFunctionAttributeEnum : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public JSFunctionAttributeEnum None;
	public JSFunctionAttributeEnum HasArguments;
	public JSFunctionAttributeEnum HasThisObject;
	public JSFunctionAttributeEnum IsNested;
	public JSFunctionAttributeEnum HasStackFrame;
	public JSFunctionAttributeEnum HasVarArgs;
	public JSFunctionAttributeEnum HasEngine;
	public JSFunctionAttributeEnum IsExpandoMethod;
	public JSFunctionAttributeEnum IsInstanceNestedClassConstructor;
	public JSFunctionAttributeEnum ClassicFunction;
	public JSFunctionAttributeEnum NestedFunction;
	public JSFunctionAttributeEnum ClassicNestedFunction;
}


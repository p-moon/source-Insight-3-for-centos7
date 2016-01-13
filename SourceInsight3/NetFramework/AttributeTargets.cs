public class AttributeTargets : Enum, IComparable, IFormattable, IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(IFormatProvider provider) {}
	public virtual TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public AttributeTargets Assembly;
	public AttributeTargets Module;
	public AttributeTargets Class;
	public AttributeTargets Struct;
	public AttributeTargets Enum;
	public AttributeTargets Constructor;
	public AttributeTargets Method;
	public AttributeTargets Property;
	public AttributeTargets Field;
	public AttributeTargets Event;
	public AttributeTargets Interface;
	public AttributeTargets Parameter;
	public AttributeTargets Delegate;
	public AttributeTargets ReturnValue;
	public AttributeTargets GenericParameter;
	public AttributeTargets All;
}


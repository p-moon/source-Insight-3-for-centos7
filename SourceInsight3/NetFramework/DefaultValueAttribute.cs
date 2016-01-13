public class DefaultValueAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DefaultValueAttribute(Type type, string value) {}
	public DefaultValueAttribute(char value) {}
	public DefaultValueAttribute(byte value) {}
	public DefaultValueAttribute(short value) {}
	public DefaultValueAttribute(int value) {}
	public DefaultValueAttribute(long value) {}
	public DefaultValueAttribute(float value) {}
	public DefaultValueAttribute(double value) {}
	public DefaultValueAttribute(bool value) {}
	public DefaultValueAttribute(string value) {}
	public DefaultValueAttribute(object value) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public object Value { get{} }
	public object TypeId { get{} }
}


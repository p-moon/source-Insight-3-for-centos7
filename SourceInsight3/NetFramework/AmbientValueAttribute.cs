public class AmbientValueAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public AmbientValueAttribute(Type type, string value) {}
	public AmbientValueAttribute(char value) {}
	public AmbientValueAttribute(byte value) {}
	public AmbientValueAttribute(short value) {}
	public AmbientValueAttribute(int value) {}
	public AmbientValueAttribute(long value) {}
	public AmbientValueAttribute(float value) {}
	public AmbientValueAttribute(double value) {}
	public AmbientValueAttribute(bool value) {}
	public AmbientValueAttribute(string value) {}
	public AmbientValueAttribute(object value) {}

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


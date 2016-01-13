public class ParameterBuilder : System.Runtime.InteropServices._ParameterBuilder
{

	// Methods
	public virtual void SetMarshal(UnmanagedMarshal unmanagedMarshal) {}
	public virtual void SetConstant(object defaultValue) {}
	public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) {}
	public void SetCustomAttribute(CustomAttributeBuilder customBuilder) {}
	public virtual ParameterToken GetToken() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public int Position { get{} }
	public int Attributes { get{} }
	public bool IsIn { get{} }
	public bool IsOut { get{} }
	public bool IsOptional { get{} }
}


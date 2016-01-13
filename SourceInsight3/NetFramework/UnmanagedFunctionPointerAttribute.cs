public class UnmanagedFunctionPointerAttribute : System.Attribute, _Attribute
{

	// Constructors
	public UnmanagedFunctionPointerAttribute(CallingConvention callingConvention) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public CharSet CharSet;
	public bool BestFitMapping;
	public bool ThrowOnUnmappableChar;
	public bool SetLastError;

	// Properties
	public CallingConvention CallingConvention { get{} }
	public object TypeId { get{} }
}


public class DllImportAttribute : System.Attribute, _Attribute
{

	// Constructors
	public DllImportAttribute(string dllName) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public string EntryPoint;
	public CharSet CharSet;
	public bool SetLastError;
	public bool ExactSpelling;
	public bool PreserveSig;
	public CallingConvention CallingConvention;
	public bool BestFitMapping;
	public bool ThrowOnUnmappableChar;

	// Properties
	public string Value { get{} }
	public object TypeId { get{} }
}


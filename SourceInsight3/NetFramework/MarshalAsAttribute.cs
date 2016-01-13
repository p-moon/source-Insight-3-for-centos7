public class MarshalAsAttribute : System.Attribute, _Attribute
{

	// Constructors
	public MarshalAsAttribute(UnmanagedType unmanagedType) {}
	public MarshalAsAttribute(short unmanagedType) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public VarEnum SafeArraySubType;
	public Type SafeArrayUserDefinedSubType;
	public int IidParameterIndex;
	public UnmanagedType ArraySubType;
	public short SizeParamIndex;
	public int SizeConst;
	public string MarshalType;
	public Type MarshalTypeRef;
	public string MarshalCookie;

	// Properties
	public UnmanagedType Value { get{} }
	public object TypeId { get{} }
}


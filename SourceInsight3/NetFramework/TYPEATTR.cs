public class TYPEATTR : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public System.Guid guid;
	public int lcid;
	public int dwReserved;
	public int memidConstructor;
	public int memidDestructor;
	public System.IntPtr lpstrSchema;
	public int cbSizeInstance;
	public TYPEKIND typekind;
	public short cFuncs;
	public short cVars;
	public short cImplTypes;
	public short cbSizeVft;
	public short cbAlignment;
	public TYPEFLAGS wTypeFlags;
	public short wMajorVerNum;
	public short wMinorVerNum;
	public TYPEDESC tdescAlias;
	public IDLDESC idldescType;
	public int MEMBER_ID_NIL;
}


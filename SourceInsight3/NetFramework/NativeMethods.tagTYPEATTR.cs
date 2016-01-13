public class tagTYPEATTR
{

	// Constructors
	public tagTYPEATTR() {}

	// Methods
	public tagTYPEDESC Get_tdescAlias() {}
	public tagIDLDESC Get_idldescType() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public System.Guid guid;
	public int lcid;
	public int dwReserved;
	public int memidConstructor;
	public int memidDestructor;
	public System.IntPtr lpstrSchema;
	public int cbSizeInstance;
	public int typekind;
	public short cFuncs;
	public short cVars;
	public short cImplTypes;
	public short cbSizeVft;
	public short cbAlignment;
	public short wTypeFlags;
	public short wMajorVerNum;
	public short wMinorVerNum;
	public int tdescAlias_unionMember;
	public short tdescAlias_vt;
	public int idldescType_dwReserved;
	public short idldescType_wIDLFlags;
}


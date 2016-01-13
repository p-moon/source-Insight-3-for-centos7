public class FUNCDESC : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public int memid;
	public System.IntPtr lprgscode;
	public System.IntPtr lprgelemdescParam;
	public FUNCKIND funckind;
	public INVOKEKIND invkind;
	public CALLCONV callconv;
	public short cParams;
	public short cParamsOpt;
	public short oVft;
	public short cScodes;
	public ELEMDESC elemdescFunc;
	public short wFuncFlags;
}


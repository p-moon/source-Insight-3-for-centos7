public class tagFUNCDESC
{

	// Constructors
	public tagFUNCDESC() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int memid;
	public System.IntPtr lprgscode;
	public System.IntPtr lprgelemdescParam;
	public int funckind;
	public int invkind;
	public int callconv;
	public short cParams;
	public short cParamsOpt;
	public short oVft;
	public short cScodesi;
	public value_tagELEMDESC elemdescFunc;
	public short wFuncFlags;
}


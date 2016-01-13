public class VARDESC : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public int memid;
	public string lpstrSchema;
	public DESCUNION desc;
	public ELEMDESC elemdescVar;
	public short wVarFlags;
	public VARKIND varkind;
}


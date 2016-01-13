public class MSAAMENUINFO : System.ValueType
{

	// Constructors
	public MSAAMENUINFO(string text) {}

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public int dwMSAASignature;
	public int cchWText;
	public string pszWText;
}


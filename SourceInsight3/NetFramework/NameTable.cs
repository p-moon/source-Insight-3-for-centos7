public class NameTable : XmlNameTable
{

	// Constructors
	public NameTable() {}

	// Methods
	public virtual string Add(string key) {}
	public virtual string Add(char[] key, int start, int len) {}
	public virtual string Get(string value) {}
	public virtual string Get(char[] key, int start, int len) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


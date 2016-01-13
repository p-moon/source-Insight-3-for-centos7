public class XmlNameTable
{

	// Methods
	public abstract virtual string Get(char[] array, int offset, int length) {}
	public abstract virtual string Get(string array) {}
	public abstract virtual string Add(char[] array, int offset, int length) {}
	public abstract virtual string Add(string array) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


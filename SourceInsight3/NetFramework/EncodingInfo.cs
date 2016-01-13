public class EncodingInfo
{

	// Methods
	public Encoding GetEncoding() {}
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public int CodePage { get{} }
	public string Name { get{} }
	public string DisplayName { get{} }
}


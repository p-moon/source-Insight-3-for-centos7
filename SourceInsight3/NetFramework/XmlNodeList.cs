public class XmlNodeList : System.Collections.IEnumerable
{

	// Methods
	public abstract virtual XmlNode Item(int index) {}
	public abstract virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public XmlNode ItemOf { get{} }
}


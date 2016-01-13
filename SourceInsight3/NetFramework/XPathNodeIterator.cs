public class XPathNodeIterator : System.ICloneable, System.Collections.IEnumerable
{

	// Methods
	public abstract virtual XPathNodeIterator Clone() {}
	public abstract virtual bool MoveNext() {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public XPathNavigator Current { get{} }
	public int CurrentPosition { get{} }
	public int Count { get{} }
}


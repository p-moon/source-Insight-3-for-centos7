public class XmlQueryItemSequence : XmlQuerySequence<System.Xml.XPath.XPathItem>, IList<System.Xml.XPath.XPathItem>, ICollection<System.Xml.XPath.XPathItem>, IEnumerable<System.Xml.XPath.XPathItem>, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection
{

	// Constructors
	public XmlQueryItemSequence() {}
	public XmlQueryItemSequence(int capacity) {}
	public XmlQueryItemSequence(System.Xml.XPath.XPathItem item) {}

	// Methods
	public static XmlQueryItemSequence CreateOrReuse(XmlQueryItemSequence seq) {}
	public static XmlQueryItemSequence CreateOrReuse(XmlQueryItemSequence seq, System.Xml.XPath.XPathItem item) {}
	public void AddClone(System.Xml.XPath.XPathItem item) {}
	public virtual IEnumerator<System.Xml.XPath.XPathItem> GetEnumerator() {}
	public virtual bool Contains(System.Xml.XPath.XPathItem value) {}
	public virtual void CopyTo(System.Xml.XPath.XPathItem[] array, int index) {}
	public virtual int IndexOf(System.Xml.XPath.XPathItem value) {}
	public void Clear() {}
	public void Add(System.Xml.XPath.XPathItem value) {}
	public void SortByKeys(System.Array keys) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public XmlQueryItemSequence Empty;

	// Properties
	public int Count { get{} }
	public System.Xml.XPath.XPathItem Item { get{} set{} }
}


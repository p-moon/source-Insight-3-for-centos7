public class XmlQueryNodeSequence : XmlQuerySequence<System.Xml.XPath.XPathNavigator>, IList<System.Xml.XPath.XPathNavigator>, ICollection<System.Xml.XPath.XPathNavigator>, IEnumerable<System.Xml.XPath.XPathNavigator>, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, IList<System.Xml.XPath.XPathItem>, ICollection<System.Xml.XPath.XPathItem>, IEnumerable<System.Xml.XPath.XPathItem>
{

	// Constructors
	public XmlQueryNodeSequence() {}
	public XmlQueryNodeSequence(int capacity) {}
	public XmlQueryNodeSequence(IList<System.Xml.XPath.XPathNavigator> list) {}
	public XmlQueryNodeSequence(System.Xml.XPath.XPathNavigator[] array, int size) {}
	public XmlQueryNodeSequence(System.Xml.XPath.XPathNavigator navigator) {}

	// Methods
	public static XmlQueryNodeSequence CreateOrReuse(XmlQueryNodeSequence seq) {}
	public static XmlQueryNodeSequence CreateOrReuse(XmlQueryNodeSequence seq, System.Xml.XPath.XPathNavigator navigator) {}
	public XmlQueryNodeSequence DocOrderDistinct(IComparer<System.Xml.XPath.XPathNavigator> comparer) {}
	public void AddClone(System.Xml.XPath.XPathNavigator navigator) {}
	public virtual IEnumerator<System.Xml.XPath.XPathNavigator> GetEnumerator() {}
	public virtual bool Contains(System.Xml.XPath.XPathNavigator value) {}
	public virtual void CopyTo(System.Xml.XPath.XPathNavigator[] array, int index) {}
	public virtual int IndexOf(System.Xml.XPath.XPathNavigator value) {}
	public void Clear() {}
	public void Add(System.Xml.XPath.XPathNavigator value) {}
	public void SortByKeys(System.Array keys) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public XmlQueryNodeSequence Empty;

	// Properties
	public bool IsDocOrderDistinct { get{} set{} }
	public int Count { get{} }
	public System.Xml.XPath.XPathNavigator Item { get{} set{} }
}


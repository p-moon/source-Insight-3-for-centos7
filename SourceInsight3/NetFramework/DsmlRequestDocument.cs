public class DsmlRequestDocument : DsmlDocument, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public DsmlRequestDocument() {}

	// Methods
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public int Add(DirectoryRequest request) {}
	public void Clear() {}
	public bool Contains(DirectoryRequest value) {}
	public int IndexOf(DirectoryRequest value) {}
	public void Insert(int index, DirectoryRequest value) {}
	public void Remove(DirectoryRequest value) {}
	public void RemoveAt(int index) {}
	public void CopyTo(DirectoryRequest[] value, int i) {}
	public virtual System.Xml.XmlDocument ToXml() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DsmlDocumentProcessing DocumentProcessing { get{} set{} }
	public DsmlResponseOrder ResponseOrder { get{} set{} }
	public DsmlErrorProcessing ErrorProcessing { get{} set{} }
	public string RequestId { get{} set{} }
	public int Count { get{} }
	public DirectoryRequest Item { get{} set{} }
}


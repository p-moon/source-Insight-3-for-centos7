public class DsmlResponseDocument : DsmlDocument, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public virtual System.Xml.XmlDocument ToXml() {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void CopyTo(DirectoryResponse[] value, int i) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsErrorResponse { get{} }
	public bool IsOperationError { get{} }
	public string RequestId { get{} }
	public int Count { get{} }
	public DirectoryResponse Item { get{} }
}


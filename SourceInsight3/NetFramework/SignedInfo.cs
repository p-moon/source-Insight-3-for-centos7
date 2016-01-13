public class SignedInfo : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public SignedInfo() {}

	// Methods
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public System.Xml.XmlElement GetXml() {}
	public void LoadXml(System.Xml.XmlElement value) {}
	public void AddReference(Reference reference) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
	public string Id { get{} set{} }
	public string CanonicalizationMethod { get{} set{} }
	public Transform CanonicalizationMethodObject { get{} }
	public string SignatureMethod { get{} set{} }
	public string SignatureLength { get{} set{} }
	public System.Collections.ArrayList References { get{} }
}


public class ContentDisposition
{

	// Constructors
	public ContentDisposition() {}
	public ContentDisposition(string disposition) {}

	// Methods
	public virtual string ToString() {}
	public virtual bool Equals(object rparam) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}

	// Properties
	public string DispositionType { get{} set{} }
	public System.Collections.Specialized.StringDictionary Parameters { get{} }
	public string FileName { get{} set{} }
	public System.DateTime CreationDate { get{} set{} }
	public System.DateTime ModificationDate { get{} set{} }
	public bool Inline { get{} set{} }
	public System.DateTime ReadDate { get{} set{} }
	public long Size { get{} set{} }
}


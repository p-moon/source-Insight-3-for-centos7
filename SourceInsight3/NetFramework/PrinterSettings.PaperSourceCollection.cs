public class PaperSourceCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public PaperSourceCollection(PaperSource[] array) {}

	// Methods
	public System.Collections.IEnumerator GetEnumerator() {}
	public void CopyTo(PaperSource[] paperSources, int index) {}
	public int Add(PaperSource paperSource) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public PaperSource Item { get{} }
}


public class PaperSizeCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public PaperSizeCollection(PaperSize[] array) {}

	// Methods
	public System.Collections.IEnumerator GetEnumerator() {}
	public void CopyTo(PaperSize[] paperSizes, int index) {}
	public int Add(PaperSize paperSize) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public PaperSize Item { get{} }
}


public class DesignerAutoFormatCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public DesignerAutoFormatCollection() {}

	// Methods
	public int Add(DesignerAutoFormat format) {}
	public virtual void Clear() {}
	public bool Contains(DesignerAutoFormat format) {}
	public int IndexOf(DesignerAutoFormat format) {}
	public void Insert(int index, DesignerAutoFormat format) {}
	public void Remove(DesignerAutoFormat format) {}
	public void RemoveAt(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public System.Drawing.Size PreviewSize { get{} }
	public object SyncRoot { get{} }
	public DesignerAutoFormat Item { get{} }
}


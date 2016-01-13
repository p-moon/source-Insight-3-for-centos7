public class AdamInstanceCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public bool Contains(AdamInstance adamInstance) {}
	public int IndexOf(AdamInstance adamInstance) {}
	public void CopyTo(AdamInstance[] adamInstances, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public AdamInstance Item { get{} }
	public int Count { get{} }
}


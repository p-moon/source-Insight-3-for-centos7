public class IntegerCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public IntegerCollection(ListBox owner) {}

	// Methods
	public bool Contains(int item) {}
	public void Clear() {}
	public int IndexOf(int item) {}
	public int Add(int item) {}
	public void AddRange(int[] items) {}
	public void AddRange(IntegerCollection value) {}
	public void Remove(int item) {}
	public void RemoveAt(int index) {}
	public virtual void CopyTo(System.Array destination, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public int Item { get{} set{} }
}


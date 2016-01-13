public class ValidatorCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ValidatorCollection() {}

	// Methods
	public void Add(IValidator validator) {}
	public bool Contains(IValidator validator) {}
	public void Remove(IValidator validator) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public IValidator Item { get{} }
	public object SyncRoot { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
}


public class BindingCollection : ServiceDescriptionBaseCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public int Add(Binding binding) {}
	public void Insert(int index, Binding binding) {}
	public int IndexOf(Binding binding) {}
	public bool Contains(Binding binding) {}
	public void Remove(Binding binding) {}
	public void CopyTo(Binding[] array, int index) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Binding Item { get{} set{} }
	public Binding Item { get{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}


public interface IDictionary : ICollection, IEnumerable
{

	// Methods
	public abstract virtual bool Contains(object key) {}
	public abstract virtual void Add(object key, object value) {}
	public abstract virtual void Clear() {}
	public abstract virtual IDictionaryEnumerator GetEnumerator() {}
	public abstract virtual void Remove(object key) {}

	// Properties
	public object Item { get{} set{} }
	public ICollection Keys { get{} }
	public ICollection Values { get{} }
	public bool IsReadOnly { get{} }
	public bool IsFixedSize { get{} }
}


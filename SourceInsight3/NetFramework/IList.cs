public interface IList : ICollection, IEnumerable
{

	// Methods
	public abstract virtual int Add(object value) {}
	public abstract virtual bool Contains(object value) {}
	public abstract virtual void Clear() {}
	public abstract virtual int IndexOf(object value) {}
	public abstract virtual void Insert(int index, object value) {}
	public abstract virtual void Remove(object value) {}
	public abstract virtual void RemoveAt(int index) {}

	// Properties
	public object Item { get{} set{} }
	public bool IsReadOnly { get{} }
	public bool IsFixedSize { get{} }
}


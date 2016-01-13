public class StateBag : IStateManager, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public StateBag() {}
	public StateBag(bool ignoreCase) {}

	// Methods
	public StateItem Add(string key, object value) {}
	public virtual void Clear() {}
	public virtual System.Collections.IDictionaryEnumerator GetEnumerator() {}
	public bool IsItemDirty(string key) {}
	public void Remove(string key) {}
	public void SetDirty(bool dirty) {}
	public void SetItemDirty(string key, bool dirty) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public System.Collections.ICollection Keys { get{} }
	public System.Collections.ICollection Values { get{} }
	public object Item { get{} set{} }
}


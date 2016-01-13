public interface ISessionStateItemCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public abstract virtual void Remove(string name) {}
	public abstract virtual void RemoveAt(int index) {}
	public abstract virtual void Clear() {}

	// Properties
	public object Item { get{} set{} }
	public object Item { get{} set{} }
	public System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get{} }
	public bool Dirty { get{} set{} }
}


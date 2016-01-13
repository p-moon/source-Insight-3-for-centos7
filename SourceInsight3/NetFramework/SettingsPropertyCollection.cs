public class SettingsPropertyCollection : System.ICloneable, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public SettingsPropertyCollection() {}

	// Methods
	public void Add(SettingsProperty property) {}
	public void Remove(string name) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual object Clone() {}
	public void SetReadOnly() {}
	public void Clear() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SettingsProperty Item { get{} }
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}


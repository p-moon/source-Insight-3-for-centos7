public class ProfileInfoCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ProfileInfoCollection() {}

	// Methods
	public void Add(ProfileInfo profileInfo) {}
	public void Remove(string name) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void SetReadOnly() {}
	public void Clear() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public void CopyTo(ProfileInfo[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ProfileInfo Item { get{} }
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}


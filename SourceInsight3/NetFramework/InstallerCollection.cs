public class InstallerCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public int Add(Installer value) {}
	public void AddRange(InstallerCollection value) {}
	public void AddRange(Installer[] value) {}
	public bool Contains(Installer value) {}
	public void CopyTo(Installer[] array, int index) {}
	public int IndexOf(Installer value) {}
	public void Insert(int index, Installer value) {}
	public void Remove(Installer value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Installer Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}


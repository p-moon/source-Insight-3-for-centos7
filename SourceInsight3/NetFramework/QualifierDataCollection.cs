public class QualifierDataCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public virtual void CopyTo(System.Array array, int index) {}
	public void CopyTo(QualifierData[] qualifierArray, int index) {}
	public QualifierDataEnumerator GetEnumerator() {}
	public virtual void Remove(string qualifierName) {}
	public virtual void Add(string qualifierName, object qualifierValue) {}
	public virtual void Add(string qualifierName, object qualifierValue, bool isAmended, bool propagatesToInstance, bool propagatesToSubclass, bool isOverridable) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
	public QualifierData Item { get{} }
}


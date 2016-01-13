public class BehaviorServiceAdornerCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public BehaviorServiceAdornerCollection(BehaviorService behaviorService) {}
	public BehaviorServiceAdornerCollection(BehaviorServiceAdornerCollection value) {}
	public BehaviorServiceAdornerCollection(Adorner[] value) {}

	// Methods
	public int Add(Adorner value) {}
	public void AddRange(Adorner[] value) {}
	public void AddRange(BehaviorServiceAdornerCollection value) {}
	public bool Contains(Adorner value) {}
	public void CopyTo(Adorner[] array, int index) {}
	public int IndexOf(Adorner value) {}
	public void Insert(int index, Adorner value) {}
	public BehaviorServiceAdornerCollectionEnumerator GetEnumerator() {}
	public void Remove(Adorner value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Adorner Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}


public class TableLayoutColumnStyleCollection : TableLayoutStyleCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public int Add(ColumnStyle columnStyle) {}
	public void Insert(int index, ColumnStyle columnStyle) {}
	public void Remove(ColumnStyle columnStyle) {}
	public bool Contains(ColumnStyle columnStyle) {}
	public int IndexOf(ColumnStyle columnStyle) {}
	public int Add(TableLayoutStyle style) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ColumnStyle Item { get{} set{} }
	public TableLayoutStyle Item { get{} set{} }
	public int Count { get{} }
}


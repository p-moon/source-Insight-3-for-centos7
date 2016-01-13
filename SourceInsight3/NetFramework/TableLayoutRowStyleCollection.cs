public class TableLayoutRowStyleCollection : TableLayoutStyleCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public int Add(RowStyle rowStyle) {}
	public void Insert(int index, RowStyle rowStyle) {}
	public void Remove(RowStyle rowStyle) {}
	public bool Contains(RowStyle rowStyle) {}
	public int IndexOf(RowStyle rowStyle) {}
	public int Add(TableLayoutStyle style) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public RowStyle Item { get{} set{} }
	public TableLayoutStyle Item { get{} set{} }
	public int Count { get{} }
}


public class GridItem
{

	// Methods
	public abstract virtual bool Select() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Tag { get{} set{} }
	public GridItemCollection GridItems { get{} }
	public GridItemType GridItemType { get{} }
	public string Label { get{} }
	public GridItem Parent { get{} }
	public System.ComponentModel.PropertyDescriptor PropertyDescriptor { get{} }
	public object Value { get{} }
	public bool Expandable { get{} }
	public bool Expanded { get{} set{} }
}


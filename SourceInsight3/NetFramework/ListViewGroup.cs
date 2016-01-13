public class ListViewGroup : System.Runtime.Serialization.ISerializable
{

	// Constructors
	public ListViewGroup() {}
	public ListViewGroup(string key, string headerText) {}
	public ListViewGroup(string header) {}
	public ListViewGroup(string header, HorizontalAlignment headerAlignment) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Header { get{} set{} }
	public HorizontalAlignment HeaderAlignment { get{} set{} }
	public ListViewItemCollection Items { get{} }
	public ListView ListView { get{} }
	public string Name { get{} set{} }
	public object Tag { get{} set{} }
}


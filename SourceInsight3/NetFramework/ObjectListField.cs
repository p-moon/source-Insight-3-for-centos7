public class ObjectListField : System.Web.UI.IStateManager
{

	// Constructors
	public ObjectListField() {}

	// Methods
	public void DataBindItem(int fieldIndex, ObjectListItem item) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} set{} }
	public string DataField { get{} set{} }
	public string DataFormatString { get{} set{} }
	public string Title { get{} set{} }
	public bool Visible { get{} set{} }
}


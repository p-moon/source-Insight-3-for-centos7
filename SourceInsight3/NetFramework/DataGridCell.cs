public class DataGridCell : System.ValueType
{

	// Constructors
	public DataGridCell(int r, int c) {}

	// Methods
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public int ColumnNumber { get{} set{} }
	public int RowNumber { get{} set{} }
}


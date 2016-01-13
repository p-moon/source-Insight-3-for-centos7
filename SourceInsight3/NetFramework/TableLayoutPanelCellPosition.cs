public class TableLayoutPanelCellPosition : System.ValueType
{

	// Constructors
	public TableLayoutPanelCellPosition(int column, int row) {}

	// Methods
	public virtual bool Equals(object other) {}
	public static bool op_Equality(TableLayoutPanelCellPosition p1, TableLayoutPanelCellPosition p2) {}
	public static bool op_Inequality(TableLayoutPanelCellPosition p1, TableLayoutPanelCellPosition p2) {}
	public virtual string ToString() {}
	public virtual int GetHashCode() {}
	public Type GetType() {}

	// Properties
	public int Row { get{} set{} }
	public int Column { get{} set{} }
}


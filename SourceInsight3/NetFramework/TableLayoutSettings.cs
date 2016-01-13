public class TableLayoutSettings : LayoutSettings, System.Runtime.Serialization.ISerializable
{

	// Methods
	public int GetColumnSpan(object control) {}
	public void SetColumnSpan(object control, int value) {}
	public int GetRowSpan(object control) {}
	public void SetRowSpan(object control, int value) {}
	public int GetRow(object control) {}
	public void SetRow(object control, int row) {}
	public TableLayoutPanelCellPosition GetCellPosition(object control) {}
	public void SetCellPosition(object control, TableLayoutPanelCellPosition cellPosition) {}
	public int GetColumn(object control) {}
	public void SetColumn(object control, int column) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Windows.Forms.Layout.LayoutEngine LayoutEngine { get{} }
	public int ColumnCount { get{} set{} }
	public int RowCount { get{} set{} }
	public TableLayoutRowStyleCollection RowStyles { get{} }
	public TableLayoutColumnStyleCollection ColumnStyles { get{} }
	public TableLayoutPanelGrowStyle GrowStyle { get{} set{} }
}


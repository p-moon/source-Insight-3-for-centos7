public class DataGridTableStyle : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable, IDataGridEditingService
{

	// Constructors
	public DataGridTableStyle(bool isDefaultTableStyle) {}
	public DataGridTableStyle() {}
	public DataGridTableStyle(CurrencyManager listManager) {}

	// Methods
	public void ResetAlternatingBackColor() {}
	public void ResetBackColor() {}
	public void ResetForeColor() {}
	public void ResetGridLineColor() {}
	public void ResetHeaderBackColor() {}
	public void ResetHeaderFont() {}
	public void ResetHeaderForeColor() {}
	public void ResetLinkColor() {}
	public void ResetLinkHoverColor() {}
	public void ResetSelectionBackColor() {}
	public void ResetSelectionForeColor() {}
	public virtual bool BeginEdit(DataGridColumnStyle gridColumn, int rowNumber) {}
	public virtual bool EndEdit(DataGridColumnStyle gridColumn, int rowNumber, bool shouldAbort) {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public DataGridTableStyle DefaultTableStyle;

	// Properties
	public bool AllowSorting { get{} set{} }
	public System.Drawing.Color AlternatingBackColor { get{} set{} }
	public System.Drawing.Color BackColor { get{} set{} }
	public System.Drawing.Color ForeColor { get{} set{} }
	public System.Drawing.Color GridLineColor { get{} set{} }
	public DataGridLineStyle GridLineStyle { get{} set{} }
	public System.Drawing.Color HeaderBackColor { get{} set{} }
	public System.Drawing.Font HeaderFont { get{} set{} }
	public System.Drawing.Color HeaderForeColor { get{} set{} }
	public System.Drawing.Color LinkColor { get{} set{} }
	public System.Drawing.Color LinkHoverColor { get{} set{} }
	public int PreferredColumnWidth { get{} set{} }
	public int PreferredRowHeight { get{} set{} }
	public bool ColumnHeadersVisible { get{} set{} }
	public bool RowHeadersVisible { get{} set{} }
	public int RowHeaderWidth { get{} set{} }
	public System.Drawing.Color SelectionBackColor { get{} set{} }
	public System.Drawing.Color SelectionForeColor { get{} set{} }
	public string MappingName { get{} set{} }
	public GridColumnStylesCollection GridColumnStyles { get{} }
	public DataGrid DataGrid { get{} set{} }
	public bool ReadOnly { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler AllowSortingChanged;
	public event System.EventHandler AlternatingBackColorChanged;
	public event System.EventHandler BackColorChanged;
	public event System.EventHandler ForeColorChanged;
	public event System.EventHandler GridLineColorChanged;
	public event System.EventHandler GridLineStyleChanged;
	public event System.EventHandler HeaderBackColorChanged;
	public event System.EventHandler HeaderFontChanged;
	public event System.EventHandler HeaderForeColorChanged;
	public event System.EventHandler LinkColorChanged;
	public event System.EventHandler LinkHoverColorChanged;
	public event System.EventHandler PreferredColumnWidthChanged;
	public event System.EventHandler PreferredRowHeightChanged;
	public event System.EventHandler ColumnHeadersVisibleChanged;
	public event System.EventHandler RowHeadersVisibleChanged;
	public event System.EventHandler RowHeaderWidthChanged;
	public event System.EventHandler SelectionBackColorChanged;
	public event System.EventHandler SelectionForeColorChanged;
	public event System.EventHandler MappingNameChanged;
	public event System.EventHandler ReadOnlyChanged;
	public event System.EventHandler Disposed;
}


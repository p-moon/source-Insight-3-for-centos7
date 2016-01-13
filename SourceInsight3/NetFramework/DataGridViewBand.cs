public class DataGridViewBand : DataGridViewElement, System.ICloneable, System.IDisposable
{

	// Methods
	public virtual object Clone() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ContextMenuStrip ContextMenuStrip { get{} set{} }
	public DataGridViewCellStyle DefaultCellStyle { get{} set{} }
	public Type DefaultHeaderCellType { get{} set{} }
	public bool Displayed { get{} }
	public bool Frozen { get{} set{} }
	public bool HasDefaultCellStyle { get{} }
	public int Index { get{} }
	public DataGridViewCellStyle InheritedStyle { get{} }
	public bool ReadOnly { get{} set{} }
	public DataGridViewTriState Resizable { get{} set{} }
	public bool Selected { get{} set{} }
	public object Tag { get{} set{} }
	public bool Visible { get{} set{} }
	public DataGridViewElementStates State { get{} }
	public DataGridView DataGridView { get{} }
}


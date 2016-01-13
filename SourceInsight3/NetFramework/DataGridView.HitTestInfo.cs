public class HitTestInfo
{

	// Methods
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public HitTestInfo Nowhere;

	// Properties
	public int ColumnIndex { get{} }
	public int RowIndex { get{} }
	public int ColumnX { get{} }
	public int RowY { get{} }
	public DataGridViewHitTestType Type { get{} }
}


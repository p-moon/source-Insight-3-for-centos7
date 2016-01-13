public class DataGridViewCellStyle : System.ICloneable
{

	// Constructors
	public DataGridViewCellStyle() {}
	public DataGridViewCellStyle(DataGridViewCellStyle dataGridViewCellStyle) {}

	// Methods
	public virtual void ApplyStyle(DataGridViewCellStyle dataGridViewCellStyle) {}
	public virtual DataGridViewCellStyle Clone() {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public DataGridViewContentAlignment Alignment { get{} set{} }
	public System.Drawing.Color BackColor { get{} set{} }
	public object DataSourceNullValue { get{} set{} }
	public System.Drawing.Font Font { get{} set{} }
	public System.Drawing.Color ForeColor { get{} set{} }
	public string Format { get{} set{} }
	public System.IFormatProvider FormatProvider { get{} set{} }
	public bool IsDataSourceNullValueDefault { get{} }
	public bool IsFormatProviderDefault { get{} }
	public bool IsNullValueDefault { get{} }
	public object NullValue { get{} set{} }
	public Padding Padding { get{} set{} }
	public System.Drawing.Color SelectionBackColor { get{} set{} }
	public System.Drawing.Color SelectionForeColor { get{} set{} }
	public object Tag { get{} set{} }
	public DataGridViewTriState WrapMode { get{} set{} }
}


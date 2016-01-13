public class DesignerDataColumn
{

	// Constructors
	public DesignerDataColumn(string name, System.Data.DbType dataType) {}
	public DesignerDataColumn(string name, System.Data.DbType dataType, object defaultValue) {}
	public DesignerDataColumn(string name, System.Data.DbType dataType, object defaultValue, bool identity, bool nullable, bool primaryKey, int precision, int scale, int length) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Data.DbType DataType { get{} }
	public object DefaultValue { get{} }
	public bool Identity { get{} }
	public int Length { get{} }
	public string Name { get{} }
	public bool Nullable { get{} }
	public int Precision { get{} }
	public bool PrimaryKey { get{} }
	public int Scale { get{} }
}


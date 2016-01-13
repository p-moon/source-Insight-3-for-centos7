public class DesignerDataParameter
{

	// Constructors
	public DesignerDataParameter(string name, System.Data.DbType dataType, System.Data.ParameterDirection direction) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Data.DbType DataType { get{} }
	public System.Data.ParameterDirection Direction { get{} }
	public string Name { get{} }
}


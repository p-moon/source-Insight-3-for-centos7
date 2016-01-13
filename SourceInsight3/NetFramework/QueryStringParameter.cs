public class QueryStringParameter : Parameter, System.ICloneable, System.Web.UI.IStateManager
{

	// Constructors
	public QueryStringParameter() {}
	public QueryStringParameter(string name, string queryStringField) {}
	public QueryStringParameter(string name, System.TypeCode type, string queryStringField) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string QueryStringField { get{} set{} }
	public string DefaultValue { get{} set{} }
	public System.Data.ParameterDirection Direction { get{} set{} }
	public string Name { get{} set{} }
	public int Size { get{} set{} }
	public System.TypeCode Type { get{} set{} }
	public bool ConvertEmptyStringToNull { get{} set{} }
}


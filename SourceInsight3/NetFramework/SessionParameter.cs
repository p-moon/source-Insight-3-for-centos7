public class SessionParameter : Parameter, System.ICloneable, System.Web.UI.IStateManager
{

	// Constructors
	public SessionParameter() {}
	public SessionParameter(string name, string sessionField) {}
	public SessionParameter(string name, System.TypeCode type, string sessionField) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string SessionField { get{} set{} }
	public string DefaultValue { get{} set{} }
	public System.Data.ParameterDirection Direction { get{} set{} }
	public string Name { get{} set{} }
	public int Size { get{} set{} }
	public System.TypeCode Type { get{} set{} }
	public bool ConvertEmptyStringToNull { get{} set{} }
}


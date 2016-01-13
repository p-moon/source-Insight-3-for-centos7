public class ControlParameter : Parameter, System.ICloneable, System.Web.UI.IStateManager
{

	// Constructors
	public ControlParameter() {}
	public ControlParameter(string name, string controlID) {}
	public ControlParameter(string name, string controlID, string propertyName) {}
	public ControlParameter(string name, System.TypeCode type, string controlID, string propertyName) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ControlID { get{} set{} }
	public string PropertyName { get{} set{} }
	public string DefaultValue { get{} set{} }
	public System.Data.ParameterDirection Direction { get{} set{} }
	public string Name { get{} set{} }
	public int Size { get{} set{} }
	public System.TypeCode Type { get{} set{} }
	public bool ConvertEmptyStringToNull { get{} set{} }
}


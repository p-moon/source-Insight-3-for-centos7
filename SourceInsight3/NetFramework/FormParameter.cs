public class FormParameter : Parameter, System.ICloneable, System.Web.UI.IStateManager
{

	// Constructors
	public FormParameter() {}
	public FormParameter(string name, string formField) {}
	public FormParameter(string name, System.TypeCode type, string formField) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string FormField { get{} set{} }
	public string DefaultValue { get{} set{} }
	public System.Data.ParameterDirection Direction { get{} set{} }
	public string Name { get{} set{} }
	public int Size { get{} set{} }
	public System.TypeCode Type { get{} set{} }
	public bool ConvertEmptyStringToNull { get{} set{} }
}


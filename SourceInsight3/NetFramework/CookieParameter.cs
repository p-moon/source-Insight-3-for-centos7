public class CookieParameter : Parameter, System.ICloneable, System.Web.UI.IStateManager
{

	// Constructors
	public CookieParameter() {}
	public CookieParameter(string name, string cookieName) {}
	public CookieParameter(string name, System.TypeCode type, string cookieName) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string CookieName { get{} set{} }
	public string DefaultValue { get{} set{} }
	public System.Data.ParameterDirection Direction { get{} set{} }
	public string Name { get{} set{} }
	public int Size { get{} set{} }
	public System.TypeCode Type { get{} set{} }
	public bool ConvertEmptyStringToNull { get{} set{} }
}


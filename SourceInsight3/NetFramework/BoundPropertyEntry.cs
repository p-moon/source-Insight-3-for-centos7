public class BoundPropertyEntry : PropertyEntry
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ControlID { get{} set{} }
	public Type ControlType { get{} set{} }
	public string Expression { get{} set{} }
	public System.Web.Compilation.ExpressionBuilder ExpressionBuilder { get{} set{} }
	public string ExpressionPrefix { get{} set{} }
	public string FieldName { get{} set{} }
	public string FormatString { get{} set{} }
	public bool Generated { get{} set{} }
	public object ParsedExpressionData { get{} set{} }
	public bool ReadOnlyProperty { get{} set{} }
	public bool TwoWayBound { get{} set{} }
	public bool UseSetAttribute { get{} set{} }
	public string Filter { get{} set{} }
	public System.Reflection.PropertyInfo PropertyInfo { get{} set{} }
	public string Name { get{} set{} }
	public Type Type { get{} set{} }
	public Type DeclaringType { get{} }
}


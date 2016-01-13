public class ObjectDataSourceStatusEventArgs : System.EventArgs
{

	// Constructors
	public ObjectDataSourceStatusEventArgs(object returnValue, System.Collections.IDictionary outputParameters) {}
	public ObjectDataSourceStatusEventArgs(object returnValue, System.Collections.IDictionary outputParameters, System.Exception exception) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.IDictionary OutputParameters { get{} }
	public System.Exception Exception { get{} }
	public bool ExceptionHandled { get{} set{} }
	public object ReturnValue { get{} }
	public int AffectedRows { get{} set{} }
}


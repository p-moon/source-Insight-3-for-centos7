public class SelectQuery : WqlObjectQuery, System.ICloneable
{

	// Constructors
	public SelectQuery() {}
	public SelectQuery(string queryOrClassName) {}
	public SelectQuery(string className, string condition) {}
	public SelectQuery(string className, string condition, string[] selectedProperties) {}
	public SelectQuery(bool isSchemaQuery, string condition) {}

	// Methods
	public virtual object Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string QueryString { get{} set{} }
	public bool IsSchemaQuery { get{} set{} }
	public string ClassName { get{} set{} }
	public string Condition { get{} set{} }
	public System.Collections.Specialized.StringCollection SelectedProperties { get{} set{} }
	public string QueryLanguage { get{} }
}


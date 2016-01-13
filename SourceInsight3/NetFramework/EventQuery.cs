public class EventQuery : ManagementQuery, System.ICloneable
{

	// Constructors
	public EventQuery() {}
	public EventQuery(string query) {}
	public EventQuery(string language, string query) {}

	// Methods
	public virtual object Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string QueryString { get{} set{} }
	public string QueryLanguage { get{} set{} }
}


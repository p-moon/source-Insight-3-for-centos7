public class WqlObjectQuery : ObjectQuery, System.ICloneable
{

	// Constructors
	public WqlObjectQuery() {}
	public WqlObjectQuery(string query) {}

	// Methods
	public virtual object Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string QueryLanguage { get{} }
	public string QueryString { get{} set{} }
}


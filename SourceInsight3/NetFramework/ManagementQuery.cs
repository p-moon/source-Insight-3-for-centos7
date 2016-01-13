public class ManagementQuery : System.ICloneable
{

	// Methods
	public abstract virtual object Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string QueryString { get{} set{} }
	public string QueryLanguage { get{} set{} }
}


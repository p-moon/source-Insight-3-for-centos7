public class AdCreatedEventArgs : System.EventArgs
{

	// Constructors
	public AdCreatedEventArgs(System.Collections.IDictionary adProperties) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.IDictionary AdProperties { get{} }
	public string AlternateText { get{} set{} }
	public string ImageUrl { get{} set{} }
	public string NavigateUrl { get{} set{} }
}


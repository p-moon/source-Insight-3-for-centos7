public class UrlAttribute : System.Runtime.Remoting.Contexts.ContextAttribute, System.Runtime.InteropServices._Attribute, System.Runtime.Remoting.Contexts.IContextAttribute, System.Runtime.Remoting.Contexts.IContextProperty
{

	// Constructors
	public UrlAttribute(string callsiteURL) {}

	// Methods
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public virtual bool IsContextOK(System.Runtime.Remoting.Contexts.Context ctx, IConstructionCallMessage msg) {}
	public virtual void GetPropertiesForNewContext(IConstructionCallMessage ctorMsg) {}
	public virtual bool IsNewContextOK(System.Runtime.Remoting.Contexts.Context newCtx) {}
	public virtual void Freeze(System.Runtime.Remoting.Contexts.Context newContext) {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string UrlValue { get{} }
	public string Name { get{} }
	public object TypeId { get{} }
}


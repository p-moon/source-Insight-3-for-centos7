public class ContextAttribute : System.Attribute, System.Runtime.InteropServices._Attribute, IContextAttribute, IContextProperty
{

	// Constructors
	public ContextAttribute(string name) {}

	// Methods
	public virtual bool IsNewContextOK(Context newCtx) {}
	public virtual void Freeze(Context newContext) {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public virtual bool IsContextOK(Context ctx, System.Runtime.Remoting.Activation.IConstructionCallMessage ctorMsg) {}
	public virtual void GetPropertiesForNewContext(System.Runtime.Remoting.Activation.IConstructionCallMessage ctorMsg) {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Name { get{} }
	public object TypeId { get{} }
}


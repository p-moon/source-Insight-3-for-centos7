public class SynchronizationAttribute : ContextAttribute, System.Runtime.InteropServices._Attribute, IContextAttribute, IContextProperty, IContributeServerContextSink, IContributeClientContextSink
{

	// Constructors
	public SynchronizationAttribute() {}
	public SynchronizationAttribute(bool reEntrant) {}
	public SynchronizationAttribute(int flag) {}
	public SynchronizationAttribute(int flag, bool reEntrant) {}

	// Methods
	public virtual bool IsContextOK(Context ctx, System.Runtime.Remoting.Activation.IConstructionCallMessage msg) {}
	public virtual void GetPropertiesForNewContext(System.Runtime.Remoting.Activation.IConstructionCallMessage ctorMsg) {}
	public virtual System.Runtime.Remoting.Messaging.IMessageSink GetServerContextSink(System.Runtime.Remoting.Messaging.IMessageSink nextSink) {}
	public virtual System.Runtime.Remoting.Messaging.IMessageSink GetClientContextSink(System.Runtime.Remoting.Messaging.IMessageSink nextSink) {}
	public virtual bool IsNewContextOK(Context newCtx) {}
	public virtual void Freeze(Context newContext) {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public int NOT_SUPPORTED;
	public int SUPPORTED;
	public int REQUIRED;
	public int REQUIRES_NEW;

	// Properties
	public bool Locked { get{} set{} }
	public bool IsReEntrant { get{} }
	public string Name { get{} }
	public object TypeId { get{} }
}


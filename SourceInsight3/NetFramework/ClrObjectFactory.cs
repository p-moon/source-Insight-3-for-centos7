public class ClrObjectFactory : IClrObjectFactory
{

	// Constructors
	public ClrObjectFactory() {}

	// Methods
	public virtual object CreateFromAssembly(string AssemblyName, string TypeName, string Mode) {}
	public virtual object CreateFromVroot(string VrootUrl, string Mode) {}
	public virtual object CreateFromWsdl(string WsdlUrl, string Mode) {}
	public virtual object CreateFromMailbox(string Mailbox, string Mode) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


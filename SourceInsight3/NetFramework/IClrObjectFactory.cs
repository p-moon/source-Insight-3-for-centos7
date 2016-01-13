public interface IClrObjectFactory
{

	// Methods
	public abstract virtual object CreateFromAssembly(string assembly, string type, string mode) {}
	public abstract virtual object CreateFromVroot(string VrootUrl, string Mode) {}
	public abstract virtual object CreateFromWsdl(string WsdlUrl, string Mode) {}
	public abstract virtual object CreateFromMailbox(string Mailbox, string Mode) {}
}


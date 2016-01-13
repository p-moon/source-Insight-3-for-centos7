public class ApplicationId
{

	// Constructors
	public ApplicationId(byte[] publicKeyToken, string name, Version version, string processorArchitecture, string culture) {}

	// Methods
	public ApplicationId Copy() {}
	public virtual string ToString() {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}

	// Properties
	public byte[] PublicKeyToken { get{} }
	public string Name { get{} }
	public Version Version { get{} }
	public string ProcessorArchitecture { get{} }
	public string Culture { get{} }
}


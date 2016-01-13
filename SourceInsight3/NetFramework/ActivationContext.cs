public class ActivationContext : IDisposable, System.Runtime.Serialization.ISerializable
{

	// Methods
	public static ActivationContext CreatePartialActivationContext(ApplicationIdentity identity) {}
	public static ActivationContext CreatePartialActivationContext(ApplicationIdentity identity, string[] manifestPaths) {}
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ApplicationIdentity Identity { get{} }
	public ContextForm Form { get{} }
	public byte[] ApplicationManifestBytes { get{} }
	public byte[] DeploymentManifestBytes { get{} }
}


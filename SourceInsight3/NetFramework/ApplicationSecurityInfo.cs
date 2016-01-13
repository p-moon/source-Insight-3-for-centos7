public class ApplicationSecurityInfo
{

	// Constructors
	public ApplicationSecurityInfo(System.ActivationContext activationContext) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.ApplicationId ApplicationId { get{} set{} }
	public System.ApplicationId DeploymentId { get{} set{} }
	public System.Security.PermissionSet DefaultRequestSet { get{} set{} }
	public Evidence ApplicationEvidence { get{} set{} }
}


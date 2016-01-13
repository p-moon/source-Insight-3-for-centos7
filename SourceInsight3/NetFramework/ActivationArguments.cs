public class ActivationArguments
{

	// Constructors
	public ActivationArguments(System.ApplicationIdentity applicationIdentity) {}
	public ActivationArguments(System.ApplicationIdentity applicationIdentity, string[] activationData) {}
	public ActivationArguments(System.ActivationContext activationData) {}
	public ActivationArguments(System.ActivationContext activationContext, string[] activationData) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.ApplicationIdentity ApplicationIdentity { get{} }
	public System.ActivationContext ActivationContext { get{} }
	public string[] ActivationData { get{} }
}


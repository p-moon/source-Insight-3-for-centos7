public class DeploymentServiceCom
{

	// Constructors
	public DeploymentServiceCom() {}

	// Methods
	public void ActivateDeployment(string deploymentLocation, bool isShortcut) {}
	public void ActivateApplicationExtension(string textualSubId, string deploymentProviderUrl, string targetAssociatedFile) {}
	public void MaintainSubscription(string textualSubId) {}
	public void CheckForDeploymentUpdate(string textualSubId) {}
	public void EndServiceRightNow() {}
	public void CleanOnlineAppCache() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


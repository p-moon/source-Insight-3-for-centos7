public class GetManifestCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.ApplicationIdentity ApplicationIdentity { get{} }
	public System.Version Version { get{} }
	public bool IsCached { get{} }
	public string ProductName { get{} }
	public System.Uri SupportUri { get{} }
	public string LogFilePath { get{} }
	public System.Xml.XmlReader DeploymentManifest { get{} }
	public System.Xml.XmlReader ApplicationManifest { get{} }
	public System.ActivationContext ActivationContext { get{} }
	public string SubscriptionIdentity { get{} }
	public bool Cancelled { get{} }
	public System.Exception Error { get{} }
	public object UserState { get{} }
}


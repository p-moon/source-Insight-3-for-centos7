public class InPlaceHostingManager : System.IDisposable
{

	// Constructors
	public InPlaceHostingManager(System.Uri deploymentManifest, bool launchInHostProcess) {}
	public InPlaceHostingManager(System.Uri deploymentManifest) {}

	// Methods
	public void GetManifestAsync() {}
	public void AssertApplicationRequirements() {}
	public void DownloadApplicationAsync() {}
	public System.Runtime.Remoting.ObjectHandle Execute() {}
	public void CancelAsync() {}
	public virtual void Dispose() {}
	public static void UninstallCustomAddIn(string subscriptionId) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Events
	public event System.EventHandler`1[System.Deployment.Application.GetManifestCompletedEventArgs] GetManifestCompleted;
	public event System.EventHandler`1[System.Deployment.Application.DownloadProgressChangedEventArgs] DownloadProgressChanged;
	public event System.EventHandler`1[System.Deployment.Application.DownloadApplicationCompletedEventArgs] DownloadApplicationCompleted;
}


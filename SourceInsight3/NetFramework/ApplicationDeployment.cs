public class ApplicationDeployment
{

	// Methods
	public UpdateCheckInfo CheckForDetailedUpdate() {}
	public bool CheckForUpdate() {}
	public void CheckForUpdateAsync() {}
	public void CheckForUpdateAsyncCancel() {}
	public bool Update() {}
	public void UpdateAsync() {}
	public void UpdateAsyncCancel() {}
	public void DownloadFileGroup(string groupName) {}
	public void DownloadFileGroupAsync(string groupName) {}
	public void DownloadFileGroupAsync(string groupName, object userState) {}
	public bool IsFileGroupDownloaded(string groupName) {}
	public void DownloadFileGroupAsyncCancel(string groupName) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ApplicationDeployment CurrentDeployment { get{} }
	public bool IsNetworkDeployed { get{} }
	public System.Version CurrentVersion { get{} }
	public System.Version UpdatedVersion { get{} }
	public string UpdatedApplicationFullName { get{} }
	public System.DateTime TimeOfLastUpdateCheck { get{} }
	public System.Uri UpdateLocation { get{} }
	public System.Uri ActivationUri { get{} }
	public string DataDirectory { get{} }
	public bool IsFirstRun { get{} }

	// Events
	public event System.Deployment.Application.DeploymentProgressChangedEventHandler CheckForUpdateProgressChanged;
	public event System.Deployment.Application.CheckForUpdateCompletedEventHandler CheckForUpdateCompleted;
	public event System.Deployment.Application.DeploymentProgressChangedEventHandler UpdateProgressChanged;
	public event System.ComponentModel.AsyncCompletedEventHandler UpdateCompleted;
	public event System.Deployment.Application.DeploymentProgressChangedEventHandler DownloadFileGroupProgressChanged;
	public event System.Deployment.Application.DownloadFileGroupCompletedEventHandler DownloadFileGroupCompleted;
}


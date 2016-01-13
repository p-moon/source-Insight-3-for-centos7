public class DownloadProgressChangedEventArgs : System.ComponentModel.ProgressChangedEventArgs
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public long BytesDownloaded { get{} }
	public long TotalBytesToDownload { get{} }
	public DeploymentProgressState State { get{} }
	public int ProgressPercentage { get{} }
	public object UserState { get{} }
}


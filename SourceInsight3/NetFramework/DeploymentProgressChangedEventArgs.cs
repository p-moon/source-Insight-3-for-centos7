public class DeploymentProgressChangedEventArgs : System.ComponentModel.ProgressChangedEventArgs
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public long BytesCompleted { get{} }
	public long BytesTotal { get{} }
	public DeploymentProgressState State { get{} }
	public string Group { get{} }
	public int ProgressPercentage { get{} }
	public object UserState { get{} }
}


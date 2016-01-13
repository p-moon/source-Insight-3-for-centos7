public class UploadProgressChangedEventArgs : System.ComponentModel.ProgressChangedEventArgs
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public long BytesReceived { get{} }
	public long TotalBytesToReceive { get{} }
	public long BytesSent { get{} }
	public long TotalBytesToSend { get{} }
	public int ProgressPercentage { get{} }
	public object UserState { get{} }
}


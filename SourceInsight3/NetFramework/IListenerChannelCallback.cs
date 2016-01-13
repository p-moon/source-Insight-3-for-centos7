public interface IListenerChannelCallback
{

	// Methods
	public abstract virtual void ReportStarted() {}
	public abstract virtual void ReportStopped(int hr) {}
	public abstract virtual void ReportMessageReceived() {}
	public abstract virtual int GetId() {}
	public abstract virtual int GetBlobLength() {}
	public abstract virtual void GetBlob(out byte[] buffer, System.Int32& bufferSize) {}
}


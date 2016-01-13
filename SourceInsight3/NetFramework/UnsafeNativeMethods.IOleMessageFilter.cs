public interface IOleMessageFilter
{

	// Methods
	public abstract virtual int HandleInComingCall(int dwCallType, System.IntPtr hTaskCaller, int dwTickCount, System.IntPtr lpInterfaceInfo) {}
	public abstract virtual int RetryRejectedCall(System.IntPtr hTaskCallee, int dwTickCount, int dwRejectType) {}
	public abstract virtual int MessagePending(System.IntPtr hTaskCallee, int dwTickCount, int dwPendingType) {}
}


public class Executor
{

	// Methods
	public static void ExecWait(string cmd, TempFileCollection tempFiles) {}
	public static int ExecWaitWithCapture(string cmd, TempFileCollection tempFiles, System.String& outputName, System.String& errorName) {}
	public static int ExecWaitWithCapture(string cmd, string currentDir, TempFileCollection tempFiles, System.String& outputName, System.String& errorName) {}
	public static int ExecWaitWithCapture(System.IntPtr userToken, string cmd, TempFileCollection tempFiles, System.String& outputName, System.String& errorName) {}
	public static int ExecWaitWithCapture(System.IntPtr userToken, string cmd, string currentDir, TempFileCollection tempFiles, System.String& outputName, System.String& errorName) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


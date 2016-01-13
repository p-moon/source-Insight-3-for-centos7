public class Process : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public Process() {}

	// Methods
	public bool CloseMainWindow() {}
	public void Close() {}
	public static void EnterDebugMode() {}
	public static void LeaveDebugMode() {}
	public static Process GetProcessById(int processId, string machineName) {}
	public static Process GetProcessById(int processId) {}
	public static Process[] GetProcessesByName(string processName) {}
	public static Process[] GetProcessesByName(string processName, string machineName) {}
	public static Process[] GetProcesses() {}
	public static Process[] GetProcesses(string machineName) {}
	public static Process GetCurrentProcess() {}
	public void Refresh() {}
	public bool Start() {}
	public static Process Start(string fileName, string userName, System.Security.SecureString password, string domain) {}
	public static Process Start(string fileName, string arguments, string userName, System.Security.SecureString password, string domain) {}
	public static Process Start(string fileName) {}
	public static Process Start(string fileName, string arguments) {}
	public static Process Start(ProcessStartInfo startInfo) {}
	public void Kill() {}
	public virtual string ToString() {}
	public bool WaitForExit(int milliseconds) {}
	public void WaitForExit() {}
	public bool WaitForInputIdle(int milliseconds) {}
	public bool WaitForInputIdle() {}
	public void BeginOutputReadLine() {}
	public void BeginErrorReadLine() {}
	public void CancelOutputRead() {}
	public void CancelErrorRead() {}
	public virtual void Dispose() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int BasePriority { get{} }
	public int ExitCode { get{} }
	public bool HasExited { get{} }
	public System.DateTime ExitTime { get{} }
	public System.IntPtr Handle { get{} }
	public int HandleCount { get{} }
	public int Id { get{} }
	public string MachineName { get{} }
	public System.IntPtr MainWindowHandle { get{} }
	public string MainWindowTitle { get{} }
	public ProcessModule MainModule { get{} }
	public System.IntPtr MaxWorkingSet { get{} set{} }
	public System.IntPtr MinWorkingSet { get{} set{} }
	public ProcessModuleCollection Modules { get{} }
	public int NonpagedSystemMemorySize { get{} }
	public long NonpagedSystemMemorySize64 { get{} }
	public int PagedMemorySize { get{} }
	public long PagedMemorySize64 { get{} }
	public int PagedSystemMemorySize { get{} }
	public long PagedSystemMemorySize64 { get{} }
	public int PeakPagedMemorySize { get{} }
	public long PeakPagedMemorySize64 { get{} }
	public int PeakWorkingSet { get{} }
	public long PeakWorkingSet64 { get{} }
	public int PeakVirtualMemorySize { get{} }
	public long PeakVirtualMemorySize64 { get{} }
	public bool PriorityBoostEnabled { get{} set{} }
	public ProcessPriorityClass PriorityClass { get{} set{} }
	public int PrivateMemorySize { get{} }
	public long PrivateMemorySize64 { get{} }
	public System.TimeSpan PrivilegedProcessorTime { get{} }
	public string ProcessName { get{} }
	public System.IntPtr ProcessorAffinity { get{} set{} }
	public bool Responding { get{} }
	public int SessionId { get{} }
	public ProcessStartInfo StartInfo { get{} set{} }
	public System.DateTime StartTime { get{} }
	public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get{} set{} }
	public ProcessThreadCollection Threads { get{} }
	public System.TimeSpan TotalProcessorTime { get{} }
	public System.TimeSpan UserProcessorTime { get{} }
	public int VirtualMemorySize { get{} }
	public long VirtualMemorySize64 { get{} }
	public bool EnableRaisingEvents { get{} set{} }
	public System.IO.StreamWriter StandardInput { get{} }
	public System.IO.StreamReader StandardOutput { get{} }
	public System.IO.StreamReader StandardError { get{} }
	public int WorkingSet { get{} }
	public long WorkingSet64 { get{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.Diagnostics.DataReceivedEventHandler OutputDataReceived;
	public event System.Diagnostics.DataReceivedEventHandler ErrorDataReceived;
	public event System.EventHandler Exited;
	public event System.EventHandler Disposed;
}


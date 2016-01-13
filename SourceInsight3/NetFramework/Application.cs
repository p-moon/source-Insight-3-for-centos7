public class Application
{

	// Methods
	public static void DoEvents() {}
	public static void EnableVisualStyles() {}
	public static void Run(Form mainForm) {}
	public static void SetCompatibleTextRenderingDefault(bool defaultValue) {}
	public static void RegisterMessageLoop(MessageLoopCallback callback) {}
	public static void UnregisterMessageLoop() {}
	public static void AddMessageFilter(IMessageFilter value) {}
	public static bool FilterMessage(Message& message) {}
	public static void Exit() {}
	public static void Exit(System.ComponentModel.CancelEventArgs e) {}
	public static void ExitThread() {}
	public static System.Threading.ApartmentState OleRequired() {}
	public static void OnThreadException(System.Exception t) {}
	public static void RaiseIdle(System.EventArgs e) {}
	public static void RemoveMessageFilter(IMessageFilter value) {}
	public static void Restart() {}
	public static void Run() {}
	public static void Run(ApplicationContext context) {}
	public static bool SetSuspendState(PowerState state, bool force, bool disableWakeEvent) {}
	public static void SetUnhandledExceptionMode(UnhandledExceptionMode mode) {}
	public static void SetUnhandledExceptionMode(UnhandledExceptionMode mode, bool threadScope) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool AllowQuit { get{} }
	public Microsoft.Win32.RegistryKey CommonAppDataRegistry { get{} }
	public string CommonAppDataPath { get{} }
	public string CompanyName { get{} }
	public System.Globalization.CultureInfo CurrentCulture { get{} set{} }
	public InputLanguage CurrentInputLanguage { get{} set{} }
	public string ExecutablePath { get{} }
	public string LocalUserAppDataPath { get{} }
	public bool MessageLoop { get{} }
	public FormCollection OpenForms { get{} }
	public string ProductName { get{} }
	public string ProductVersion { get{} }
	public bool RenderWithVisualStyles { get{} }
	public string SafeTopLevelCaptionFormat { get{} set{} }
	public string StartupPath { get{} }
	public bool UseWaitCursor { get{} set{} }
	public string UserAppDataPath { get{} }
	public Microsoft.Win32.RegistryKey UserAppDataRegistry { get{} }
	public System.Windows.Forms.VisualStyles.VisualStyleState VisualStyleState { get{} set{} }

	// Events
	public event System.EventHandler ApplicationExit;
	public event System.EventHandler Idle;
	public event System.EventHandler EnterThreadModal;
	public event System.EventHandler LeaveThreadModal;
	public event System.Threading.ThreadExceptionEventHandler ThreadException;
	public event System.EventHandler ThreadExit;
}


public class WindowsFormsApplicationBase : ConsoleApplicationBase
{

	// Constructors
	public WindowsFormsApplicationBase() {}
	public WindowsFormsApplicationBase(AuthenticationMode authenticationMode) {}

	// Methods
	public void Run(string[] commandLine) {}
	public void DoEvents() {}
	public string GetEnvironmentVariable(string name) {}
	public void ChangeCulture(string cultureName) {}
	public void ChangeUICulture(string cultureName) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Windows.Forms.FormCollection OpenForms { get{} }
	public System.Windows.Forms.Form SplashScreen { get{} set{} }
	public int MinimumSplashScreenDisplayTime { get{} set{} }
	public System.Windows.Forms.ApplicationContext ApplicationContext { get{} }
	public bool SaveMySettingsOnExit { get{} set{} }
	public ReadOnlyCollection<string> CommandLineArgs { get{} }
	public System.Deployment.Application.ApplicationDeployment Deployment { get{} }
	public bool IsNetworkDeployed { get{} }
	public Microsoft.VisualBasic.Logging.Log Log { get{} }
	public AssemblyInfo Info { get{} }
	public System.Globalization.CultureInfo Culture { get{} }
	public System.Globalization.CultureInfo UICulture { get{} }

	// Events
	public event Microsoft.VisualBasic.ApplicationServices.StartupEventHandler Startup;
	public event Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventHandler StartupNextInstance;
	public event Microsoft.VisualBasic.ApplicationServices.ShutdownEventHandler Shutdown;
	public event Microsoft.VisualBasic.Devices.NetworkAvailableEventHandler NetworkAvailabilityChanged;
	public event Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventHandler UnhandledException;
}


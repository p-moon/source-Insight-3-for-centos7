public class ConsoleApplicationBase : ApplicationBase
{

	// Constructors
	public ConsoleApplicationBase() {}

	// Methods
	public string GetEnvironmentVariable(string name) {}
	public void ChangeCulture(string cultureName) {}
	public void ChangeUICulture(string cultureName) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ReadOnlyCollection<string> CommandLineArgs { get{} }
	public System.Deployment.Application.ApplicationDeployment Deployment { get{} }
	public bool IsNetworkDeployed { get{} }
	public Microsoft.VisualBasic.Logging.Log Log { get{} }
	public AssemblyInfo Info { get{} }
	public System.Globalization.CultureInfo Culture { get{} }
	public System.Globalization.CultureInfo UICulture { get{} }
}


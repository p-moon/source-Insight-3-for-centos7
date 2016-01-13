public class RunInstallerAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public RunInstallerAttribute(bool runInstaller) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public RunInstallerAttribute Yes;
	public RunInstallerAttribute No;
	public RunInstallerAttribute Default;

	// Properties
	public bool RunInstaller { get{} }
	public object TypeId { get{} }
}


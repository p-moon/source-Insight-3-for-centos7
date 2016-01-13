public class RegistrationClassContext : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, System.IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(System.IFormatProvider provider) {}
	public virtual System.TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public RegistrationClassContext InProcessServer;
	public RegistrationClassContext InProcessHandler;
	public RegistrationClassContext LocalServer;
	public RegistrationClassContext InProcessServer16;
	public RegistrationClassContext RemoteServer;
	public RegistrationClassContext InProcessHandler16;
	public RegistrationClassContext Reserved1;
	public RegistrationClassContext Reserved2;
	public RegistrationClassContext Reserved3;
	public RegistrationClassContext Reserved4;
	public RegistrationClassContext NoCodeDownload;
	public RegistrationClassContext Reserved5;
	public RegistrationClassContext NoCustomMarshal;
	public RegistrationClassContext EnableCodeDownload;
	public RegistrationClassContext NoFailureLog;
	public RegistrationClassContext DisableActivateAsActivator;
	public RegistrationClassContext EnableActivateAsActivator;
	public RegistrationClassContext FromDefaultContext;
}


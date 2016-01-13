public class RemotingConfiguration
{

	// Methods
	public static void Configure(string filename) {}
	public static void Configure(string filename, bool ensureSecurity) {}
	public static bool CustomErrorsEnabled(bool isLocalRequest) {}
	public static void RegisterActivatedServiceType(Type type) {}
	public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry) {}
	public static void RegisterWellKnownServiceType(Type type, string objectUri, WellKnownObjectMode mode) {}
	public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry) {}
	public static void RegisterActivatedClientType(Type type, string appUrl) {}
	public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry) {}
	public static void RegisterWellKnownClientType(Type type, string objectUrl) {}
	public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry) {}
	public static ActivatedServiceTypeEntry[] GetRegisteredActivatedServiceTypes() {}
	public static WellKnownServiceTypeEntry[] GetRegisteredWellKnownServiceTypes() {}
	public static ActivatedClientTypeEntry[] GetRegisteredActivatedClientTypes() {}
	public static WellKnownClientTypeEntry[] GetRegisteredWellKnownClientTypes() {}
	public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType) {}
	public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(string typeName, string assemblyName) {}
	public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType) {}
	public static WellKnownClientTypeEntry IsWellKnownClientType(string typeName, string assemblyName) {}
	public static bool IsActivationAllowed(Type svrType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ApplicationName { get{} set{} }
	public string ApplicationId { get{} }
	public string ProcessId { get{} }
	public CustomErrorsModes CustomErrorsMode { get{} set{} }
}


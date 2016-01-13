public class Activator : System.Runtime.InteropServices._Activator
{

	// Methods
	public static T CreateInstance<T>() {}
	public static object CreateInstance(Type type, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) {}
	public static object CreateInstance(Type type, bool nonPublic) {}
	public static System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName) {}
	public static System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes) {}
	public static System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityInfo) {}
	public static System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityInfo) {}
	public static System.Runtime.Remoting.ObjectHandle CreateInstance(AppDomain domain, string assemblyName, string typeName) {}
	public static System.Runtime.Remoting.ObjectHandle CreateInstance(AppDomain domain, string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) {}
	public static System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(AppDomain domain, string assemblyFile, string typeName) {}
	public static System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(AppDomain domain, string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) {}
	public static System.Runtime.Remoting.ObjectHandle CreateInstance(ActivationContext activationContext) {}
	public static System.Runtime.Remoting.ObjectHandle CreateInstance(ActivationContext activationContext, string[] activationCustomData) {}
	public static System.Runtime.Remoting.ObjectHandle CreateComInstanceFrom(string assemblyName, string typeName) {}
	public static System.Runtime.Remoting.ObjectHandle CreateComInstanceFrom(string assemblyName, string typeName, byte[] hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm) {}
	public static object GetObject(Type type, string url) {}
	public static object GetObject(Type type, string url, object state) {}
	public static object CreateInstance(Type type, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture) {}
	public static object CreateInstance(Type type, object[] args) {}
	public static object CreateInstance(Type type, object[] args, object[] activationAttributes) {}
	public static object CreateInstance(Type type) {}
	public static System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName) {}
	public static System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, object[] activationAttributes) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


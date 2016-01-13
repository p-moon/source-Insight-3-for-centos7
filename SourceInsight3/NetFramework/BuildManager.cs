public class BuildManager
{

	// Methods
	public static Type GetType(string typeName, bool throwOnError, bool ignoreCase) {}
	public static System.Collections.ICollection GetReferencedAssemblies() {}
	public static Type GetType(string typeName, bool throwOnError) {}
	public static System.Collections.ICollection GetVirtualPathDependencies(string virtualPath) {}
	public static Type GetCompiledType(string virtualPath) {}
	public static object CreateInstanceFromVirtualPath(string virtualPath, Type requiredBaseType) {}
	public static System.Reflection.Assembly GetCompiledAssembly(string virtualPath) {}
	public static string GetCompiledCustomString(string virtualPath) {}
	public static BuildDependencySet GetCachedBuildDependencySet(System.Web.HttpContext context, string virtualPath) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.IList CodeAssemblies { get{} }
}


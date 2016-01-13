public class VirtualPathUtility
{

	// Methods
	public static bool IsAbsolute(string virtualPath) {}
	public static bool IsAppRelative(string virtualPath) {}
	public static string ToAppRelative(string virtualPath) {}
	public static string ToAppRelative(string virtualPath, string applicationPath) {}
	public static string ToAbsolute(string virtualPath) {}
	public static string ToAbsolute(string virtualPath, string applicationPath) {}
	public static string GetFileName(string virtualPath) {}
	public static string GetDirectory(string virtualPath) {}
	public static string GetExtension(string virtualPath) {}
	public static string AppendTrailingSlash(string virtualPath) {}
	public static string RemoveTrailingSlash(string virtualPath) {}
	public static string Combine(string basePath, string relativePath) {}
	public static string MakeRelative(string fromPath, string toPath) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


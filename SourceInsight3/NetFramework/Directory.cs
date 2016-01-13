public class Directory
{

	// Methods
	public static DirectoryInfo CreateDirectory(string path, System.Security.AccessControl.DirectorySecurity directorySecurity) {}
	public static bool Exists(string path) {}
	public static string GetCurrentDirectory() {}
	public static DirectoryInfo GetParent(string path) {}
	public static DirectoryInfo CreateDirectory(string path) {}
	public static void SetCreationTime(string path, System.DateTime creationTime) {}
	public static void SetCreationTimeUtc(string path, System.DateTime creationTimeUtc) {}
	public static System.DateTime GetCreationTime(string path) {}
	public static System.DateTime GetCreationTimeUtc(string path) {}
	public static void SetLastWriteTime(string path, System.DateTime lastWriteTime) {}
	public static void SetLastWriteTimeUtc(string path, System.DateTime lastWriteTimeUtc) {}
	public static System.DateTime GetLastWriteTime(string path) {}
	public static System.DateTime GetLastWriteTimeUtc(string path) {}
	public static void SetLastAccessTime(string path, System.DateTime lastAccessTime) {}
	public static void SetLastAccessTimeUtc(string path, System.DateTime lastAccessTimeUtc) {}
	public static System.DateTime GetLastAccessTime(string path) {}
	public static System.DateTime GetLastAccessTimeUtc(string path) {}
	public static System.Security.AccessControl.DirectorySecurity GetAccessControl(string path) {}
	public static System.Security.AccessControl.DirectorySecurity GetAccessControl(string path, System.Security.AccessControl.AccessControlSections includeSections) {}
	public static void SetAccessControl(string path, System.Security.AccessControl.DirectorySecurity directorySecurity) {}
	public static string[] GetFiles(string path) {}
	public static string[] GetFiles(string path, string searchPattern) {}
	public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption) {}
	public static string[] GetDirectories(string path) {}
	public static string[] GetDirectories(string path, string searchPattern) {}
	public static string[] GetDirectories(string path, string searchPattern, SearchOption searchOption) {}
	public static string[] GetFileSystemEntries(string path) {}
	public static string[] GetFileSystemEntries(string path, string searchPattern) {}
	public static string[] GetLogicalDrives() {}
	public static string GetDirectoryRoot(string path) {}
	public static void SetCurrentDirectory(string path) {}
	public static void Move(string sourceDirName, string destDirName) {}
	public static void Delete(string path) {}
	public static void Delete(string path, bool recursive) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


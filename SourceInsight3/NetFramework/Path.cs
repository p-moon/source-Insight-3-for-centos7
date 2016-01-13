public class Path
{

	// Methods
	public static string GetFullPath(string path) {}
	public static string GetTempPath() {}
	public static string GetTempFileName() {}
	public static string ChangeExtension(string path, string extension) {}
	public static string GetDirectoryName(string path) {}
	public static char[] GetInvalidPathChars() {}
	public static char[] GetInvalidFileNameChars() {}
	public static string GetExtension(string path) {}
	public static string GetFileName(string path) {}
	public static string GetFileNameWithoutExtension(string path) {}
	public static string GetPathRoot(string path) {}
	public static string GetRandomFileName() {}
	public static bool HasExtension(string path) {}
	public static bool IsPathRooted(string path) {}
	public static string Combine(string path1, string path2) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public char DirectorySeparatorChar;
	public char AltDirectorySeparatorChar;
	public char VolumeSeparatorChar;
	public char[] InvalidPathChars;
	public char PathSeparator;
}


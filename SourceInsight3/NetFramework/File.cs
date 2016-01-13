public class File
{

	// Methods
	public static void Delete(string path) {}
	public static bool Exists(string path) {}
	public static System.DateTime GetLastWriteTimeUtc(string path) {}
	public static StreamReader OpenText(string path) {}
	public static StreamWriter CreateText(string path) {}
	public static StreamWriter AppendText(string path) {}
	public static void Copy(string sourceFileName, string destFileName) {}
	public static void Copy(string sourceFileName, string destFileName, bool overwrite) {}
	public static FileStream Create(string path) {}
	public static FileStream Create(string path, int bufferSize) {}
	public static FileStream Create(string path, int bufferSize, FileOptions options) {}
	public static FileStream Create(string path, int bufferSize, FileOptions options, System.Security.AccessControl.FileSecurity fileSecurity) {}
	public static void Decrypt(string path) {}
	public static void Encrypt(string path) {}
	public static FileStream Open(string path, FileMode mode) {}
	public static FileStream Open(string path, FileMode mode, FileAccess access) {}
	public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share) {}
	public static void SetCreationTime(string path, System.DateTime creationTime) {}
	public static void SetCreationTimeUtc(string path, System.DateTime creationTimeUtc) {}
	public static System.DateTime GetCreationTime(string path) {}
	public static System.DateTime GetCreationTimeUtc(string path) {}
	public static void SetLastAccessTime(string path, System.DateTime lastAccessTime) {}
	public static void SetLastAccessTimeUtc(string path, System.DateTime lastAccessTimeUtc) {}
	public static System.DateTime GetLastAccessTime(string path) {}
	public static System.DateTime GetLastAccessTimeUtc(string path) {}
	public static void SetLastWriteTime(string path, System.DateTime lastWriteTime) {}
	public static void SetLastWriteTimeUtc(string path, System.DateTime lastWriteTimeUtc) {}
	public static System.DateTime GetLastWriteTime(string path) {}
	public static FileAttributes GetAttributes(string path) {}
	public static void SetAttributes(string path, FileAttributes fileAttributes) {}
	public static System.Security.AccessControl.FileSecurity GetAccessControl(string path) {}
	public static System.Security.AccessControl.FileSecurity GetAccessControl(string path, System.Security.AccessControl.AccessControlSections includeSections) {}
	public static void SetAccessControl(string path, System.Security.AccessControl.FileSecurity fileSecurity) {}
	public static FileStream OpenRead(string path) {}
	public static FileStream OpenWrite(string path) {}
	public static string ReadAllText(string path) {}
	public static string ReadAllText(string path, System.Text.Encoding encoding) {}
	public static void WriteAllText(string path, string contents) {}
	public static void WriteAllText(string path, string contents, System.Text.Encoding encoding) {}
	public static byte[] ReadAllBytes(string path) {}
	public static void WriteAllBytes(string path, byte[] bytes) {}
	public static string[] ReadAllLines(string path) {}
	public static string[] ReadAllLines(string path, System.Text.Encoding encoding) {}
	public static void WriteAllLines(string path, string[] contents) {}
	public static void WriteAllLines(string path, string[] contents, System.Text.Encoding encoding) {}
	public static void AppendAllText(string path, string contents) {}
	public static void AppendAllText(string path, string contents, System.Text.Encoding encoding) {}
	public static void Move(string sourceFileName, string destFileName) {}
	public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName) {}
	public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


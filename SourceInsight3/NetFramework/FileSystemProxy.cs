public class FileSystemProxy
{

	// Methods
	public bool DirectoryExists(string directory) {}
	public bool FileExists(string file) {}
	public void CreateDirectory(string directory) {}
	public System.IO.DirectoryInfo GetDirectoryInfo(string directory) {}
	public System.IO.FileInfo GetFileInfo(string file) {}
	public System.IO.DriveInfo GetDriveInfo(string drive) {}
	public ReadOnlyCollection<string> GetFiles(string directory) {}
	public ReadOnlyCollection<string> GetFiles(string directory, Microsoft.VisualBasic.FileIO.SearchOption searchType, string[] wildcards) {}
	public ReadOnlyCollection<string> GetDirectories(string directory) {}
	public ReadOnlyCollection<string> GetDirectories(string directory, Microsoft.VisualBasic.FileIO.SearchOption searchType, string[] wildcards) {}
	public ReadOnlyCollection<string> FindInFiles(string directory, string containsText, bool ignoreCase, Microsoft.VisualBasic.FileIO.SearchOption searchType) {}
	public ReadOnlyCollection<string> FindInFiles(string directory, string containsText, bool ignoreCase, Microsoft.VisualBasic.FileIO.SearchOption searchType, string[] fileWildcards) {}
	public string GetParentPath(string path) {}
	public string CombinePath(string baseDirectory, string relativePath) {}
	public string GetName(string path) {}
	public string GetTempFileName() {}
	public string ReadAllText(string file) {}
	public string ReadAllText(string file, System.Text.Encoding encoding) {}
	public byte[] ReadAllBytes(string file) {}
	public void WriteAllText(string file, string text, bool append) {}
	public void WriteAllText(string file, string text, bool append, System.Text.Encoding encoding) {}
	public void WriteAllBytes(string file, byte[] data, bool append) {}
	public void CopyFile(string sourceFileName, string destinationFileName) {}
	public void CopyFile(string sourceFileName, string destinationFileName, bool overwrite) {}
	public void CopyFile(string sourceFileName, string destinationFileName, Microsoft.VisualBasic.FileIO.UIOption showUI) {}
	public void CopyFile(string sourceFileName, string destinationFileName, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) {}
	public void MoveFile(string sourceFileName, string destinationFileName) {}
	public void MoveFile(string sourceFileName, string destinationFileName, bool overwrite) {}
	public void MoveFile(string sourceFileName, string destinationFileName, Microsoft.VisualBasic.FileIO.UIOption showUI) {}
	public void MoveFile(string sourceFileName, string destinationFileName, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) {}
	public void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName) {}
	public void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName, bool overwrite) {}
	public void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName, Microsoft.VisualBasic.FileIO.UIOption showUI) {}
	public void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) {}
	public void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName) {}
	public void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName, bool overwrite) {}
	public void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName, Microsoft.VisualBasic.FileIO.UIOption showUI) {}
	public void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) {}
	public void DeleteFile(string file) {}
	public void DeleteFile(string file, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.RecycleOption recycle) {}
	public void DeleteFile(string file, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.RecycleOption recycle, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) {}
	public void DeleteDirectory(string directory, Microsoft.VisualBasic.FileIO.DeleteDirectoryOption onDirectoryNotEmpty) {}
	public void DeleteDirectory(string directory, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.RecycleOption recycle) {}
	public void DeleteDirectory(string directory, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.RecycleOption recycle, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) {}
	public void RenameFile(string file, string newName) {}
	public void RenameDirectory(string directory, string newName) {}
	public Microsoft.VisualBasic.FileIO.TextFieldParser OpenTextFieldParser(string file) {}
	public Microsoft.VisualBasic.FileIO.TextFieldParser OpenTextFieldParser(string file, string[] delimiters) {}
	public Microsoft.VisualBasic.FileIO.TextFieldParser OpenTextFieldParser(string file, int[] fieldWidths) {}
	public System.IO.StreamReader OpenTextFileReader(string file) {}
	public System.IO.StreamReader OpenTextFileReader(string file, System.Text.Encoding encoding) {}
	public System.IO.StreamWriter OpenTextFileWriter(string file, bool append) {}
	public System.IO.StreamWriter OpenTextFileWriter(string file, bool append, System.Text.Encoding encoding) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ReadOnlyCollection<System.IO.DriveInfo> Drives { get{} }
	public SpecialDirectoriesProxy SpecialDirectories { get{} }
	public string CurrentDirectory { get{} set{} }
}


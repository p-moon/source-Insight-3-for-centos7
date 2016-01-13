public class FileSystemEventArgs : System.EventArgs
{

	// Constructors
	public FileSystemEventArgs(WatcherChangeTypes changeType, string directory, string name) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public WatcherChangeTypes ChangeType { get{} }
	public string FullPath { get{} }
	public string Name { get{} }
}


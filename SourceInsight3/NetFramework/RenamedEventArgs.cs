public class RenamedEventArgs : FileSystemEventArgs
{

	// Constructors
	public RenamedEventArgs(WatcherChangeTypes changeType, string directory, string name, string oldName) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string OldFullPath { get{} }
	public string OldName { get{} }
	public WatcherChangeTypes ChangeType { get{} }
	public string FullPath { get{} }
	public string Name { get{} }
}


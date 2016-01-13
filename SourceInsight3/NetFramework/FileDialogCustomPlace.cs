public class FileDialogCustomPlace
{

	// Constructors
	public FileDialogCustomPlace(string path) {}
	public FileDialogCustomPlace(System.Guid knownFolderGuid) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Path { get{} set{} }
	public System.Guid KnownFolderGuid { get{} set{} }
}


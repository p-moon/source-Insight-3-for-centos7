public interface IFolderProjectItem
{

	// Methods
	public abstract virtual IDocumentProjectItem AddDocument(string name, byte[] content) {}
	public abstract virtual IFolderProjectItem AddFolder(string name) {}

	// Properties
	public System.Collections.ICollection Children { get{} }
}


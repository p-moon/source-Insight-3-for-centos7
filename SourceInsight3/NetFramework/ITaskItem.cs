public interface ITaskItem
{

	// Methods
	public abstract virtual string GetMetadata(string metadataName) {}
	public abstract virtual void SetMetadata(string metadataName, string metadataValue) {}
	public abstract virtual void RemoveMetadata(string metadataName) {}
	public abstract virtual void CopyMetadataTo(ITaskItem destinationItem) {}
	public abstract virtual System.Collections.IDictionary CloneCustomMetadata() {}

	// Properties
	public string ItemSpec { get{} set{} }
	public System.Collections.ICollection MetadataNames { get{} }
	public int MetadataCount { get{} }
}


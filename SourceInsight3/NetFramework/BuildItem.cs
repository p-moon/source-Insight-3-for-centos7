public class BuildItem
{

	// Constructors
	public BuildItem(string itemName, string itemInclude) {}
	public BuildItem(string itemName, Microsoft.Build.Framework.ITaskItem taskItem) {}

	// Methods
	public bool HasMetadata(string metadataName) {}
	public string GetMetadata(string metadataName) {}
	public string GetEvaluatedMetadata(string metadataName) {}
	public void CopyCustomMetadataTo(BuildItem destinationItem) {}
	public void SetMetadata(string metadataName, string metadataValue, bool treatMetadataValueAsLiteral) {}
	public void SetMetadata(string metadataName, string metadataValue) {}
	public void RemoveMetadata(string metadataName) {}
	public BuildItem Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsImported { get{} }
	public string Name { get{} set{} }
	public string Include { get{} set{} }
	public string Exclude { get{} set{} }
	public string Condition { get{} set{} }
	public string FinalItemSpec { get{} }
}


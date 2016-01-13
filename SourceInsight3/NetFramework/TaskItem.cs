public class TaskItem : System.MarshalByRefObject, Microsoft.Build.Framework.ITaskItem
{

	// Constructors
	public TaskItem() {}
	public TaskItem(string itemSpec) {}
	public TaskItem(string itemSpec, System.Collections.IDictionary itemMetadata) {}
	public TaskItem(Microsoft.Build.Framework.ITaskItem sourceItem) {}

	// Methods
	public virtual void RemoveMetadata(string metadataName) {}
	public virtual void SetMetadata(string metadataName, string metadataValue) {}
	public virtual string GetMetadata(string metadataName) {}
	public virtual void CopyMetadataTo(Microsoft.Build.Framework.ITaskItem destinationItem) {}
	public virtual System.Collections.IDictionary CloneCustomMetadata() {}
	public virtual string ToString() {}
	public virtual object InitializeLifetimeService() {}
	public static string op_Explicit(TaskItem taskItemToCast) {}
	public virtual object GetLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ItemSpec { get{} set{} }
	public System.Collections.ICollection MetadataNames { get{} }
	public int MetadataCount { get{} }
}


public class ConfigurationSet
{

	// Methods
	public void Dispose() {}
	public static ConfigurationSet GetConfigurationSet(DirectoryContext context) {}
	public AdamInstance FindAdamInstance() {}
	public AdamInstance FindAdamInstance(string partitionName) {}
	public AdamInstance FindAdamInstance(string partitionName, string siteName) {}
	public AdamInstanceCollection FindAllAdamInstances() {}
	public AdamInstanceCollection FindAllAdamInstances(string partitionName) {}
	public AdamInstanceCollection FindAllAdamInstances(string partitionName, string siteName) {}
	public System.DirectoryServices.DirectoryEntry GetDirectoryEntry() {}
	public ReplicationSecurityLevel GetSecurityLevel() {}
	public void SetSecurityLevel(ReplicationSecurityLevel securityLevel) {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public ReadOnlySiteCollection Sites { get{} }
	public AdamInstanceCollection AdamInstances { get{} }
	public ApplicationPartitionCollection ApplicationPartitions { get{} }
	public ActiveDirectorySchema Schema { get{} }
	public AdamInstance SchemaRoleOwner { get{} }
	public AdamInstance NamingRoleOwner { get{} }
}


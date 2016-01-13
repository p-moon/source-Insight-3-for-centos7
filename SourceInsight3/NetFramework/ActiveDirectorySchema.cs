public class ActiveDirectorySchema : ActiveDirectoryPartition, System.IDisposable
{

	// Methods
	public static ActiveDirectorySchema GetSchema(DirectoryContext context) {}
	public void RefreshSchema() {}
	public ActiveDirectorySchemaClass FindClass(string ldapDisplayName) {}
	public ActiveDirectorySchemaClass FindDefunctClass(string commonName) {}
	public ReadOnlyActiveDirectorySchemaClassCollection FindAllClasses() {}
	public ReadOnlyActiveDirectorySchemaClassCollection FindAllClasses(SchemaClassType type) {}
	public ReadOnlyActiveDirectorySchemaClassCollection FindAllDefunctClasses() {}
	public ActiveDirectorySchemaProperty FindProperty(string ldapDisplayName) {}
	public ActiveDirectorySchemaProperty FindDefunctProperty(string commonName) {}
	public ReadOnlyActiveDirectorySchemaPropertyCollection FindAllProperties() {}
	public ReadOnlyActiveDirectorySchemaPropertyCollection FindAllProperties(PropertyTypes type) {}
	public ReadOnlyActiveDirectorySchemaPropertyCollection FindAllDefunctProperties() {}
	public virtual System.DirectoryServices.DirectoryEntry GetDirectoryEntry() {}
	public static ActiveDirectorySchema GetCurrentSchema() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DirectoryServer SchemaRoleOwner { get{} }
	public string Name { get{} }
}


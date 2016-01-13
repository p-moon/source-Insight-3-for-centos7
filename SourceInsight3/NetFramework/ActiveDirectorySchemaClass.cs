public class ActiveDirectorySchemaClass : System.IDisposable
{

	// Constructors
	public ActiveDirectorySchemaClass(DirectoryContext context, string ldapDisplayName) {}

	// Methods
	public virtual void Dispose() {}
	public static ActiveDirectorySchemaClass FindByName(DirectoryContext context, string ldapDisplayName) {}
	public ReadOnlyActiveDirectorySchemaPropertyCollection GetAllProperties() {}
	public void Save() {}
	public virtual string ToString() {}
	public System.DirectoryServices.DirectoryEntry GetDirectoryEntry() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public string CommonName { get{} set{} }
	public string Oid { get{} set{} }
	public string Description { get{} set{} }
	public bool IsDefunct { get{} set{} }
	public ActiveDirectorySchemaClassCollection PossibleSuperiors { get{} }
	public ReadOnlyActiveDirectorySchemaClassCollection PossibleInferiors { get{} }
	public ActiveDirectorySchemaPropertyCollection MandatoryProperties { get{} }
	public ActiveDirectorySchemaPropertyCollection OptionalProperties { get{} }
	public ActiveDirectorySchemaClassCollection AuxiliaryClasses { get{} }
	public ActiveDirectorySchemaClass SubClassOf { get{} set{} }
	public SchemaClassType Type { get{} set{} }
	public System.Guid SchemaGuid { get{} set{} }
	public System.DirectoryServices.ActiveDirectorySecurity DefaultObjectSecurityDescriptor { get{} set{} }
}


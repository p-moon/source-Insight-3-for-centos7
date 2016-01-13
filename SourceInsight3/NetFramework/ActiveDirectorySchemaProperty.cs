public class ActiveDirectorySchemaProperty : System.IDisposable
{

	// Constructors
	public ActiveDirectorySchemaProperty(DirectoryContext context, string ldapDisplayName) {}

	// Methods
	public virtual void Dispose() {}
	public static ActiveDirectorySchemaProperty FindByName(DirectoryContext context, string ldapDisplayName) {}
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
	public ActiveDirectorySyntax Syntax { get{} set{} }
	public string Description { get{} set{} }
	public bool IsSingleValued { get{} set{} }
	public bool IsIndexed { get{} set{} }
	public bool IsIndexedOverContainer { get{} set{} }
	public bool IsInAnr { get{} set{} }
	public bool IsOnTombstonedObject { get{} set{} }
	public bool IsTupleIndexed { get{} set{} }
	public bool IsInGlobalCatalog { get{} set{} }
	public Nullable<int> RangeLower { get{} set{} }
	public Nullable<int> RangeUpper { get{} set{} }
	public bool IsDefunct { get{} set{} }
	public ActiveDirectorySchemaProperty Link { get{} }
	public Nullable<int> LinkId { get{} set{} }
	public System.Guid SchemaGuid { get{} set{} }
}


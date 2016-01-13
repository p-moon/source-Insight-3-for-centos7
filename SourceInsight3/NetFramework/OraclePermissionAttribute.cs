public class OraclePermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public OraclePermissionAttribute(System.Security.Permissions.SecurityAction action) {}

	// Methods
	public virtual System.Security.IPermission CreatePermission() {}
	public bool ShouldSerializeConnectionString() {}
	public bool ShouldSerializeKeyRestrictions() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool AllowBlankPassword { get{} set{} }
	public string ConnectionString { get{} set{} }
	public System.Data.KeyRestrictionBehavior KeyRestrictionBehavior { get{} set{} }
	public string KeyRestrictions { get{} set{} }
	public System.Security.Permissions.SecurityAction Action { get{} set{} }
	public bool Unrestricted { get{} set{} }
	public object TypeId { get{} }
}


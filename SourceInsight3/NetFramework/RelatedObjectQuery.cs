public class RelatedObjectQuery : WqlObjectQuery, System.ICloneable
{

	// Constructors
	public RelatedObjectQuery() {}
	public RelatedObjectQuery(string queryOrSourceObject) {}
	public RelatedObjectQuery(string sourceObject, string relatedClass) {}
	public RelatedObjectQuery(string sourceObject, string relatedClass, string relationshipClass, string relatedQualifier, string relationshipQualifier, string relatedRole, string thisRole, bool classDefinitionsOnly) {}
	public RelatedObjectQuery(bool isSchemaQuery, string sourceObject, string relatedClass, string relationshipClass, string relatedQualifier, string relationshipQualifier, string relatedRole, string thisRole) {}

	// Methods
	public virtual object Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsSchemaQuery { get{} set{} }
	public string SourceObject { get{} set{} }
	public string RelatedClass { get{} set{} }
	public string RelationshipClass { get{} set{} }
	public string RelatedQualifier { get{} set{} }
	public string RelationshipQualifier { get{} set{} }
	public string RelatedRole { get{} set{} }
	public string ThisRole { get{} set{} }
	public bool ClassDefinitionsOnly { get{} set{} }
	public string QueryLanguage { get{} }
	public string QueryString { get{} set{} }
}


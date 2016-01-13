public class RelationshipQuery : WqlObjectQuery, System.ICloneable
{

	// Constructors
	public RelationshipQuery() {}
	public RelationshipQuery(string queryOrSourceObject) {}
	public RelationshipQuery(string sourceObject, string relationshipClass) {}
	public RelationshipQuery(string sourceObject, string relationshipClass, string relationshipQualifier, string thisRole, bool classDefinitionsOnly) {}
	public RelationshipQuery(bool isSchemaQuery, string sourceObject, string relationshipClass, string relationshipQualifier, string thisRole) {}

	// Methods
	public virtual object Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsSchemaQuery { get{} set{} }
	public string SourceObject { get{} set{} }
	public string RelationshipClass { get{} set{} }
	public string RelationshipQualifier { get{} set{} }
	public string ThisRole { get{} set{} }
	public bool ClassDefinitionsOnly { get{} set{} }
	public string QueryLanguage { get{} }
	public string QueryString { get{} set{} }
}


public class DesignerDataRelationship
{

	// Constructors
	public DesignerDataRelationship(string name, System.Collections.ICollection parentColumns, DesignerDataTable childTable, System.Collections.ICollection childColumns) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.ICollection ChildColumns { get{} }
	public DesignerDataTable ChildTable { get{} }
	public string Name { get{} }
	public System.Collections.ICollection ParentColumns { get{} }
}


public class TypeSchema : IDataSourceSchema
{

	// Constructors
	public TypeSchema(Type type) {}

	// Methods
	public virtual IDataSourceViewSchema[] GetViews() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


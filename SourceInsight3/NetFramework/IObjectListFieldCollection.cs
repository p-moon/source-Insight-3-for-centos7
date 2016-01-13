public interface IObjectListFieldCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public abstract virtual ObjectListField[] GetAll() {}
	public abstract virtual int IndexOf(ObjectListField field) {}
	public abstract virtual int IndexOf(string fieldIDOrTitle) {}

	// Properties
	public ObjectListField Item { get{} }
}


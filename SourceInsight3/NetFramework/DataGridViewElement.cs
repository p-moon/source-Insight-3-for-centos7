public class DataGridViewElement
{

	// Constructors
	public DataGridViewElement() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DataGridViewElementStates State { get{} }
	public DataGridView DataGridView { get{} }
}


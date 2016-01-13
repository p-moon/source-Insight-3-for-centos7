public class CategoryAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public CategoryAttribute() {}
	public CategoryAttribute(string category) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public CategoryAttribute Action { get{} }
	public CategoryAttribute Appearance { get{} }
	public CategoryAttribute Asynchronous { get{} }
	public CategoryAttribute Behavior { get{} }
	public CategoryAttribute Data { get{} }
	public CategoryAttribute Default { get{} }
	public CategoryAttribute Design { get{} }
	public CategoryAttribute DragDrop { get{} }
	public CategoryAttribute Focus { get{} }
	public CategoryAttribute Format { get{} }
	public CategoryAttribute Key { get{} }
	public CategoryAttribute Layout { get{} }
	public CategoryAttribute Mouse { get{} }
	public CategoryAttribute WindowStyle { get{} }
	public string Category { get{} }
	public object TypeId { get{} }
}


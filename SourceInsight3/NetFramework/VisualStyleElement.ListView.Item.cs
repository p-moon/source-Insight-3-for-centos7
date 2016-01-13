public class Item
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public VisualStyleElement Normal { get{} }
	public VisualStyleElement Hot { get{} }
	public VisualStyleElement Selected { get{} }
	public VisualStyleElement Disabled { get{} }
	public VisualStyleElement SelectedNotFocus { get{} }
}


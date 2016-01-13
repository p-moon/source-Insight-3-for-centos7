public class TabItem
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public VisualStyleElement Normal { get{} }
	public VisualStyleElement Hot { get{} }
	public VisualStyleElement Pressed { get{} }
	public VisualStyleElement Disabled { get{} }
}


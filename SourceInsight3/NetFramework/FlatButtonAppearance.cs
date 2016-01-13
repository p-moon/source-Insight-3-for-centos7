public class FlatButtonAppearance
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int BorderSize { get{} set{} }
	public System.Drawing.Color BorderColor { get{} set{} }
	public System.Drawing.Color CheckedBackColor { get{} set{} }
	public System.Drawing.Color MouseDownBackColor { get{} set{} }
	public System.Drawing.Color MouseOverBackColor { get{} set{} }
}


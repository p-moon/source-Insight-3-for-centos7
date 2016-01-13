public class Glyph
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public VisualStyleElement Closed { get{} }
	public VisualStyleElement Opened { get{} }
}


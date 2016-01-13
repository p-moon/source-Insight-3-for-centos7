public class Adorner
{

	// Constructors
	public Adorner() {}

	// Methods
	public void Invalidate() {}
	public void Invalidate(System.Drawing.Rectangle rectangle) {}
	public void Invalidate(System.Drawing.Region region) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public BehaviorService BehaviorService { get{} set{} }
	public bool Enabled { get{} set{} }
	public GlyphCollection Glyphs { get{} }
}


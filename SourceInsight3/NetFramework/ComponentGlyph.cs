public class ComponentGlyph : Glyph
{

	// Constructors
	public ComponentGlyph(System.ComponentModel.IComponent relatedComponent, Behavior behavior) {}
	public ComponentGlyph(System.ComponentModel.IComponent relatedComponent) {}

	// Methods
	public virtual System.Windows.Forms.Cursor GetHitTest(System.Drawing.Point p) {}
	public virtual void Paint(System.Windows.Forms.PaintEventArgs pe) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.ComponentModel.IComponent RelatedComponent { get{} }
	public Behavior Behavior { get{} }
	public System.Drawing.Rectangle Bounds { get{} }
}


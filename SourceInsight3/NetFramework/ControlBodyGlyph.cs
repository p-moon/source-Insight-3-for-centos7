public class ControlBodyGlyph : ComponentGlyph
{

	// Constructors
	public ControlBodyGlyph(System.Drawing.Rectangle bounds, System.Windows.Forms.Cursor cursor, System.ComponentModel.IComponent relatedComponent, System.Windows.Forms.Design.ControlDesigner designer) {}
	public ControlBodyGlyph(System.Drawing.Rectangle bounds, System.Windows.Forms.Cursor cursor, System.ComponentModel.IComponent relatedComponent, Behavior behavior) {}

	// Methods
	public virtual System.Windows.Forms.Cursor GetHitTest(System.Drawing.Point p) {}
	public virtual void Paint(System.Windows.Forms.PaintEventArgs pe) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Rectangle Bounds { get{} }
	public System.ComponentModel.IComponent RelatedComponent { get{} }
	public Behavior Behavior { get{} }
}


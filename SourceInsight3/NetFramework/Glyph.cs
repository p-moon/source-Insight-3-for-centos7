public class Glyph
{

	// Methods
	public abstract virtual System.Windows.Forms.Cursor GetHitTest(System.Drawing.Point p) {}
	public abstract virtual void Paint(System.Windows.Forms.PaintEventArgs pe) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Behavior Behavior { get{} }
	public System.Drawing.Rectangle Bounds { get{} }
}


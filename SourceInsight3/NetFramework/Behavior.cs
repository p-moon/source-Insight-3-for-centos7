public class Behavior
{

	// Methods
	public virtual System.ComponentModel.Design.MenuCommand FindCommand(System.ComponentModel.Design.CommandID commandId) {}
	public virtual void OnLoseCapture(Glyph g, System.EventArgs e) {}
	public virtual bool OnMouseDoubleClick(Glyph g, System.Windows.Forms.MouseButtons button, System.Drawing.Point mouseLoc) {}
	public virtual bool OnMouseDown(Glyph g, System.Windows.Forms.MouseButtons button, System.Drawing.Point mouseLoc) {}
	public virtual bool OnMouseEnter(Glyph g) {}
	public virtual bool OnMouseHover(Glyph g, System.Drawing.Point mouseLoc) {}
	public virtual bool OnMouseLeave(Glyph g) {}
	public virtual bool OnMouseMove(Glyph g, System.Windows.Forms.MouseButtons button, System.Drawing.Point mouseLoc) {}
	public virtual bool OnMouseUp(Glyph g, System.Windows.Forms.MouseButtons button) {}
	public virtual void OnDragDrop(Glyph g, System.Windows.Forms.DragEventArgs e) {}
	public virtual void OnDragEnter(Glyph g, System.Windows.Forms.DragEventArgs e) {}
	public virtual void OnDragLeave(Glyph g, System.EventArgs e) {}
	public virtual void OnDragOver(Glyph g, System.Windows.Forms.DragEventArgs e) {}
	public virtual void OnGiveFeedback(Glyph g, System.Windows.Forms.GiveFeedbackEventArgs e) {}
	public virtual void OnQueryContinueDrag(Glyph g, System.Windows.Forms.QueryContinueDragEventArgs e) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Windows.Forms.Cursor Cursor { get{} }
	public bool DisableAllCommands { get{} }
}


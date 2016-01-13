public class BehaviorService : System.IDisposable
{

	// Methods
	public System.Drawing.Point AdornerWindowPointToScreen(System.Drawing.Point p) {}
	public System.Drawing.Point AdornerWindowToScreen() {}
	public System.Drawing.Point ControlToAdornerWindow(System.Windows.Forms.Control c) {}
	public System.Drawing.Point MapAdornerWindowPoint(System.IntPtr handle, System.Drawing.Point pt) {}
	public System.Drawing.Rectangle ControlRectInAdornerWindow(System.Windows.Forms.Control c) {}
	public virtual void Dispose() {}
	public Behavior GetNextBehavior(Behavior behavior) {}
	public void Invalidate() {}
	public void Invalidate(System.Drawing.Rectangle rect) {}
	public void Invalidate(System.Drawing.Region r) {}
	public void SyncSelection() {}
	public Behavior PopBehavior(Behavior behavior) {}
	public void PushBehavior(Behavior behavior) {}
	public void PushCaptureBehavior(Behavior behavior) {}
	public System.Drawing.Point ScreenToAdornerWindow(System.Drawing.Point p) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public BehaviorServiceAdornerCollection Adorners { get{} }
	public System.Drawing.Graphics AdornerWindowGraphics { get{} }
	public Behavior CurrentBehavior { get{} }

	// Events
	public event System.Windows.Forms.Design.Behavior.BehaviorDragDropEventHandler BeginDrag;
	public event System.Windows.Forms.Design.Behavior.BehaviorDragDropEventHandler EndDrag;
	public event System.EventHandler Synchronize;
}


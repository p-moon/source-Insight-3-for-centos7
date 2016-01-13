public interface IDesignerEventService
{

	// Properties
	public IDesignerHost ActiveDesigner { get{} }
	public DesignerCollection Designers { get{} }

	// Events
	public event System.ComponentModel.Design.ActiveDesignerEventHandler ActiveDesignerChanged;
	public event System.ComponentModel.Design.DesignerEventHandler DesignerCreated;
	public event System.ComponentModel.Design.DesignerEventHandler DesignerDisposed;
	public event System.EventHandler SelectionChanged;
}


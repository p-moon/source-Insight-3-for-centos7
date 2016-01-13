public class ActiveDesignerEventArgs : System.EventArgs
{

	// Constructors
	public ActiveDesignerEventArgs(IDesignerHost oldDesigner, IDesignerHost newDesigner) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public IDesignerHost OldDesigner { get{} }
	public IDesignerHost NewDesigner { get{} }
}


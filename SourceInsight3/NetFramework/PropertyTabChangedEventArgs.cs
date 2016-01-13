public class PropertyTabChangedEventArgs : System.EventArgs
{

	// Constructors
	public PropertyTabChangedEventArgs(System.Windows.Forms.Design.PropertyTab oldTab, System.Windows.Forms.Design.PropertyTab newTab) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Windows.Forms.Design.PropertyTab OldTab { get{} }
	public System.Windows.Forms.Design.PropertyTab NewTab { get{} }
}


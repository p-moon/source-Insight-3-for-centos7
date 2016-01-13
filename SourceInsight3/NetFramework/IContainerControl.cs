public interface IContainerControl
{

	// Methods
	public abstract virtual bool ActivateControl(Control active) {}

	// Properties
	public Control ActiveControl { get{} set{} }
}


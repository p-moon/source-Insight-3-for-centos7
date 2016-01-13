public class BindingCompleteEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public BindingCompleteEventArgs(Binding binding, BindingCompleteState state, BindingCompleteContext context, string errorText, System.Exception exception, bool cancel) {}
	public BindingCompleteEventArgs(Binding binding, BindingCompleteState state, BindingCompleteContext context, string errorText, System.Exception exception) {}
	public BindingCompleteEventArgs(Binding binding, BindingCompleteState state, BindingCompleteContext context, string errorText) {}
	public BindingCompleteEventArgs(Binding binding, BindingCompleteState state, BindingCompleteContext context) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Binding Binding { get{} }
	public BindingCompleteState BindingCompleteState { get{} }
	public BindingCompleteContext BindingCompleteContext { get{} }
	public string ErrorText { get{} }
	public System.Exception Exception { get{} }
	public bool Cancel { get{} set{} }
}


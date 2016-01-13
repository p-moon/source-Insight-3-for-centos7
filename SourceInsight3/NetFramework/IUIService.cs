public interface IUIService
{

	// Methods
	public abstract virtual bool CanShowComponentEditor(object component) {}
	public abstract virtual System.Windows.Forms.IWin32Window GetDialogOwnerWindow() {}
	public abstract virtual void SetUIDirty() {}
	public abstract virtual bool ShowComponentEditor(object component, System.Windows.Forms.IWin32Window parent) {}
	public abstract virtual System.Windows.Forms.DialogResult ShowDialog(System.Windows.Forms.Form form) {}
	public abstract virtual void ShowError(string message) {}
	public abstract virtual void ShowError(System.Exception ex) {}
	public abstract virtual void ShowError(System.Exception ex, string message) {}
	public abstract virtual void ShowMessage(string message) {}
	public abstract virtual void ShowMessage(string message, string caption) {}
	public abstract virtual System.Windows.Forms.DialogResult ShowMessage(string message, string caption, System.Windows.Forms.MessageBoxButtons buttons) {}
	public abstract virtual bool ShowToolWindow(System.Guid toolWindow) {}

	// Properties
	public System.Collections.IDictionary Styles { get{} }
}


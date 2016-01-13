public interface IVsaIDE
{

	// Methods
	public abstract virtual void ShowIDE(bool showOrHide) {}
	public abstract virtual void EnableMainWindow(bool isEnable) {}

	// Properties
	public IVsaIDESite Site { get{} set{} }
	public string DefaultSearchPath { get{} set{} }
	public object ExtensibilityObject { get{} }
	public VsaIDEMode IDEMode { get{} }
}


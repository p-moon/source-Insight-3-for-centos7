public class HelpProvider : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable, System.ComponentModel.IExtenderProvider
{

	// Constructors
	public HelpProvider() {}

	// Methods
	public virtual bool CanExtend(object target) {}
	public virtual string GetHelpKeyword(Control ctl) {}
	public virtual HelpNavigator GetHelpNavigator(Control ctl) {}
	public virtual string GetHelpString(Control ctl) {}
	public virtual bool GetShowHelp(Control ctl) {}
	public virtual void SetHelpString(Control ctl, string helpString) {}
	public virtual void SetHelpKeyword(Control ctl, string keyword) {}
	public virtual void SetHelpNavigator(Control ctl, HelpNavigator navigator) {}
	public virtual void SetShowHelp(Control ctl, bool value) {}
	public virtual void ResetShowHelp(Control ctl) {}
	public virtual string ToString() {}
	public virtual void Dispose() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string HelpNamespace { get{} set{} }
	public object Tag { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}


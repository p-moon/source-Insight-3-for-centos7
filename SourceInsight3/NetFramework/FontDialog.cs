public class FontDialog : CommonDialog, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public FontDialog() {}

	// Methods
	public virtual void Reset() {}
	public virtual string ToString() {}
	public DialogResult ShowDialog() {}
	public DialogResult ShowDialog(IWin32Window owner) {}
	public virtual void Dispose() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool AllowSimulations { get{} set{} }
	public bool AllowVectorFonts { get{} set{} }
	public bool AllowVerticalFonts { get{} set{} }
	public bool AllowScriptChange { get{} set{} }
	public System.Drawing.Color Color { get{} set{} }
	public bool FixedPitchOnly { get{} set{} }
	public System.Drawing.Font Font { get{} set{} }
	public bool FontMustExist { get{} set{} }
	public int MaxSize { get{} set{} }
	public int MinSize { get{} set{} }
	public bool ScriptsOnly { get{} set{} }
	public bool ShowApply { get{} set{} }
	public bool ShowColor { get{} set{} }
	public bool ShowEffects { get{} set{} }
	public bool ShowHelp { get{} set{} }
	public object Tag { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Apply;
	public event System.EventHandler HelpRequest;
	public event System.EventHandler Disposed;
}


public class GridEntryAccessibleObject : System.Windows.Forms.AccessibleObject, Microsoft.Win32.UnsafeNativeMethods.IMarshal, System.Reflection.IReflect, Accessibility.IAccessible, System.Windows.Forms.UnsafeNativeMethods.IEnumVariant, System.Windows.Forms.UnsafeNativeMethods.IOleWindow
{

	// Constructors
	public GridEntryAccessibleObject(GridEntry owner) {}

	// Methods
	public virtual void DoDefaultAction() {}
	public virtual System.Windows.Forms.AccessibleObject GetFocused() {}
	public virtual System.Windows.Forms.AccessibleObject Navigate(System.Windows.Forms.AccessibleNavigation navdir) {}
	public virtual void Select(System.Windows.Forms.AccessibleSelection flags) {}
	public virtual System.Windows.Forms.AccessibleObject GetChild(int index) {}
	public virtual int GetChildCount() {}
	public virtual int GetHelpTopic(out System.String& fileName) {}
	public virtual System.Windows.Forms.AccessibleObject GetSelected() {}
	public virtual System.Windows.Forms.AccessibleObject HitTest(int x, int y) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Rectangle Bounds { get{} }
	public string DefaultAction { get{} }
	public string Description { get{} }
	public string Name { get{} }
	public System.Windows.Forms.AccessibleObject Parent { get{} }
	public System.Windows.Forms.AccessibleRole Role { get{} }
	public System.Windows.Forms.AccessibleStates State { get{} }
	public string Value { get{} set{} }
	public string Help { get{} }
	public string KeyboardShortcut { get{} }
}


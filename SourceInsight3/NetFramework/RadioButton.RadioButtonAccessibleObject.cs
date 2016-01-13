public class RadioButtonAccessibleObject : ButtonBaseAccessibleObject, Microsoft.Win32.UnsafeNativeMethods.IMarshal, System.Reflection.IReflect, Accessibility.IAccessible, IEnumVariant, IOleWindow
{

	// Constructors
	public RadioButtonAccessibleObject(RadioButton owner) {}

	// Methods
	public virtual void DoDefaultAction() {}
	public virtual int GetHelpTopic(out System.String& fileName) {}
	public void NotifyClients(AccessibleEvents accEvent) {}
	public void NotifyClients(AccessibleEvents accEvent, int childID) {}
	public void NotifyClients(AccessibleEvents accEvent, int objectID, int childID) {}
	public virtual string ToString() {}
	public virtual AccessibleObject GetChild(int index) {}
	public virtual int GetChildCount() {}
	public virtual AccessibleObject GetFocused() {}
	public virtual AccessibleObject GetSelected() {}
	public virtual AccessibleObject HitTest(int x, int y) {}
	public virtual AccessibleObject Navigate(AccessibleNavigation navdir) {}
	public virtual void Select(AccessibleSelection flags) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string DefaultAction { get{} }
	public AccessibleRole Role { get{} }
	public AccessibleStates State { get{} }
	public string Description { get{} }
	public System.IntPtr Handle { get{} set{} }
	public string Help { get{} }
	public string KeyboardShortcut { get{} }
	public string Name { get{} set{} }
	public AccessibleObject Parent { get{} }
	public Control Owner { get{} }
	public System.Drawing.Rectangle Bounds { get{} }
	public string Value { get{} set{} }
}


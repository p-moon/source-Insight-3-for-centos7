public class Context
{

	// Constructors
	public Context() {}

	// Methods
	public virtual IContextProperty GetProperty(string name) {}
	public virtual void SetProperty(IContextProperty prop) {}
	public virtual void Freeze() {}
	public virtual string ToString() {}
	public void DoCallBack(CrossContextDelegate deleg) {}
	public static System.LocalDataStoreSlot AllocateDataSlot() {}
	public static System.LocalDataStoreSlot AllocateNamedDataSlot(string name) {}
	public static System.LocalDataStoreSlot GetNamedDataSlot(string name) {}
	public static void FreeNamedDataSlot(string name) {}
	public static void SetData(System.LocalDataStoreSlot slot, object data) {}
	public static object GetData(System.LocalDataStoreSlot slot) {}
	public static bool RegisterDynamicProperty(IDynamicProperty prop, System.ContextBoundObject obj, Context ctx) {}
	public static bool UnregisterDynamicProperty(string name, System.ContextBoundObject obj, Context ctx) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int ContextID { get{} }
	public Context DefaultContext { get{} }
	public IContextProperty[] ContextProperties { get{} }
}


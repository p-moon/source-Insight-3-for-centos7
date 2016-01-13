public class ControlPersister
{

	// Methods
	public static string PersistInnerProperties(object component, System.ComponentModel.Design.IDesignerHost host) {}
	public static void PersistInnerProperties(System.IO.TextWriter sw, object component, System.ComponentModel.Design.IDesignerHost host) {}
	public static string PersistControl(System.Web.UI.Control control) {}
	public static string PersistControl(System.Web.UI.Control control, System.ComponentModel.Design.IDesignerHost host) {}
	public static void PersistControl(System.IO.TextWriter sw, System.Web.UI.Control control) {}
	public static void PersistControl(System.IO.TextWriter sw, System.Web.UI.Control control, System.ComponentModel.Design.IDesignerHost host) {}
	public static string PersistTemplate(System.Web.UI.ITemplate template, System.ComponentModel.Design.IDesignerHost host) {}
	public static void PersistTemplate(System.IO.TextWriter writer, System.Web.UI.ITemplate template, System.ComponentModel.Design.IDesignerHost host) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


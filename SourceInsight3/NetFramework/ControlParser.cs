public class ControlParser
{

	// Methods
	public static System.Web.UI.Control ParseControl(System.ComponentModel.Design.IDesignerHost designerHost, string controlText) {}
	public static System.Web.UI.Control ParseControl(System.ComponentModel.Design.IDesignerHost designerHost, string controlText, string directives) {}
	public static System.Web.UI.Control[] ParseControls(System.ComponentModel.Design.IDesignerHost designerHost, string controlText) {}
	public static System.Web.UI.ITemplate ParseTemplate(System.ComponentModel.Design.IDesignerHost designerHost, string templateText) {}
	public static System.Web.UI.ITemplate ParseTemplate(System.ComponentModel.Design.IDesignerHost designerHost, string templateText, string directives) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


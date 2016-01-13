public class ToolStripManager
{

	// Methods
	public static ToolStrip FindToolStrip(string toolStripName) {}
	public static void LoadSettings(Form targetForm) {}
	public static void LoadSettings(Form targetForm, string key) {}
	public static void SaveSettings(Form sourceForm) {}
	public static void SaveSettings(Form sourceForm, string key) {}
	public static bool IsValidShortcut(Keys shortcut) {}
	public static bool IsShortcutDefined(Keys shortcut) {}
	public static bool Merge(ToolStrip sourceToolStrip, ToolStrip targetToolStrip) {}
	public static bool Merge(ToolStrip sourceToolStrip, string targetName) {}
	public static bool RevertMerge(ToolStrip targetToolStrip) {}
	public static bool RevertMerge(ToolStrip targetToolStrip, ToolStrip sourceToolStrip) {}
	public static bool RevertMerge(string targetName) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ToolStripRenderer Renderer { get{} set{} }
	public ToolStripManagerRenderMode RenderMode { get{} set{} }
	public bool VisualStylesEnabled { get{} set{} }

	// Events
	public event System.EventHandler RendererChanged;
}


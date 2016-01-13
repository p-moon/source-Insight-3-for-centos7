public class VisualStyleInformation
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsSupportedByOS { get{} }
	public bool IsEnabledByUser { get{} }
	public string ColorScheme { get{} }
	public string Size { get{} }
	public string DisplayName { get{} }
	public string Company { get{} }
	public string Author { get{} }
	public string Copyright { get{} }
	public string Url { get{} }
	public string Version { get{} }
	public string Description { get{} }
	public bool SupportsFlatMenus { get{} }
	public int MinimumColorDepth { get{} }
	public System.Drawing.Color TextControlBorder { get{} }
	public System.Drawing.Color ControlHighlightHot { get{} }
}


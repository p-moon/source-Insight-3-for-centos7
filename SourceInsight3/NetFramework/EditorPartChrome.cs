public class EditorPartChrome
{

	// Constructors
	public EditorPartChrome(EditorZoneBase zone) {}

	// Methods
	public virtual void PerformPreRender() {}
	public virtual void RenderEditorPart(System.Web.UI.HtmlTextWriter writer, EditorPart editorPart) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


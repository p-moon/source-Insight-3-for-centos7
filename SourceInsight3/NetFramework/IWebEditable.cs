public interface IWebEditable
{

	// Methods
	public abstract virtual EditorPartCollection CreateEditorParts() {}

	// Properties
	public object WebBrowsableObject { get{} }
}


public interface IControlDesignerBehavior
{

	// Methods
	public abstract virtual void OnTemplateModeChanged() {}

	// Properties
	public object DesignTimeElementView { get{} }
	public string DesignTimeHtml { get{} set{} }
}


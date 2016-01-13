public interface IContentResolutionService
{

	// Methods
	public abstract virtual ContentDesignerState GetContentDesignerState(string identifier) {}
	public abstract virtual void SetContentDesignerState(string identifier, ContentDesignerState state) {}

	// Properties
	public System.Collections.IDictionary ContentDefinitions { get{} }
}


public interface IRootDesigner : IDesigner, System.IDisposable
{

	// Methods
	public abstract virtual object GetView(ViewTechnology technology) {}

	// Properties
	public ViewTechnology[] SupportedTechnologies { get{} }
}


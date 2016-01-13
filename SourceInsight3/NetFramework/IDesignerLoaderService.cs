public interface IDesignerLoaderService
{

	// Methods
	public abstract virtual void AddLoadDependency() {}
	public abstract virtual void DependentLoadComplete(bool successful, System.Collections.ICollection errorCollection) {}
	public abstract virtual bool Reload() {}
}


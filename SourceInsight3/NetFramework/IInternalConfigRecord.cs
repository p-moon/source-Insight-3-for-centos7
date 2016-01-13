public interface IInternalConfigRecord
{

	// Methods
	public abstract virtual void ThrowIfInitErrors() {}
	public abstract virtual object GetSection(string configKey) {}
	public abstract virtual object GetLkgSection(string configKey) {}
	public abstract virtual void RefreshSection(string configKey) {}
	public abstract virtual void Remove() {}

	// Properties
	public string ConfigPath { get{} }
	public string StreamName { get{} }
	public bool HasInitErrors { get{} }
}


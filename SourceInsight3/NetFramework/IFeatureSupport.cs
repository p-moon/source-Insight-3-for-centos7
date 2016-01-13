public interface IFeatureSupport
{

	// Methods
	public abstract virtual bool IsPresent(object feature) {}
	public abstract virtual bool IsPresent(object feature, System.Version minimumVersion) {}
	public abstract virtual System.Version GetVersionPresent(object feature) {}
}


public class FeatureSupport : IFeatureSupport
{

	// Methods
	public static bool IsPresent(string featureClassName, string featureConstName) {}
	public static bool IsPresent(string featureClassName, string featureConstName, System.Version minimumVersion) {}
	public static System.Version GetVersionPresent(string featureClassName, string featureConstName) {}
	public virtual bool IsPresent(object feature) {}
	public virtual bool IsPresent(object feature, System.Version minimumVersion) {}
	public abstract virtual System.Version GetVersionPresent(object feature) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


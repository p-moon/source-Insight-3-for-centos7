public class OSFeature : FeatureSupport, IFeatureSupport
{

	// Methods
	public virtual System.Version GetVersionPresent(object feature) {}
	public static bool IsPresent(SystemParameter enumVal) {}
	public virtual bool IsPresent(object feature) {}
	public virtual bool IsPresent(object feature, System.Version minimumVersion) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public object LayeredWindows;
	public object Themes;

	// Properties
	public OSFeature Feature { get{} }
}


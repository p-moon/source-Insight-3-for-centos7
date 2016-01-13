public interface IResourceProvider
{

	// Methods
	public abstract virtual object GetObject(string resourceKey, System.Globalization.CultureInfo culture) {}

	// Properties
	public System.Resources.IResourceReader ResourceReader { get{} }
}


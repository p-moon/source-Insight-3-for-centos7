public interface IResourceService
{

	// Methods
	public abstract virtual System.Resources.IResourceReader GetResourceReader(System.Globalization.CultureInfo info) {}
	public abstract virtual System.Resources.IResourceWriter GetResourceWriter(System.Globalization.CultureInfo info) {}
}


public interface IImplicitResourceProvider
{

	// Methods
	public abstract virtual object GetObject(ImplicitResourceKey key, System.Globalization.CultureInfo culture) {}
	public abstract virtual System.Collections.ICollection GetImplicitResourceKeys(string keyPrefix) {}
}


public interface IThemeResolutionService
{

	// Methods
	public abstract virtual ThemeProvider[] GetAllThemeProviders() {}
	public abstract virtual ThemeProvider GetThemeProvider() {}
	public abstract virtual ThemeProvider GetStylesheetThemeProvider() {}
}


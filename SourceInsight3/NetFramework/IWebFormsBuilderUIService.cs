public interface IWebFormsBuilderUIService
{

	// Methods
	public abstract virtual string BuildColor(System.Windows.Forms.Control owner, string initialColor) {}
	public abstract virtual string BuildUrl(System.Windows.Forms.Control owner, string initialUrl, string baseUrl, string caption, string filter, UrlBuilderOptions options) {}
}


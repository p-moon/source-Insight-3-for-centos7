public interface IStyleSheet
{

	// Methods
	public abstract virtual void CreateStyleRule(System.Web.UI.WebControls.Style style, IUrlResolutionService urlResolver, string selector) {}
	public abstract virtual void RegisterStyle(System.Web.UI.WebControls.Style style, IUrlResolutionService urlResolver) {}
}


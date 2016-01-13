public interface IHelpService
{

	// Methods
	public abstract virtual void AddContextAttribute(string name, string value, HelpKeywordType keywordType) {}
	public abstract virtual void ClearContextAttributes() {}
	public abstract virtual IHelpService CreateLocalContext(HelpContextType contextType) {}
	public abstract virtual void RemoveContextAttribute(string name, string value) {}
	public abstract virtual void RemoveLocalContext(IHelpService localContext) {}
	public abstract virtual void ShowHelpFromKeyword(string helpKeyword) {}
	public abstract virtual void ShowHelpFromUrl(string helpUrl) {}
}


public interface IDesignerOptionService
{

	// Methods
	public abstract virtual object GetOptionValue(string pageName, string valueName) {}
	public abstract virtual void SetOptionValue(string pageName, string valueName, object value) {}
}


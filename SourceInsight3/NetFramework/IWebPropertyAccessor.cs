public interface IWebPropertyAccessor
{

	// Methods
	public abstract virtual object GetProperty(object target) {}
	public abstract virtual void SetProperty(object target, object value) {}
}


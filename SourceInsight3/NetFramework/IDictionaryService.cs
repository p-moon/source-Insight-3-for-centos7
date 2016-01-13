public interface IDictionaryService
{

	// Methods
	public abstract virtual object GetKey(object value) {}
	public abstract virtual object GetValue(object key) {}
	public abstract virtual void SetValue(object key, object value) {}
}


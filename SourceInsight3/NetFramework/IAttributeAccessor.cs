public interface IAttributeAccessor
{

	// Methods
	public abstract virtual string GetAttribute(string key) {}
	public abstract virtual void SetAttribute(string key, string value) {}
}


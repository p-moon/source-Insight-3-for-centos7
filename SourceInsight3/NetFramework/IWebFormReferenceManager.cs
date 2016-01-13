public interface IWebFormReferenceManager
{

	// Methods
	public abstract virtual Type GetObjectType(string tagPrefix, string typeName) {}
	public abstract virtual string GetTagPrefix(Type objectType) {}
	public abstract virtual string GetRegisterDirectives() {}
}


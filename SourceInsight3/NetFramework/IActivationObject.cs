public interface IActivationObject
{

	// Methods
	public abstract virtual object GetDefaultThisObject() {}
	public abstract virtual GlobalScope GetGlobalScope() {}
	public abstract virtual System.Reflection.FieldInfo GetLocalField(string name) {}
	public abstract virtual object GetMemberValue(string name, int lexlevel) {}
	public abstract virtual System.Reflection.FieldInfo GetField(string name, int lexLevel) {}
}


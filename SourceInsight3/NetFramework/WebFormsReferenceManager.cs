public class WebFormsReferenceManager
{

	// Methods
	public abstract virtual Type GetType(string tagPrefix, string tagName) {}
	public abstract virtual string GetTagPrefix(Type objectType) {}
	public abstract virtual string RegisterTagPrefix(Type objectType) {}
	public abstract virtual System.Collections.ICollection GetRegisterDirectives() {}
	public abstract virtual string GetUserControlPath(string tagPrefix, string tagName) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


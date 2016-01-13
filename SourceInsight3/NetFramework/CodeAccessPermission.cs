public class CodeAccessPermission : IPermission, ISecurityEncodable, IStackWalk
{

	// Methods
	public static void RevertAssert() {}
	public virtual void Assert() {}
	public static void RevertDeny() {}
	public static void RevertPermitOnly() {}
	public static void RevertAll() {}
	public virtual void Demand() {}
	public virtual void Deny() {}
	public virtual void PermitOnly() {}
	public virtual IPermission Union(IPermission other) {}
	public abstract virtual SecurityElement ToXml() {}
	public abstract virtual void FromXml(SecurityElement elem) {}
	public virtual string ToString() {}
	public abstract virtual IPermission Copy() {}
	public abstract virtual IPermission Intersect(IPermission target) {}
	public abstract virtual bool IsSubsetOf(IPermission target) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
}


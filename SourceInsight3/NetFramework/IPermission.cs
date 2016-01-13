public interface IPermission : ISecurityEncodable
{

	// Methods
	public abstract virtual IPermission Copy() {}
	public abstract virtual IPermission Intersect(IPermission target) {}
	public abstract virtual IPermission Union(IPermission target) {}
	public abstract virtual bool IsSubsetOf(IPermission target) {}
	public abstract virtual void Demand() {}
}


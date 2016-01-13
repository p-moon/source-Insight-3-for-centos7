public interface IAppDomainInfoEnum
{

	// Methods
	public abstract virtual IAppDomainInfo GetData() {}
	public abstract virtual int Count() {}
	public abstract virtual bool MoveNext() {}
	public abstract virtual void Reset() {}
}


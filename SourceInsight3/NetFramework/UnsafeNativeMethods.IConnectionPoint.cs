public interface IConnectionPoint
{

	// Methods
	public abstract virtual int Advise(object pUnkSink, System.Int32& cookie) {}
	public abstract virtual int GetConnectionInterface(out System.Guid& iid) {}
	public abstract virtual int GetConnectionPointContainer(IConnectionPointContainer& pContainer) {}
	public abstract virtual int Unadvise(int cookie) {}
	public abstract virtual int EnumConnections(out System.Object& pEnum) {}
}


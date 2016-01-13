public interface IConnectionPoint
{

	// Methods
	public abstract virtual void GetConnectionInterface(out System.Guid& pIID) {}
	public abstract virtual void GetConnectionPointContainer(out IConnectionPointContainer& ppCPC) {}
	public abstract virtual void Advise(object pUnkSinkout , System.Int32& pdwCookie) {}
	public abstract virtual void Unadvise(int dwCookie) {}
	public abstract virtual void EnumConnections(out IEnumConnections& ppEnum) {}
}


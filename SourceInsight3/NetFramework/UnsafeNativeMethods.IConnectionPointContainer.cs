public interface IConnectionPointContainer
{

	// Methods
	public abstract virtual int FindConnectionPoint(System.Guid& guidout , IConnectionPoint& ppCP) {}
	public abstract virtual object EnumConnectionPoints() {}
}


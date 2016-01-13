public interface IConnectionPointContainer
{

	// Methods
	public abstract virtual void EnumConnectionPoints(out IEnumConnectionPoints& ppEnum) {}
	public abstract virtual void FindConnectionPoint(System.Guid& riidout , IConnectionPoint& ppCP) {}
}


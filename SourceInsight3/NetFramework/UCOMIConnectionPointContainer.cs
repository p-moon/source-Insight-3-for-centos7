public interface UCOMIConnectionPointContainer
{

	// Methods
	public abstract virtual void EnumConnectionPoints(out UCOMIEnumConnectionPoints& ppEnum) {}
	public abstract virtual void FindConnectionPoint(System.Guid& riidout , UCOMIConnectionPoint& ppCP) {}
}


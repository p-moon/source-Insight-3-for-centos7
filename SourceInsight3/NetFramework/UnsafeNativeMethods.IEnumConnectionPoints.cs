public interface IEnumConnectionPoints
{

	// Methods
	public abstract virtual int Next(int cConnectionsout , IConnectionPoint& pCpout , System.Int32& pcFetched) {}
	public abstract virtual int Skip(int cSkip) {}
	public abstract virtual void Reset() {}
	public abstract virtual IEnumConnectionPoints Clone() {}
}


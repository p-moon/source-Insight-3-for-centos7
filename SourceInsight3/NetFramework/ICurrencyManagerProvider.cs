public interface ICurrencyManagerProvider
{

	// Methods
	public abstract virtual CurrencyManager GetRelatedCurrencyManager(string dataMember) {}

	// Properties
	public CurrencyManager CurrencyManager { get{} }
}


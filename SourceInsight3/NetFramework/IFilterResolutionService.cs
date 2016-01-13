public interface IFilterResolutionService
{

	// Methods
	public abstract virtual bool EvaluateFilter(string filterName) {}
	public abstract virtual int CompareFilters(string filter1, string filter2) {}
}


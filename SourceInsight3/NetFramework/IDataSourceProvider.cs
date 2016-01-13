public interface IDataSourceProvider
{

	// Methods
	public abstract virtual object GetSelectedDataSource() {}
	public abstract virtual System.Collections.IEnumerable GetResolvedSelectedDataSource() {}
}


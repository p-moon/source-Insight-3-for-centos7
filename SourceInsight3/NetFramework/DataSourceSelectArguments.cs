public class DataSourceSelectArguments
{

	// Constructors
	public DataSourceSelectArguments() {}
	public DataSourceSelectArguments(string sortExpression) {}
	public DataSourceSelectArguments(int startRowIndex, int maximumRows) {}
	public DataSourceSelectArguments(string sortExpression, int startRowIndex, int maximumRows) {}

	// Methods
	public void AddSupportedCapabilities(DataSourceCapabilities capabilities) {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public void RaiseUnsupportedCapabilitiesError(DataSourceView view) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public DataSourceSelectArguments Empty { get{} }
	public int MaximumRows { get{} set{} }
	public bool RetrieveTotalRowCount { get{} set{} }
	public string SortExpression { get{} set{} }
	public int StartRowIndex { get{} set{} }
	public int TotalRowCount { get{} set{} }
}


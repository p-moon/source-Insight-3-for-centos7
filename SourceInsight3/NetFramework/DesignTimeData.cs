public class DesignTimeData
{

	// Methods
	public static System.Data.DataTable CreateDummyDataTable() {}
	public static System.Data.DataTable CreateDummyDataBoundDataTable() {}
	public static System.Data.DataTable CreateSampleDataTable(System.Collections.IEnumerable referenceData) {}
	public static System.Data.DataTable CreateSampleDataTable(System.Collections.IEnumerable referenceData, bool useDataBoundData) {}
	public static System.ComponentModel.PropertyDescriptorCollection GetDataFields(System.Collections.IEnumerable dataSource) {}
	public static string[] GetDataMembers(object dataSource) {}
	public static System.Collections.IEnumerable GetDataMember(System.ComponentModel.IListSource dataSource, string dataMember) {}
	public static System.Collections.IEnumerable GetDesignTimeDataSource(System.Data.DataTable dataTable, int minimumRows) {}
	public static object GetSelectedDataSource(System.ComponentModel.IComponent component, string dataSource) {}
	public static System.Collections.IEnumerable GetSelectedDataSource(System.ComponentModel.IComponent component, string dataSource, string dataMember) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public System.EventHandler DataBindingHandler;
}


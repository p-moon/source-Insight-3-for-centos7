public interface IWebPartTable
{

	// Methods
	public abstract virtual void GetTableData(TableCallback callback) {}

	// Properties
	public System.ComponentModel.PropertyDescriptorCollection Schema { get{} }
}


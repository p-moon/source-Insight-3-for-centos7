public interface IWebPartRow
{

	// Methods
	public abstract virtual void GetRowData(RowCallback callback) {}

	// Properties
	public System.ComponentModel.PropertyDescriptorCollection Schema { get{} }
}


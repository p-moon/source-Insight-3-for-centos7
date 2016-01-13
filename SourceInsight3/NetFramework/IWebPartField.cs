public interface IWebPartField
{

	// Methods
	public abstract virtual void GetFieldValue(FieldCallback callback) {}

	// Properties
	public System.ComponentModel.PropertyDescriptor Schema { get{} }
}


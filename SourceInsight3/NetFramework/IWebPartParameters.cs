public interface IWebPartParameters
{

	// Methods
	public abstract virtual void GetParametersData(ParametersCallback callback) {}
	public abstract virtual void SetConsumerSchema(System.ComponentModel.PropertyDescriptorCollection schema) {}

	// Properties
	public System.ComponentModel.PropertyDescriptorCollection Schema { get{} }
}


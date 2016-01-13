public interface IValidator
{

	// Methods
	public abstract virtual void Validate() {}

	// Properties
	public bool IsValid { get{} set{} }
	public string ErrorMessage { get{} set{} }
}


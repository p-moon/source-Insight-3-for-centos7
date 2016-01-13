public interface INameCreationService
{

	// Methods
	public abstract virtual string CreateName(System.ComponentModel.IContainer container, Type dataType) {}
	public abstract virtual bool IsValidName(string name) {}
	public abstract virtual void ValidateName(string name) {}
}


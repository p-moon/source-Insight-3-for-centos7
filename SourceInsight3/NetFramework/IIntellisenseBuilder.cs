public interface IIntellisenseBuilder
{

	// Methods
	public abstract virtual bool Show(string language, string value, System.String& newValue) {}

	// Properties
	public string Name { get{} }
}


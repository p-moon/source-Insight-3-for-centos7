public class JSAuthor : IAuthorServices
{

	// Constructors
	public JSAuthor() {}

	// Methods
	public virtual IColorizeText GetColorizer() {}
	public virtual IParseText GetCodeSense() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


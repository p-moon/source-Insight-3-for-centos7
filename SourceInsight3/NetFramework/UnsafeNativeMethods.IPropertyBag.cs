public interface IPropertyBag
{

	// Methods
	public abstract virtual int Read(string pszPropNameout , System.Object& pVar, IErrorLog pErrorLog) {}
	public abstract virtual int Write(string pszPropName, System.Object& pVar) {}
}


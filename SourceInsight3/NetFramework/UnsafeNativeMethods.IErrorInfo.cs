public interface IErrorInfo
{

	// Methods
	public abstract virtual int GetGUID(out System.Guid& pguid) {}
	public abstract virtual int GetSource(out System.String& pBstrSource) {}
	public abstract virtual int GetDescription(out System.String& pBstrDescription) {}
	public abstract virtual int GetHelpFile(out System.String& pBstrHelpFile) {}
	public abstract virtual int GetHelpContext(out System.Int32& pdwHelpContext) {}
}


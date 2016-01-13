public interface IDebugVsaScriptCodeItem
{

	// Methods
	public abstract virtual object Evaluate() {}
	public abstract virtual bool ParseNamedBreakPoint(string inputout , System.String& functionNameout , System.Int32& nargsout , System.String& argumentsout , System.String& returnTypeout , System.UInt64& offset) {}
}


public interface IVsaScriptCodeItem : Microsoft.Vsa.IVsaCodeItem, Microsoft.Vsa.IVsaItem
{

	// Methods
	public abstract virtual object Execute() {}

	// Properties
	public int StartLine { get{} set{} }
	public int StartColumn { get{} set{} }
}


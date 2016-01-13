public interface IVsaCodeItem : IVsaItem
{

	// Methods
	public abstract virtual void AppendSourceText(string text) {}
	public abstract virtual void AddEventSource(string eventSourceName, string eventSourceType) {}
	public abstract virtual void RemoveEventSource(string eventSourceName) {}

	// Properties
	public string SourceText { get{} set{} }
	public System.CodeDom.CodeObject CodeDOM { get{} }
}


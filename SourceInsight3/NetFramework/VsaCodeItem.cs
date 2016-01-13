public class VsaCodeItem : VsaItem, Microsoft.Vsa.IVsaItem, Microsoft.Vsa.IVsaCodeItem
{

	// Methods
	public virtual void AppendSourceText(string Text) {}
	public virtual void AddEventSource(string EventSourceName, string EventSourceType) {}
	public virtual void RemoveEventSource(string EventSourceName) {}
	public virtual object GetOption(string Name) {}
	public virtual void SetOption(string Name, object value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string SourceText { get{} set{} }
	public System.CodeDom.CodeObject CodeDOM { get{} }
	public Microsoft.Vsa.IVsaItem _item { get{} set{} }
	public string Name { get{} set{} }
	public Microsoft.Vsa.VsaItemType ItemType { get{} }
	public bool IsDirty { get{} }
}


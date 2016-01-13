public interface IVsaItem
{

	// Methods
	public abstract virtual object GetOption(string name) {}
	public abstract virtual void SetOption(string name, object value) {}

	// Properties
	public string Name { get{} set{} }
	public VsaItemType ItemType { get{} }
	public bool IsDirty { get{} }
}


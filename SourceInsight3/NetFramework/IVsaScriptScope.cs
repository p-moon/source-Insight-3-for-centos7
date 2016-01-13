public interface IVsaScriptScope : Microsoft.Vsa.IVsaItem
{

	// Methods
	public abstract virtual Microsoft.Vsa.IVsaItem AddItem(string itemName, Microsoft.Vsa.VsaItemType type) {}
	public abstract virtual Microsoft.Vsa.IVsaItem GetItem(string itemName) {}
	public abstract virtual void RemoveItem(string itemName) {}
	public abstract virtual void RemoveItem(Microsoft.Vsa.IVsaItem item) {}
	public abstract virtual int GetItemCount() {}
	public abstract virtual Microsoft.Vsa.IVsaItem GetItemAtIndex(int index) {}
	public abstract virtual void RemoveItemAtIndex(int index) {}
	public abstract virtual object GetObject() {}
	public abstract virtual Microsoft.Vsa.IVsaItem CreateDynamicItem(string itemName, Microsoft.Vsa.VsaItemType type) {}

	// Properties
	public IVsaScriptScope Parent { get{} }
}


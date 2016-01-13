public interface IVsaItems : System.Collections.IEnumerable
{

	// Methods
	public abstract virtual IVsaItem CreateItem(string name, VsaItemType itemType, VsaItemFlag itemFlag) {}
	public abstract virtual void Remove(string name) {}
	public abstract virtual void Remove(int index) {}

	// Properties
	public int Count { get{} }
	public IVsaItem Item { get{} }
	public IVsaItem Item { get{} }
}


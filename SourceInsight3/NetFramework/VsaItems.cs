public class VsaItems : Microsoft.Vsa.IVsaItems, System.Collections.IEnumerable
{

	// Constructors
	public VsaItems(Microsoft.JScript.Vsa.VsaEngine engine) {}

	// Methods
	public void Close() {}
	public virtual Microsoft.Vsa.IVsaItem CreateItem(string name, Microsoft.Vsa.VsaItemType itemType, Microsoft.Vsa.VsaItemFlag itemFlag) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual void Remove(string itemName) {}
	public virtual void Remove(int itemIndex) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Microsoft.Vsa.IVsaItem Item { get{} }
	public Microsoft.Vsa.IVsaItem Item { get{} }
	public int Count { get{} }
}


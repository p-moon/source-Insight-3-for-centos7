public class MenuItemBindingCollection : System.Web.UI.StateManagedCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.Web.UI.IStateManager
{

	// Methods
	public int Add(MenuItemBinding binding) {}
	public bool Contains(MenuItemBinding binding) {}
	public void CopyTo(MenuItemBinding[] array, int index) {}
	public int IndexOf(MenuItemBinding value) {}
	public void Insert(int index, MenuItemBinding binding) {}
	public void Remove(MenuItemBinding binding) {}
	public void RemoveAt(int index) {}
	public void Clear() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public System.Collections.IEnumerator GetEnumerator() {}
	public void SetDirty() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MenuItemBinding Item { get{} set{} }
	public int Count { get{} }
}


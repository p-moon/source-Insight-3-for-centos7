public class TreeNodeBindingCollection : System.Web.UI.StateManagedCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.Web.UI.IStateManager
{

	// Methods
	public int Add(TreeNodeBinding binding) {}
	public bool Contains(TreeNodeBinding binding) {}
	public void CopyTo(TreeNodeBinding[] bindingArray, int index) {}
	public int IndexOf(TreeNodeBinding binding) {}
	public void Insert(int index, TreeNodeBinding binding) {}
	public void Remove(TreeNodeBinding binding) {}
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
	public TreeNodeBinding Item { get{} set{} }
	public int Count { get{} }
}


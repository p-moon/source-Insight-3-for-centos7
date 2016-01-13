public class TreeNodeCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public virtual TreeNode Add(string text) {}
	public virtual TreeNode Add(string key, string text) {}
	public virtual TreeNode Add(string key, string text, int imageIndex) {}
	public virtual TreeNode Add(string key, string text, string imageKey) {}
	public virtual TreeNode Add(string key, string text, int imageIndex, int selectedImageIndex) {}
	public virtual TreeNode Add(string key, string text, string imageKey, string selectedImageKey) {}
	public virtual void AddRange(TreeNode[] nodes) {}
	public TreeNode[] Find(string key, bool searchAllChildren) {}
	public virtual int Add(TreeNode node) {}
	public bool Contains(TreeNode node) {}
	public virtual bool ContainsKey(string key) {}
	public int IndexOf(TreeNode node) {}
	public virtual int IndexOfKey(string key) {}
	public virtual void Insert(int index, TreeNode node) {}
	public virtual TreeNode Insert(int index, string text) {}
	public virtual TreeNode Insert(int index, string key, string text) {}
	public virtual TreeNode Insert(int index, string key, string text, int imageIndex) {}
	public virtual TreeNode Insert(int index, string key, string text, string imageKey) {}
	public virtual TreeNode Insert(int index, string key, string text, int imageIndex, int selectedImageIndex) {}
	public virtual TreeNode Insert(int index, string key, string text, string imageKey, string selectedImageKey) {}
	public virtual void Clear() {}
	public virtual void CopyTo(System.Array dest, int index) {}
	public void Remove(TreeNode node) {}
	public virtual void RemoveAt(int index) {}
	public virtual void RemoveByKey(string key) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public TreeNode Item { get{} set{} }
	public TreeNode Item { get{} }
	public int Count { get{} }
	public bool IsReadOnly { get{} }
}


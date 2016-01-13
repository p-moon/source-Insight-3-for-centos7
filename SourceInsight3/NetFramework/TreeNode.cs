public class TreeNode : System.MarshalByRefObject, System.ICloneable, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public TreeNode(string text) {}
	public TreeNode(string text, TreeNode[] children) {}
	public TreeNode() {}
	public TreeNode(string text, int imageIndex, int selectedImageIndex) {}
	public TreeNode(string text, int imageIndex, int selectedImageIndex, TreeNode[] children) {}

	// Methods
	public static TreeNode FromHandle(TreeView tree, System.IntPtr handle) {}
	public void BeginEdit() {}
	public virtual object Clone() {}
	public void Collapse(bool ignoreChildren) {}
	public void Collapse() {}
	public void EndEdit(bool cancel) {}
	public void EnsureVisible() {}
	public void Expand() {}
	public void ExpandAll() {}
	public int GetNodeCount(bool includeSubTrees) {}
	public void Remove() {}
	public void Toggle() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Color BackColor { get{} set{} }
	public System.Drawing.Rectangle Bounds { get{} }
	public bool Checked { get{} set{} }
	public ContextMenu ContextMenu { get{} set{} }
	public ContextMenuStrip ContextMenuStrip { get{} set{} }
	public TreeNode FirstNode { get{} }
	public System.Drawing.Color ForeColor { get{} set{} }
	public string FullPath { get{} }
	public System.IntPtr Handle { get{} }
	public int ImageIndex { get{} set{} }
	public string ImageKey { get{} set{} }
	public int Index { get{} }
	public bool IsEditing { get{} }
	public bool IsExpanded { get{} }
	public bool IsSelected { get{} }
	public bool IsVisible { get{} }
	public TreeNode LastNode { get{} }
	public int Level { get{} }
	public TreeNode NextNode { get{} }
	public TreeNode NextVisibleNode { get{} }
	public System.Drawing.Font NodeFont { get{} set{} }
	public TreeNodeCollection Nodes { get{} }
	public TreeNode Parent { get{} }
	public TreeNode PrevNode { get{} }
	public TreeNode PrevVisibleNode { get{} }
	public int SelectedImageIndex { get{} set{} }
	public string SelectedImageKey { get{} set{} }
	public string StateImageKey { get{} set{} }
	public int StateImageIndex { get{} set{} }
	public object Tag { get{} set{} }
	public string Text { get{} set{} }
	public string ToolTipText { get{} set{} }
	public string Name { get{} set{} }
	public TreeView TreeView { get{} }
}


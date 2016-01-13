public class SelectorNode : System.Windows.Forms.TreeNode, System.ICloneable, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public SelectorNode(string label, object value) {}

	// Methods
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

	// Fields
	public object value;

	// Properties
	public System.Drawing.Color BackColor { get{} set{} }
	public System.Drawing.Rectangle Bounds { get{} }
	public bool Checked { get{} set{} }
	public System.Windows.Forms.ContextMenu ContextMenu { get{} set{} }
	public System.Windows.Forms.ContextMenuStrip ContextMenuStrip { get{} set{} }
	public System.Windows.Forms.TreeNode FirstNode { get{} }
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
	public System.Windows.Forms.TreeNode LastNode { get{} }
	public int Level { get{} }
	public System.Windows.Forms.TreeNode NextNode { get{} }
	public System.Windows.Forms.TreeNode NextVisibleNode { get{} }
	public System.Drawing.Font NodeFont { get{} set{} }
	public System.Windows.Forms.TreeNodeCollection Nodes { get{} }
	public System.Windows.Forms.TreeNode Parent { get{} }
	public System.Windows.Forms.TreeNode PrevNode { get{} }
	public System.Windows.Forms.TreeNode PrevVisibleNode { get{} }
	public int SelectedImageIndex { get{} set{} }
	public string SelectedImageKey { get{} set{} }
	public string StateImageKey { get{} set{} }
	public int StateImageIndex { get{} set{} }
	public object Tag { get{} set{} }
	public string Text { get{} set{} }
	public string ToolTipText { get{} set{} }
	public string Name { get{} set{} }
	public System.Windows.Forms.TreeView TreeView { get{} }
}


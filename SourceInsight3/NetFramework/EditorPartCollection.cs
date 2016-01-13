public class EditorPartCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public EditorPartCollection() {}
	public EditorPartCollection(System.Collections.ICollection editorParts) {}
	public EditorPartCollection(EditorPartCollection existingEditorParts, System.Collections.ICollection editorParts) {}

	// Methods
	public bool Contains(EditorPart editorPart) {}
	public void CopyTo(EditorPart[] array, int index) {}
	public int IndexOf(EditorPart editorPart) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public EditorPartCollection Empty;

	// Properties
	public EditorPart Item { get{} }
	public int Count { get{} }
}


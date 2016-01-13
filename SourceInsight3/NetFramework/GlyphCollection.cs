public class GlyphCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public GlyphCollection() {}
	public GlyphCollection(GlyphCollection value) {}
	public GlyphCollection(Glyph[] value) {}

	// Methods
	public int Add(Glyph value) {}
	public void AddRange(Glyph[] value) {}
	public void AddRange(GlyphCollection value) {}
	public bool Contains(Glyph value) {}
	public void CopyTo(Glyph[] array, int index) {}
	public int IndexOf(Glyph value) {}
	public void Insert(int index, Glyph value) {}
	public void Remove(Glyph value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Glyph Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}


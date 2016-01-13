public class DesignerOptionCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public int IndexOf(DesignerOptionCollection value) {}
	public bool ShowDialog() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public string Name { get{} }
	public DesignerOptionCollection Parent { get{} }
	public System.ComponentModel.PropertyDescriptorCollection Properties { get{} }
	public DesignerOptionCollection Item { get{} }
	public DesignerOptionCollection Item { get{} }
}


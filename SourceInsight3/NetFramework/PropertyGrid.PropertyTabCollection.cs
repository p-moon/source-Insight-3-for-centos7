public class PropertyTabCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public void AddTabType(Type propertyTabType) {}
	public void AddTabType(Type propertyTabType, System.ComponentModel.PropertyTabScope tabScope) {}
	public void Clear(System.ComponentModel.PropertyTabScope tabScope) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void RemoveTabType(Type propertyTabType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public System.Windows.Forms.Design.PropertyTab Item { get{} }
}


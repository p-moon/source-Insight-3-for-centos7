public class ListChangedEventArgs : System.EventArgs
{

	// Constructors
	public ListChangedEventArgs(ListChangedType listChangedType, int newIndex) {}
	public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc) {}
	public ListChangedEventArgs(ListChangedType listChangedType, PropertyDescriptor propDesc) {}
	public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, int oldIndex) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ListChangedType ListChangedType { get{} }
	public int NewIndex { get{} }
	public int OldIndex { get{} }
	public PropertyDescriptor PropertyDescriptor { get{} }
}


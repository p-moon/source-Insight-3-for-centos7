public class DesignSurfaceCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public System.Collections.IEnumerator GetEnumerator() {}
	public void CopyTo(DesignSurface[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public DesignSurface Item { get{} }
}


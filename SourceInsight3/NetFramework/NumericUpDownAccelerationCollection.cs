public class NumericUpDownAccelerationCollection : System.MarshalByRefObject, ICollection<System.Windows.Forms.NumericUpDownAcceleration>, IEnumerable<System.Windows.Forms.NumericUpDownAcceleration>, System.Collections.IEnumerable
{

	// Constructors
	public NumericUpDownAccelerationCollection() {}

	// Methods
	public virtual void Add(NumericUpDownAcceleration acceleration) {}
	public virtual void Clear() {}
	public virtual bool Contains(NumericUpDownAcceleration acceleration) {}
	public virtual void CopyTo(NumericUpDownAcceleration[] array, int index) {}
	public virtual bool Remove(NumericUpDownAcceleration acceleration) {}
	public void AddRange(NumericUpDownAcceleration[] accelerations) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public NumericUpDownAcceleration Item { get{} }
}


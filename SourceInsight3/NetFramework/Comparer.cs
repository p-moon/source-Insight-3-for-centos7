public class Comparer : IComparer, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public Comparer(System.Globalization.CultureInfo culture) {}

	// Methods
	public virtual int Compare(object a, object b) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public Comparer Default;
	public Comparer DefaultInvariant;
}


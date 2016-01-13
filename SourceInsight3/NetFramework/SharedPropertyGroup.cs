public class SharedPropertyGroup
{

	// Methods
	public SharedProperty CreatePropertyByPosition(int positionout , System.Boolean& fExists) {}
	public SharedProperty PropertyByPosition(int position) {}
	public SharedProperty CreateProperty(string nameout , System.Boolean& fExists) {}
	public SharedProperty Property(string name) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


public class CaseInsensitiveHashCodeProvider : IHashCodeProvider
{

	// Constructors
	public CaseInsensitiveHashCodeProvider() {}
	public CaseInsensitiveHashCodeProvider(System.Globalization.CultureInfo culture) {}

	// Methods
	public virtual int GetHashCode(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CaseInsensitiveHashCodeProvider Default { get{} }
	public CaseInsensitiveHashCodeProvider DefaultInvariant { get{} }
}


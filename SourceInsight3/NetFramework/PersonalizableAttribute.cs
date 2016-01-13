public class PersonalizableAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public PersonalizableAttribute() {}
	public PersonalizableAttribute(bool isPersonalizable) {}
	public PersonalizableAttribute(PersonalizationScope scope) {}
	public PersonalizableAttribute(PersonalizationScope scope, bool isSensitive) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public static System.Collections.ICollection GetPersonalizableProperties(Type type) {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public PersonalizableAttribute NotPersonalizable;
	public PersonalizableAttribute Personalizable;
	public PersonalizableAttribute UserPersonalizable;
	public PersonalizableAttribute SharedPersonalizable;
	public PersonalizableAttribute Default;

	// Properties
	public bool IsPersonalizable { get{} }
	public bool IsSensitive { get{} }
	public PersonalizationScope Scope { get{} }
	public object TypeId { get{} }
}


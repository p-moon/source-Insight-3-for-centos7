public class StackBehaviour : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, System.IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(System.IFormatProvider provider) {}
	public virtual System.TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public StackBehaviour Pop0;
	public StackBehaviour Pop1;
	public StackBehaviour Pop1_pop1;
	public StackBehaviour Popi;
	public StackBehaviour Popi_pop1;
	public StackBehaviour Popi_popi;
	public StackBehaviour Popi_popi8;
	public StackBehaviour Popi_popi_popi;
	public StackBehaviour Popi_popr4;
	public StackBehaviour Popi_popr8;
	public StackBehaviour Popref;
	public StackBehaviour Popref_pop1;
	public StackBehaviour Popref_popi;
	public StackBehaviour Popref_popi_popi;
	public StackBehaviour Popref_popi_popi8;
	public StackBehaviour Popref_popi_popr4;
	public StackBehaviour Popref_popi_popr8;
	public StackBehaviour Popref_popi_popref;
	public StackBehaviour Push0;
	public StackBehaviour Push1;
	public StackBehaviour Push1_push1;
	public StackBehaviour Pushi;
	public StackBehaviour Pushi8;
	public StackBehaviour Pushr4;
	public StackBehaviour Pushr8;
	public StackBehaviour Pushref;
	public StackBehaviour Varpop;
	public StackBehaviour Varpush;
	public StackBehaviour Popref_popi_pop1;
}


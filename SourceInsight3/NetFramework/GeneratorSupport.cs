public class GeneratorSupport : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public GeneratorSupport ArraysOfArrays;
	public GeneratorSupport EntryPointMethod;
	public GeneratorSupport GotoStatements;
	public GeneratorSupport MultidimensionalArrays;
	public GeneratorSupport StaticConstructors;
	public GeneratorSupport TryCatchStatements;
	public GeneratorSupport ReturnTypeAttributes;
	public GeneratorSupport DeclareValueTypes;
	public GeneratorSupport DeclareEnums;
	public GeneratorSupport DeclareDelegates;
	public GeneratorSupport DeclareInterfaces;
	public GeneratorSupport DeclareEvents;
	public GeneratorSupport AssemblyAttributes;
	public GeneratorSupport ParameterAttributes;
	public GeneratorSupport ReferenceParameters;
	public GeneratorSupport ChainedConstructorArguments;
	public GeneratorSupport NestedTypes;
	public GeneratorSupport MultipleInterfaceMembers;
	public GeneratorSupport PublicStaticMembers;
	public GeneratorSupport ComplexExpressions;
	public GeneratorSupport Win32Resources;
	public GeneratorSupport Resources;
	public GeneratorSupport PartialTypes;
	public GeneratorSupport GenericTypeReference;
	public GeneratorSupport GenericTypeDeclaration;
	public GeneratorSupport DeclareIndexerProperties;
}


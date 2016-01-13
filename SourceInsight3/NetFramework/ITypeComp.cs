public interface ITypeComp
{

	// Methods
	public abstract virtual void Bind(string szName, int lHashVal, short wFlagsout , ITypeInfo& ppTInfoout , DESCKIND& pDescKindout , BINDPTR& pBindPtr) {}
	public abstract virtual void BindType(string szName, int lHashValout , ITypeInfo& ppTInfoout , ITypeComp& ppTComp) {}
}


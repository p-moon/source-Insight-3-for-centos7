public interface UCOMITypeComp
{

	// Methods
	public abstract virtual void Bind(string szName, int lHashVal, short wFlagsout , UCOMITypeInfo& ppTInfoout , DESCKIND& pDescKindout , BINDPTR& pBindPtr) {}
	public abstract virtual void BindType(string szName, int lHashValout , UCOMITypeInfo& ppTInfoout , UCOMITypeComp& ppTComp) {}
}


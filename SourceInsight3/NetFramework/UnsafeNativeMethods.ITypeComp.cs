public interface ITypeComp
{

	// Methods
	public abstract virtual void RemoteBind(string szName, int lHashVal, short wFlagsout , ITypeInfo[] ppTInfoout , System.Runtime.InteropServices.ComTypes.DESCKIND[] pDescKindout , System.Runtime.InteropServices.ComTypes.FUNCDESC[] ppFuncDescout , System.Runtime.InteropServices.ComTypes.VARDESC[] ppVarDescout , ITypeComp[] ppTypeCompout , int[] pDummy) {}
	public abstract virtual void RemoteBindType(string szName, int lHashValout , ITypeInfo[] ppTInfo) {}
}


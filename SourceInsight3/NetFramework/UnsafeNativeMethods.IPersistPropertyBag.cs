public interface IPersistPropertyBag
{

	// Methods
	public abstract virtual void GetClassID(out System.Guid& pClassID) {}
	public abstract virtual void InitNew() {}
	public abstract virtual void Load(IPropertyBag pPropBag, IErrorLog pErrorLog) {}
	public abstract virtual void Save(IPropertyBag pPropBag, bool fClearDirty, bool fSaveAllProperties) {}
}


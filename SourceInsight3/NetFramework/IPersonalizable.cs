public interface IPersonalizable
{

	// Methods
	public abstract virtual void Load(PersonalizationDictionary state) {}
	public abstract virtual void Save(PersonalizationDictionary state) {}

	// Properties
	public bool IsDirty { get{} }
}


public interface IRemotingTypeInfo
{

	// Methods
	public abstract virtual bool CanCastTo(Type fromType, object o) {}

	// Properties
	public string TypeName { get{} set{} }
}


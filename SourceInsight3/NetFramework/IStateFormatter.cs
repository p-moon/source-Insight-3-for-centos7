public interface IStateFormatter
{

	// Methods
	public abstract virtual object Deserialize(string serializedState) {}
	public abstract virtual string Serialize(object state) {}
}


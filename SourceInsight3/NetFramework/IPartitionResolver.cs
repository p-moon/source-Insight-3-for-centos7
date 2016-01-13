public interface IPartitionResolver
{

	// Methods
	public abstract virtual void Initialize() {}
	public abstract virtual string ResolvePartition(object key) {}
}


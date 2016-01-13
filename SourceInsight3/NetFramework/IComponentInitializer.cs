public interface IComponentInitializer
{

	// Methods
	public abstract virtual void InitializeExistingComponent(System.Collections.IDictionary defaultValues) {}
	public abstract virtual void InitializeNewComponent(System.Collections.IDictionary defaultValues) {}
}


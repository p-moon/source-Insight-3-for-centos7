public interface IToolboxUser
{

	// Methods
	public abstract virtual bool GetToolSupported(ToolboxItem tool) {}
	public abstract virtual void ToolPicked(ToolboxItem tool) {}
}


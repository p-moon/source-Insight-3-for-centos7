public interface IControlDesignerTag
{

	// Methods
	public abstract virtual string GetAttribute(string name) {}
	public abstract virtual string GetContent() {}
	public abstract virtual void RemoveAttribute(string name) {}
	public abstract virtual void SetAttribute(string name, string value) {}
	public abstract virtual void SetContent(string content) {}
	public abstract virtual void SetDirty(bool dirty) {}
	public abstract virtual string GetOuterContent() {}

	// Properties
	public bool IsDirty { get{} }
}


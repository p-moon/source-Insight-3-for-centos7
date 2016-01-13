public interface IConfigurationSectionHandler
{

	// Methods
	public abstract virtual object Create(object parent, object configContext, System.Xml.XmlNode section) {}
}


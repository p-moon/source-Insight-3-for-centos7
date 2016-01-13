public interface ITypeLibImporterNotifySink
{

	// Methods
	public abstract virtual void ReportEvent(ImporterEventKind eventKind, int eventCode, string eventMsg) {}
	public abstract virtual System.Reflection.Assembly ResolveRef(object typeLib) {}
}


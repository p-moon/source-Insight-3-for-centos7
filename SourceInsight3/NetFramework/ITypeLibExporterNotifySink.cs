public interface ITypeLibExporterNotifySink
{

	// Methods
	public abstract virtual void ReportEvent(ExporterEventKind eventKind, int eventCode, string eventMsg) {}
	public abstract virtual object ResolveRef(System.Reflection.Assembly assembly) {}
}


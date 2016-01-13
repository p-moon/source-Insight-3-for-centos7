public class SystemEvents
{

	// Methods
	public static System.IntPtr CreateTimer(int interval) {}
	public static void InvokeOnEventsThread(System.Delegate method) {}
	public static void KillTimer(System.IntPtr timerId) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Events
	public event System.EventHandler DisplaySettingsChanging;
	public event System.EventHandler DisplaySettingsChanged;
	public event System.EventHandler EventsThreadShutdown;
	public event System.EventHandler InstalledFontsChanged;
	public event System.EventHandler LowMemory;
	public event System.EventHandler PaletteChanged;
	public event Microsoft.Win32.PowerModeChangedEventHandler PowerModeChanged;
	public event Microsoft.Win32.SessionEndedEventHandler SessionEnded;
	public event Microsoft.Win32.SessionEndingEventHandler SessionEnding;
	public event Microsoft.Win32.SessionSwitchEventHandler SessionSwitch;
	public event System.EventHandler TimeChanged;
	public event Microsoft.Win32.TimerElapsedEventHandler TimerElapsed;
	public event Microsoft.Win32.UserPreferenceChangedEventHandler UserPreferenceChanged;
	public event Microsoft.Win32.UserPreferenceChangingEventHandler UserPreferenceChanging;
}


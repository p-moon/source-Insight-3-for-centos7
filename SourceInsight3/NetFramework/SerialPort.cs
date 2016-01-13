public class SerialPort : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public SerialPort(System.ComponentModel.IContainer container) {}
	public SerialPort() {}
	public SerialPort(string portName) {}
	public SerialPort(string portName, int baudRate) {}
	public SerialPort(string portName, int baudRate, Parity parity) {}
	public SerialPort(string portName, int baudRate, Parity parity, int dataBits) {}
	public SerialPort(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits) {}

	// Methods
	public void Close() {}
	public void DiscardInBuffer() {}
	public void DiscardOutBuffer() {}
	public static string[] GetPortNames() {}
	public void Open() {}
	public int Read(byte[] buffer, int offset, int count) {}
	public int ReadChar() {}
	public int Read(char[] buffer, int offset, int count) {}
	public int ReadByte() {}
	public string ReadExisting() {}
	public string ReadLine() {}
	public string ReadTo(string value) {}
	public void Write(string text) {}
	public void Write(char[] buffer, int offset, int count) {}
	public void Write(byte[] buffer, int offset, int count) {}
	public void WriteLine(string text) {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int InfiniteTimeout;

	// Properties
	public System.IO.Stream BaseStream { get{} }
	public int BaudRate { get{} set{} }
	public bool BreakState { get{} set{} }
	public int BytesToWrite { get{} }
	public int BytesToRead { get{} }
	public bool CDHolding { get{} }
	public bool CtsHolding { get{} }
	public int DataBits { get{} set{} }
	public bool DiscardNull { get{} set{} }
	public bool DsrHolding { get{} }
	public bool DtrEnable { get{} set{} }
	public System.Text.Encoding Encoding { get{} set{} }
	public Handshake Handshake { get{} set{} }
	public bool IsOpen { get{} }
	public string NewLine { get{} set{} }
	public Parity Parity { get{} set{} }
	public byte ParityReplace { get{} set{} }
	public string PortName { get{} set{} }
	public int ReadBufferSize { get{} set{} }
	public int ReadTimeout { get{} set{} }
	public int ReceivedBytesThreshold { get{} set{} }
	public bool RtsEnable { get{} set{} }
	public StopBits StopBits { get{} set{} }
	public int WriteBufferSize { get{} set{} }
	public int WriteTimeout { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.IO.Ports.SerialErrorReceivedEventHandler ErrorReceived;
	public event System.IO.Ports.SerialPinChangedEventHandler PinChanged;
	public event System.IO.Ports.SerialDataReceivedEventHandler DataReceived;
	public event System.EventHandler Disposed;
}


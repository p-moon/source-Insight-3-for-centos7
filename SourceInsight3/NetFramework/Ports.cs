public class Ports
{

	// Constructors
	public Ports() {}

	// Methods
	public System.IO.Ports.SerialPort OpenSerialPort(string portName) {}
	public System.IO.Ports.SerialPort OpenSerialPort(string portName, int baudRate) {}
	public System.IO.Ports.SerialPort OpenSerialPort(string portName, int baudRate, System.IO.Ports.Parity parity) {}
	public System.IO.Ports.SerialPort OpenSerialPort(string portName, int baudRate, System.IO.Ports.Parity parity, int dataBits) {}
	public System.IO.Ports.SerialPort OpenSerialPort(string portName, int baudRate, System.IO.Ports.Parity parity, int dataBits, System.IO.Ports.StopBits stopBits) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ReadOnlyCollection<string> SerialPortNames { get{} }
}


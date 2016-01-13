public class Socket : System.IDisposable
{

	// Constructors
	public Socket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) {}
	public Socket(SocketInformation socketInformation) {}

	// Methods
	public void Bind(System.Net.EndPoint localEP) {}
	public void Connect(System.Net.EndPoint remoteEP) {}
	public void Connect(System.Net.IPAddress address, int port) {}
	public void Connect(string host, int port) {}
	public void Connect(System.Net.IPAddress[] addresses, int port) {}
	public void Close() {}
	public void Close(int timeout) {}
	public void Listen(int backlog) {}
	public Socket Accept() {}
	public int Send(byte[] buffer, int size, SocketFlags socketFlags) {}
	public int Send(byte[] buffer, SocketFlags socketFlags) {}
	public int Send(byte[] buffer) {}
	public int Send(IList<ArraySegment<byte>> buffers) {}
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) {}
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlagsout , SocketError& errorCode) {}
	public void SendFile(string fileName) {}
	public void SendFile(string fileName, byte[] preBuffer, byte[] postBuffer, TransmitFileOptions flags) {}
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags) {}
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlagsout , SocketError& errorCode) {}
	public int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, System.Net.EndPoint remoteEP) {}
	public int SendTo(byte[] buffer, int size, SocketFlags socketFlags, System.Net.EndPoint remoteEP) {}
	public int SendTo(byte[] buffer, SocketFlags socketFlags, System.Net.EndPoint remoteEP) {}
	public int SendTo(byte[] buffer, System.Net.EndPoint remoteEP) {}
	public int Receive(byte[] buffer, int size, SocketFlags socketFlags) {}
	public int Receive(byte[] buffer, SocketFlags socketFlags) {}
	public int Receive(byte[] buffer) {}
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags) {}
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlagsout , SocketError& errorCode) {}
	public int Receive(IList<ArraySegment<byte>> buffers) {}
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) {}
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlagsout , SocketError& errorCode) {}
	public int ReceiveMessageFrom(byte[] buffer, int offset, int size, SocketFlags& socketFlags, System.Net.EndPoint& remoteEPout , IPPacketInformation& ipPacketInformation) {}
	public int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, System.Net.EndPoint& remoteEP) {}
	public int ReceiveFrom(byte[] buffer, int size, SocketFlags socketFlags, System.Net.EndPoint& remoteEP) {}
	public int ReceiveFrom(byte[] buffer, SocketFlags socketFlags, System.Net.EndPoint& remoteEP) {}
	public int ReceiveFrom(byte[] buffer, System.Net.EndPoint& remoteEP) {}
	public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue) {}
	public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue) {}
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) {}
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue) {}
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, bool optionValue) {}
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, object optionValue) {}
	public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) {}
	public void GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue) {}
	public byte[] GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionLength) {}
	public bool Poll(int microSeconds, SelectMode mode) {}
	public static void Select(System.Collections.IList checkRead, System.Collections.IList checkWrite, System.Collections.IList checkError, int microSeconds) {}
	public System.IAsyncResult BeginSendFile(string fileName, System.AsyncCallback callback, object state) {}
	public System.IAsyncResult BeginConnect(System.Net.EndPoint remoteEP, System.AsyncCallback callback, object state) {}
	public SocketInformation DuplicateAndClose(int targetProcessId) {}
	public System.IAsyncResult BeginConnect(string host, int port, System.AsyncCallback requestCallback, object state) {}
	public System.IAsyncResult BeginConnect(System.Net.IPAddress address, int port, System.AsyncCallback requestCallback, object state) {}
	public System.IAsyncResult BeginConnect(System.Net.IPAddress[] addresses, int port, System.AsyncCallback requestCallback, object state) {}
	public System.IAsyncResult BeginDisconnect(bool reuseSocket, System.AsyncCallback callback, object state) {}
	public void Disconnect(bool reuseSocket) {}
	public void EndConnect(System.IAsyncResult asyncResult) {}
	public void EndDisconnect(System.IAsyncResult asyncResult) {}
	public System.IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, System.AsyncCallback callback, object state) {}
	public System.IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlagsout , SocketError& errorCode, System.AsyncCallback callback, object state) {}
	public System.IAsyncResult BeginSendFile(string fileName, byte[] preBuffer, byte[] postBuffer, TransmitFileOptions flags, System.AsyncCallback callback, object state) {}
	public System.IAsyncResult BeginSend(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, System.AsyncCallback callback, object state) {}
	public System.IAsyncResult BeginSend(IList<ArraySegment<byte>> buffers, SocketFlags socketFlagsout , SocketError& errorCode, System.AsyncCallback callback, object state) {}
	public int EndSend(System.IAsyncResult asyncResult) {}
	public int EndSend(System.IAsyncResult asyncResultout , SocketError& errorCode) {}
	public void EndSendFile(System.IAsyncResult asyncResult) {}
	public System.IAsyncResult BeginSendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, System.Net.EndPoint remoteEP, System.AsyncCallback callback, object state) {}
	public int EndSendTo(System.IAsyncResult asyncResult) {}
	public System.IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, System.AsyncCallback callback, object state) {}
	public System.IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlagsout , SocketError& errorCode, System.AsyncCallback callback, object state) {}
	public System.IAsyncResult BeginReceive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, System.AsyncCallback callback, object state) {}
	public System.IAsyncResult BeginReceive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlagsout , SocketError& errorCode, System.AsyncCallback callback, object state) {}
	public int EndReceive(System.IAsyncResult asyncResult) {}
	public int EndReceive(System.IAsyncResult asyncResultout , SocketError& errorCode) {}
	public System.IAsyncResult BeginReceiveMessageFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, System.Net.EndPoint& remoteEP, System.AsyncCallback callback, object state) {}
	public int EndReceiveMessageFrom(System.IAsyncResult asyncResult, SocketFlags& socketFlags, System.Net.EndPoint& endPointout , IPPacketInformation& ipPacketInformation) {}
	public System.IAsyncResult BeginReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, System.Net.EndPoint& remoteEP, System.AsyncCallback callback, object state) {}
	public int EndReceiveFrom(System.IAsyncResult asyncResult, System.Net.EndPoint& endPoint) {}
	public System.IAsyncResult BeginAccept(System.AsyncCallback callback, object state) {}
	public System.IAsyncResult BeginAccept(int receiveSize, System.AsyncCallback callback, object state) {}
	public System.IAsyncResult BeginAccept(Socket acceptSocket, int receiveSize, System.AsyncCallback callback, object state) {}
	public Socket EndAccept(System.IAsyncResult asyncResult) {}
	public Socket EndAccept(out System.Byte[]& buffer, System.IAsyncResult asyncResult) {}
	public Socket EndAccept(out System.Byte[]& bufferout , System.Int32& bytesTransferred, System.IAsyncResult asyncResult) {}
	public void Shutdown(SocketShutdown how) {}
	public bool AcceptAsync(SocketAsyncEventArgs e) {}
	public bool ConnectAsync(SocketAsyncEventArgs e) {}
	public bool DisconnectAsync(SocketAsyncEventArgs e) {}
	public bool ReceiveAsync(SocketAsyncEventArgs e) {}
	public bool ReceiveFromAsync(SocketAsyncEventArgs e) {}
	public bool ReceiveMessageFromAsync(SocketAsyncEventArgs e) {}
	public bool SendAsync(SocketAsyncEventArgs e) {}
	public bool SendPacketsAsync(SocketAsyncEventArgs e) {}
	public bool SendToAsync(SocketAsyncEventArgs e) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool SupportsIPv4 { get{} }
	public bool SupportsIPv6 { get{} }
	public bool OSSupportsIPv6 { get{} }
	public int Available { get{} }
	public System.Net.EndPoint LocalEndPoint { get{} }
	public System.Net.EndPoint RemoteEndPoint { get{} }
	public System.IntPtr Handle { get{} }
	public bool Blocking { get{} set{} }
	public bool UseOnlyOverlappedIO { get{} set{} }
	public bool Connected { get{} }
	public AddressFamily AddressFamily { get{} }
	public SocketType SocketType { get{} }
	public ProtocolType ProtocolType { get{} }
	public bool IsBound { get{} }
	public bool ExclusiveAddressUse { get{} set{} }
	public int ReceiveBufferSize { get{} set{} }
	public int SendBufferSize { get{} set{} }
	public int ReceiveTimeout { get{} set{} }
	public int SendTimeout { get{} set{} }
	public LingerOption LingerState { get{} set{} }
	public bool NoDelay { get{} set{} }
	public short Ttl { get{} set{} }
	public bool DontFragment { get{} set{} }
	public bool MulticastLoopback { get{} set{} }
	public bool EnableBroadcast { get{} set{} }
}


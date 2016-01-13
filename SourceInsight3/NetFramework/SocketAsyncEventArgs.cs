public class SocketAsyncEventArgs : System.EventArgs, System.IDisposable
{

	// Constructors
	public SocketAsyncEventArgs() {}

	// Methods
	public void SetBuffer(byte[] buffer, int offset, int count) {}
	public void SetBuffer(int offset, int count) {}
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Socket AcceptSocket { get{} set{} }
	public byte[] Buffer { get{} }
	public int Offset { get{} }
	public int Count { get{} }
	public IList<ArraySegment<byte>> BufferList { get{} set{} }
	public int BytesTransferred { get{} }
	public bool DisconnectReuseSocket { get{} set{} }
	public SocketAsyncOperation LastOperation { get{} }
	public IPPacketInformation ReceiveMessageFromPacketInfo { get{} }
	public System.Net.EndPoint RemoteEndPoint { get{} set{} }
	public SendPacketsElement[] SendPacketsElements { get{} set{} }
	public TransmitFileOptions SendPacketsFlags { get{} set{} }
	public int SendPacketsSendSize { get{} set{} }
	public SocketError SocketError { get{} set{} }
	public SocketFlags SocketFlags { get{} set{} }
	public object UserToken { get{} set{} }

	// Events
	public event System.EventHandler`1[System.Net.Sockets.SocketAsyncEventArgs] Completed;
}


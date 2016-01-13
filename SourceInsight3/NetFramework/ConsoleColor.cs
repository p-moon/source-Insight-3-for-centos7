public class ConsoleColor : Enum, IComparable, IFormattable, IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(IFormatProvider provider) {}
	public virtual TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public ConsoleColor Black;
	public ConsoleColor DarkBlue;
	public ConsoleColor DarkGreen;
	public ConsoleColor DarkCyan;
	public ConsoleColor DarkRed;
	public ConsoleColor DarkMagenta;
	public ConsoleColor DarkYellow;
	public ConsoleColor Gray;
	public ConsoleColor DarkGray;
	public ConsoleColor Blue;
	public ConsoleColor Green;
	public ConsoleColor Cyan;
	public ConsoleColor Red;
	public ConsoleColor Magenta;
	public ConsoleColor Yellow;
	public ConsoleColor White;
}


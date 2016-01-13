public interface ICustomFormatter
{

	// Methods
	public abstract virtual string Format(string format, object arg, IFormatProvider formatProvider) {}
}


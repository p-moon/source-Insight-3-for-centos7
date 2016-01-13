public class Random
{

	// Constructors
	public Random() {}
	public Random(int Seed) {}

	// Methods
	public virtual int Next() {}
	public virtual int Next(int minValue, int maxValue) {}
	public virtual int Next(int maxValue) {}
	public virtual double NextDouble() {}
	public virtual void NextBytes(byte[] buffer) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


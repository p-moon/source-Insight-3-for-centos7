public class Financial
{

	// Methods
	public static double DDB(double Cost, double Salvage, double Life, double Period, double Factor) {}
	public static double FV(double Rate, double NPer, double Pmt, double PV, DueDate Due) {}
	public static double IPmt(double Rate, double Per, double NPer, double PV, double FV, DueDate Due) {}
	public static double IRR(System.Double[]& ValueArray, double Guess) {}
	public static double MIRR(System.Double[]& ValueArray, double FinanceRate, double ReinvestRate) {}
	public static double NPer(double Rate, double Pmt, double PV, double FV, DueDate Due) {}
	public static double NPV(double Rate, System.Double[]& ValueArray) {}
	public static double Pmt(double Rate, double NPer, double PV, double FV, DueDate Due) {}
	public static double PPmt(double Rate, double Per, double NPer, double PV, double FV, DueDate Due) {}
	public static double PV(double Rate, double NPer, double Pmt, double FV, DueDate Due) {}
	public static double Rate(double NPer, double Pmt, double PV, double FV, DueDate Due, double Guess) {}
	public static double SLN(double Cost, double Salvage, double Life) {}
	public static double SYD(double Cost, double Salvage, double Life, double Period) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


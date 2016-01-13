public class CmdLineError : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, System.IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(System.IFormatProvider provider) {}
	public virtual System.TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public CmdLineError NoError;
	public CmdLineError AssemblyNotFound;
	public CmdLineError CannotCreateEngine;
	public CmdLineError CompilerConstant;
	public CmdLineError DuplicateFileAsSourceAndAssembly;
	public CmdLineError DuplicateResourceFile;
	public CmdLineError DuplicateResourceName;
	public CmdLineError DuplicateSourceFile;
	public CmdLineError ErrorSavingCompiledState;
	public CmdLineError IncompatibleTargets;
	public CmdLineError InvalidAssembly;
	public CmdLineError InvalidCharacters;
	public CmdLineError InvalidCodePage;
	public CmdLineError InvalidDefinition;
	public CmdLineError InvalidForCompilerOptions;
	public CmdLineError InvalidLocaleID;
	public CmdLineError InvalidPlatform;
	public CmdLineError InvalidTarget;
	public CmdLineError InvalidSourceFile;
	public CmdLineError InvalidVersion;
	public CmdLineError InvalidWarningLevel;
	public CmdLineError ManagedResourceNotFound;
	public CmdLineError MissingDefineArgument;
	public CmdLineError MissingExtension;
	public CmdLineError MissingLibArgument;
	public CmdLineError MissingReference;
	public CmdLineError MissingVersionInfo;
	public CmdLineError MultipleOutputNames;
	public CmdLineError MultipleTargets;
	public CmdLineError MultipleWin32Resources;
	public CmdLineError NestedResponseFiles;
	public CmdLineError NoCodePage;
	public CmdLineError NoFileName;
	public CmdLineError NoInputSourcesSpecified;
	public CmdLineError NoLocaleID;
	public CmdLineError NoWarningLevel;
	public CmdLineError ResourceNotFound;
	public CmdLineError SourceFileTooBig;
	public CmdLineError SourceNotFound;
	public CmdLineError UnknownOption;
	public CmdLineError Unspecified;
	public CmdLineError LAST;
}


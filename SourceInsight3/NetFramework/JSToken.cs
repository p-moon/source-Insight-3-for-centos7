public class JSToken : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public JSToken None;
	public JSToken EndOfFile;
	public JSToken If;
	public JSToken For;
	public JSToken Do;
	public JSToken While;
	public JSToken Continue;
	public JSToken Break;
	public JSToken Return;
	public JSToken Import;
	public JSToken With;
	public JSToken Switch;
	public JSToken Throw;
	public JSToken Try;
	public JSToken Package;
	public JSToken Internal;
	public JSToken Abstract;
	public JSToken Public;
	public JSToken Static;
	public JSToken Private;
	public JSToken Protected;
	public JSToken Final;
	public JSToken Event;
	public JSToken Var;
	public JSToken Const;
	public JSToken Class;
	public JSToken Function;
	public JSToken LeftCurly;
	public JSToken Semicolon;
	public JSToken Null;
	public JSToken True;
	public JSToken False;
	public JSToken This;
	public JSToken Identifier;
	public JSToken StringLiteral;
	public JSToken IntegerLiteral;
	public JSToken NumericLiteral;
	public JSToken LeftParen;
	public JSToken LeftBracket;
	public JSToken AccessField;
	public JSToken FirstOp;
	public JSToken LogicalNot;
	public JSToken BitwiseNot;
	public JSToken Delete;
	public JSToken Void;
	public JSToken Typeof;
	public JSToken Increment;
	public JSToken Decrement;
	public JSToken FirstBinaryOp;
	public JSToken Plus;
	public JSToken Minus;
	public JSToken LogicalOr;
	public JSToken LogicalAnd;
	public JSToken BitwiseOr;
	public JSToken BitwiseXor;
	public JSToken BitwiseAnd;
	public JSToken Equal;
	public JSToken NotEqual;
	public JSToken StrictEqual;
	public JSToken StrictNotEqual;
	public JSToken GreaterThan;
	public JSToken LessThan;
	public JSToken LessThanEqual;
	public JSToken GreaterThanEqual;
	public JSToken LeftShift;
	public JSToken RightShift;
	public JSToken UnsignedRightShift;
	public JSToken Multiply;
	public JSToken Divide;
	public JSToken Modulo;
	public JSToken LastPPOperator;
	public JSToken Instanceof;
	public JSToken In;
	public JSToken Assign;
	public JSToken PlusAssign;
	public JSToken MinusAssign;
	public JSToken MultiplyAssign;
	public JSToken DivideAssign;
	public JSToken BitwiseAndAssign;
	public JSToken BitwiseOrAssign;
	public JSToken BitwiseXorAssign;
	public JSToken ModuloAssign;
	public JSToken LeftShiftAssign;
	public JSToken RightShiftAssign;
	public JSToken UnsignedRightShiftAssign;
	public JSToken LastAssign;
	public JSToken LastBinaryOp;
	public JSToken ConditionalIf;
	public JSToken Colon;
	public JSToken Comma;
	public JSToken LastOp;
	public JSToken Case;
	public JSToken Catch;
	public JSToken Debugger;
	public JSToken Default;
	public JSToken Else;
	public JSToken Export;
	public JSToken Extends;
	public JSToken Finally;
	public JSToken Get;
	public JSToken Implements;
	public JSToken Interface;
	public JSToken New;
	public JSToken Set;
	public JSToken Super;
	public JSToken RightParen;
	public JSToken RightCurly;
	public JSToken RightBracket;
	public JSToken PreProcessorConstant;
	public JSToken Comment;
	public JSToken UnterminatedComment;
	public JSToken Assert;
	public JSToken Boolean;
	public JSToken Byte;
	public JSToken Char;
	public JSToken Decimal;
	public JSToken Double;
	public JSToken DoubleColon;
	public JSToken Enum;
	public JSToken Ensure;
	public JSToken Float;
	public JSToken Goto;
	public JSToken Int;
	public JSToken Invariant;
	public JSToken Long;
	public JSToken Namespace;
	public JSToken Native;
	public JSToken Require;
	public JSToken Sbyte;
	public JSToken Short;
	public JSToken Synchronized;
	public JSToken Transient;
	public JSToken Throws;
	public JSToken ParamArray;
	public JSToken Volatile;
	public JSToken Ushort;
	public JSToken Uint;
	public JSToken Ulong;
	public JSToken Use;
	public JSToken EndOfLine;
	public JSToken PreProcessDirective;
}


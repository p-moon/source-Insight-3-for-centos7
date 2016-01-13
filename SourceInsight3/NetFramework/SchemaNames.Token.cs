public class Token : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public Token Empty;
	public Token SchemaName;
	public Token SchemaType;
	public Token SchemaMaxOccurs;
	public Token SchemaMinOccurs;
	public Token SchemaInfinite;
	public Token SchemaModel;
	public Token SchemaOpen;
	public Token SchemaClosed;
	public Token SchemaContent;
	public Token SchemaMixed;
	public Token SchemaEmpty;
	public Token SchemaElementOnly;
	public Token SchemaTextOnly;
	public Token SchemaOrder;
	public Token SchemaSeq;
	public Token SchemaOne;
	public Token SchemaMany;
	public Token SchemaRequired;
	public Token SchemaYes;
	public Token SchemaNo;
	public Token SchemaString;
	public Token SchemaId;
	public Token SchemaIdref;
	public Token SchemaIdrefs;
	public Token SchemaEntity;
	public Token SchemaEntities;
	public Token SchemaNmtoken;
	public Token SchemaNmtokens;
	public Token SchemaEnumeration;
	public Token SchemaDefault;
	public Token XdrRoot;
	public Token XdrElementType;
	public Token XdrElement;
	public Token XdrGroup;
	public Token XdrAttributeType;
	public Token XdrAttribute;
	public Token XdrDatatype;
	public Token XdrDescription;
	public Token XdrExtends;
	public Token SchemaXdrRootAlias;
	public Token SchemaDtType;
	public Token SchemaDtValues;
	public Token SchemaDtMaxLength;
	public Token SchemaDtMinLength;
	public Token SchemaDtMax;
	public Token SchemaDtMin;
	public Token SchemaDtMinExclusive;
	public Token SchemaDtMaxExclusive;
	public Token SchemaTargetNamespace;
	public Token SchemaVersion;
	public Token SchemaFinalDefault;
	public Token SchemaBlockDefault;
	public Token SchemaFixed;
	public Token SchemaAbstract;
	public Token SchemaBlock;
	public Token SchemaSubstitutionGroup;
	public Token SchemaFinal;
	public Token SchemaNillable;
	public Token SchemaRef;
	public Token SchemaBase;
	public Token SchemaDerivedBy;
	public Token SchemaNamespace;
	public Token SchemaProcessContents;
	public Token SchemaRefer;
	public Token SchemaPublic;
	public Token SchemaSystem;
	public Token SchemaSchemaLocation;
	public Token SchemaValue;
	public Token SchemaSource;
	public Token SchemaAttributeFormDefault;
	public Token SchemaElementFormDefault;
	public Token SchemaUse;
	public Token SchemaForm;
	public Token XsdSchema;
	public Token XsdAnnotation;
	public Token XsdInclude;
	public Token XsdImport;
	public Token XsdElement;
	public Token XsdAttribute;
	public Token xsdAttributeGroup;
	public Token XsdAnyAttribute;
	public Token XsdGroup;
	public Token XsdAll;
	public Token XsdChoice;
	public Token XsdSequence;
	public Token XsdAny;
	public Token XsdNotation;
	public Token XsdSimpleType;
	public Token XsdComplexType;
	public Token XsdUnique;
	public Token XsdKey;
	public Token XsdKeyref;
	public Token XsdSelector;
	public Token XsdField;
	public Token XsdMinExclusive;
	public Token XsdMinInclusive;
	public Token XsdMaxExclusive;
	public Token XsdMaxInclusive;
	public Token XsdTotalDigits;
	public Token XsdFractionDigits;
	public Token XsdLength;
	public Token XsdMinLength;
	public Token XsdMaxLength;
	public Token XsdEnumeration;
	public Token XsdPattern;
	public Token XsdDocumentation;
	public Token XsdAppInfo;
	public Token XsdComplexContent;
	public Token XsdComplexContentExtension;
	public Token XsdComplexContentRestriction;
	public Token XsdSimpleContent;
	public Token XsdSimpleContentExtension;
	public Token XsdSimpleContentRestriction;
	public Token XsdSimpleTypeList;
	public Token XsdSimpleTypeRestriction;
	public Token XsdSimpleTypeUnion;
	public Token XsdWhitespace;
	public Token XsdRedefine;
	public Token SchemaItemType;
	public Token SchemaMemberTypes;
	public Token SchemaXPath;
	public Token XmlLang;
}


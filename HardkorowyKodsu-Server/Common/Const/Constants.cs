﻿namespace HardkorowyKodsu_Server.Common.Const
{
    public class Constants
    {
        public const string SysTablesName = "sys.tables";
        public const string SysViewsName = "sys.views";
        public const string SysColumnsName = "sys.columns";
        public const string SysSchemasName = "sys.schemas";
        public const string SysDataTypesName = "sys.types";

        public const string SysTablesObjectIdName = "object_id";
        public const string SysTablesNameName = "name";
        public const string SysTablesSchemaIdName = "schema_id";
        public const string SysTablesSchemaNameCustom = "schema_name";
        public const string SysTablesTypeName = "type";
        public const string SysTablesTypeDescName = "type_desc";
        public const string SysTablesIsPublishedName = "is_published";
        public const string SysTablesIsSchemaPublishedName = "is_schema_published";
        public const string SysTablesCreateDateName = "create_date";
        public const string SysTablesModifyDateName = "modify_date";

        public const string SysTablesColumnIdName = "column_id";
        public const string SysTablesSystemDataTypeIdName = "system_type_id";
        public const string SysTablesUserDataTypeIdName = "user_type_id";

        public const string SysColumnsMaxLengthName = "max_length";
        public const string SysColumnsIsNullableName = "is_nullable";
        public const string SysColumnsIsIdentityName = "is_identity";
        public const string SysColumnsIsPrimaryKeyName = "is_primary_key";
        public const string SysColumnsOrdinalPositionName = "ordinal_position";
        public const string SysColumnsDefaultValueName = "default_value";
        public const string SysColumnsParentObjectIdName = "object_id";

        public const string SysDataTypesIsNullableName = SysColumnsIsNullableName;
        public const string SysDataTypesMaxLengthName = "max_length";
        public const string SysDataTypesPrecisionName = "precision";
        public const string SysDataTypesScaleName = "scale";
        public const string SysDataTypesIsUserDefinedName = "is_user_defined";

        public const string SysColumnsColumnIdName = "column_id";

        public const char TableMarker = 'U';
        public const char ViewMarker = 'V';
    }
}

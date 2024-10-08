using RoughDataWebApi.apis.Models;

namespace RoughDataWebApi.apis.Dtos
{
    public class TableDto
    {
        public long COL_1_LONG_PK { get; set; }
        public long? COL_2_LONG_NULL { get; set; } // Nullable
        public string COL_3_STRNG { get; set; } = "ANYTHING-DEFAULT-VALUE";
        public string? COL_4_STRNG_NULL { get; set; } // Nullable
        public int COL_5_INT { get; set; }
        public int? COL_6_INT_NULL { get; set; } // Nullable
        public decimal COL_7_DECIMAL { get; set; }
        public decimal? COL_8_DECIMAL_NULL { get; set; } // Nullable
        public bool? COL_9_BOOL_NULL { get; set; } // Nullable
        public DateTime COL_10_DATE { get; set; } = DateTime.Now; // Non-nullable

        // Constructor to initialize from TableModel entity
        public TableDto(TableModel tableObj)
        {
            COL_1_LONG_PK = tableObj.COL_1_LONG_PK;
            COL_2_LONG_NULL = tableObj.COL_2_LONG_NULL;
            COL_3_STRNG = tableObj.COL_3_STRNG;
            COL_4_STRNG_NULL = tableObj.COL_4_STRNG_NULL;
            COL_5_INT = tableObj.COL_5_INT;
            COL_7_DECIMAL = tableObj.COL_7_DECIMAL;
            COL_8_DECIMAL_NULL = tableObj.COL_8_DECIMAL_NULL;
            COL_6_INT_NULL = tableObj.COL_6_INT_NULL;
            COL_9_BOOL_NULL = tableObj.COL_9_BOOL_NULL;
            COL_10_DATE = tableObj.COL_10_DATE;
        }
    }
}
using System.ComponentModel.DataAnnotations;

namespace RoughDataWebApi.apis.Models
{
    public class TableModel
    {
        [Key]
        public long COL_1_LONG_PK { get; set; }
        public string COL_3_STRNG { get; set; } = string.Empty;
        public int COL_5_INT { get; set; }
        public int TGD_STONES { get; set; }
        public decimal COL_7_DECIMAL { get; set; }
        public string TGD_AQP { get; set; } = string.Empty;
        public decimal TGD_PRICEM { get; set; }
        public decimal TGD_PRICEE { get; set; }
        public decimal TGD_PRICEL { get; set; }
        public string? COL_4_STRNG_NULL { get; set; } // Nullable
        public string? TGD_TYPE { get; set; } // Nullable
        public string TGD_SHAPE { get; set; } = string.Empty; // Non-nullable
        public string? TGD_MAKE { get; set; } // Nullable
        public decimal? COL_8_DECIMAL_NULL { get; set; } // Nullable
        public decimal? TGD_MEASU2 { get; set; } // Nullable
        public decimal? TGD_MEASU3 { get; set; } // Nullable
        public decimal? TGD_TOTDEP { get; set; } // Nullable
        public int? COL_6_INT_NULL { get; set; } // Nullable
        public int? TGD_CRHEIG { get; set; } // Nullable
        public string? TGD_GIRDLE { get; set; } // Nullable
        public string? TGD_GIRDL2 { get; set; } // Nullable
        public bool? COL_9_BOOL_NULL { get; set; } // Nullable
        public string? TGD_LAB { get; set; } // Nullable
        public long? COL_2_LONG_NULL { get; set; } // Nullable
        public string? TGD_COLOR { get; set; } // Nullable
        public string? TGD_CLARIT { get; set; } // Nullable
        public string? TGD_POLISH { get; set; } // Nullable
        public string? TGD_SYMMET { get; set; } // Nullable
        public string? TGD_FLUORE { get; set; } // Nullable
        public string? TGD_LABELC { get; set; } // Nullable
        public string? TGD_SHAPE1 { get; set; } // Nullable
        public string? TGD_SHAPE2 { get; set; } // Nullable
        public string? TGD_SHAPE3 { get; set; } // Nullable
        public string? TGD_SHAPE4 { get; set; } // Nullable
        public string? TGD_MAKEFR { get; set; } // Nullable
        public string? TGD_MAKETO { get; set; } // Nullable
        public string? TGD_COLORF { get; set; } // Nullable
        public string? TGD_COLORT { get; set; } // Nullable
        public string? TGD_CLARI2 { get; set; } // Nullable
        public string? TGD_CLARI3 { get; set; } // Nullable
        public string? TGD_COLORE { get; set; } // Nullable
        public string? TGD_INFO { get; set; } // Nullable
        public bool? TGD_ATOMIC { get; set; } // Nullable
        public string? TGD_CULET { get; set; } // Nullable
        public long? TGD_REF { get; set; } // Nullable
        public DateTime COL_10_DATE { get; set; } = DateTime.Now; // Non-nullable
        public string? TGD_APPRAI { get; set; } // Nullable
        public long? TGD_CERTPK { get; set; } // Nullable
        public string? TGD_CUT { get; set; } // Nullable
        public string? TGD_STATUS { get; set; } // Nullable
    }
}
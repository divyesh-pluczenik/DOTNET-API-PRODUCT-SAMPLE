using System.ComponentModel.DataAnnotations;

namespace RoughDataWebApi.apis.Models
{
    public class Goods
    {
        [Key]
        public long TGD_PK { get; set; }
        public string TGD_DOCNR { get; set; } = string.Empty;
        public int TGD_PNR { get; set; }
        public int TGD_STONES { get; set; }
        public decimal TGD_WEIGHT { get; set; }
        public string TGD_AQP { get; set; } = string.Empty;
        public decimal TGD_PRICEM { get; set; }
        public decimal TGD_PRICEE { get; set; }
        public decimal TGD_PRICEL { get; set; }
        public string? TGD_ORDER { get; set; } // Nullable
        public string? TGD_TYPE { get; set; } // Nullable
        public string TGD_SHAPE { get; set; } = string.Empty; // Non-nullable
        public string? TGD_MAKE { get; set; } // Nullable
        public decimal? TGD_MEASUR { get; set; } // Nullable
        public decimal? TGD_MEASU2 { get; set; } // Nullable
        public decimal? TGD_MEASU3 { get; set; } // Nullable
        public decimal? TGD_TOTDEP { get; set; } // Nullable
        public int? TGD_TABLEW { get; set; } // Nullable
        public int? TGD_CRHEIG { get; set; } // Nullable
        public string? TGD_GIRDLE { get; set; } // Nullable
        public string? TGD_GIRDL2 { get; set; } // Nullable
        public bool? TGD_DRILLE { get; set; } // Nullable
        public string? TGD_LAB { get; set; } // Nullable
        public long? TGD_CERTNR { get; set; } // Nullable
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
        public DateTime TGD_CERTDA { get; set; } = DateTime.Now; // Non-nullable
        public string? TGD_APPRAI { get; set; } // Nullable
        public long? TGD_CERTPK { get; set; } // Nullable
        public string? TGD_CUT { get; set; } // Nullable
        public string? TGD_STATUS { get; set; } // Nullable
    }
}
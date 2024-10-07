using System.ComponentModel.DataAnnotations;

namespace RoughDataWebApi.apis.Models
{
    public class Goods
    {
        [Key]
        public long TGD_PK { get; set; }
        public int TGD_DOCNR { get; set; }
        public int TGD_PNR { get; set; }
        public int TGD_STONES { get; set; }
        public decimal TGD_WEIGHT { get; set; }
        public string TGD_AQP { get; set; }
        public decimal TGD_PRICEM { get; set; }
        public decimal TGD_PRICEE { get; set; }
        public decimal TGD_PRICEL { get; set; }
        public string TGD_ORDER { get; set; }
        public string TGD_TYPE { get; set; }
        public string TGD_SHAPE { get; set; }
        public string TGD_MAKE { get; set; }
        public decimal TGD_MEASUR { get; set; }
        public decimal TGD_MEASU2 { get; set; }
        public decimal TGD_MEASU3 { get; set; }
        public decimal TGD_TOTDEP { get; set; }
        public int TGD_TABLEW { get; set; }
        public int TGD_CRHEIG { get; set; }
        public string TGD_GIRDLE { get; set; }
        public string TGD_GIRDL2 { get; set; }
        public bool TGD_DRILLE { get; set; }
        public string TGD_LAB { get; set; }
        public long TGD_CERTNR { get; set; }
        public string TGD_COLOR { get; set; }
        public string TGD_CLARIT { get; set; }
        public string TGD_POLISH { get; set; }
        public string TGD_SYMMET { get; set; }
        public string TGD_FLUORE { get; set; }
        public string TGD_LABELC { get; set; }
        public string TGD_SHAPE1 { get; set; }
        public string TGD_SHAPE2 { get; set; }
        public string TGD_SHAPE3 { get; set; }
        public string TGD_SHAPE4 { get; set; }
        public string TGD_MAKEFR { get; set; }
        public string TGD_MAKETO { get; set; }
        public string TGD_COLORF { get; set; }
        public string TGD_COLORT { get; set; }
        public string TGD_CLARI2 { get; set; }
        public string TGD_CLARI3 { get; set; }
        public string TGD_COLORE { get; set; }
        public string TGD_INFO { get; set; }
        public bool TGD_ATOMIC { get; set; }
        public string TGD_CULET { get; set; }
        public long TGD_REF { get; set; }
        public DateTime TGD_CERTDA { get; set; }
        public string TGD_APPRAI { get; set; }
        public long TGD_CERTPK { get; set; }
        public string TGD_CUT { get; set; }
        public string TGD_STATUS { get; set; } // Include this if it's in the database
    }
}

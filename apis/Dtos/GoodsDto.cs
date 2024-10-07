using RoughDataWebApi.apis.Models;

namespace RoughDataWebApi.apis.Dtos
{
    public class GoodsDto
    {
        public long TGD_PK { get; set; }
        public int TGD_DOCNR { get; set; }
        public int TGD_PNR { get; set; }
        public int TGD_STONES { get; set; }
        public decimal TGD_WEIGHT { get; set; }
        public string TGD_AQP { get; set; }
        public decimal TGD_PRICEM { get; set; }
        public decimal TGD_PRICEE { get; set; }
        public decimal TGD_PRICEL { get; set; }
        public string TGD_ORDER { get; set; } = string.Empty;   
        public string TGD_TYPE { get; set; } = string.Empty;    
        public string TGD_SHAPE { get; set; }
        public string TGD_MAKE { get; set; } = string.Empty;    
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
        public string TGD_MAKEFR { get; set; } = string.Empty;  
        public string TGD_MAKETO { get; set; } = string.Empty;  
        public string TGD_COLORF { get; set; }
        public string TGD_COLORT { get; set; }
        public string TGD_CLARI2 { get; set; }
        public string TGD_CLARI3 { get; set; }
        public string TGD_COLORE { get; set; } = string.Empty;  
        public string TGD_INFO { get; set; }
        public bool TGD_ATOMIC { get; set; }
        public string TGD_CULET { get; set; }
        public long TGD_REF { get; set; }
        public DateTime TGD_CERTDA { get; set; } = DateTime.Now;
        public string TGD_APPRAI { get; set; }
        public long TGD_CERTPK { get; set; }
        public string TGD_CUT { get; set; } = string.Empty; 
        public string TGD_STATUS { get; set; } = string.Empty;

        // Constructor to initialize from Goods entity
        public GoodsDto(Goods goods)
        {
            TGD_PK = goods.TGD_PK;
            TGD_DOCNR = goods.TGD_DOCNR;
            TGD_PNR = goods.TGD_PNR;
            TGD_STONES = goods.TGD_STONES;
            TGD_WEIGHT = goods.TGD_WEIGHT;
            TGD_AQP = goods.TGD_AQP;
            TGD_PRICEM = goods.TGD_PRICEM;
            TGD_PRICEE = goods.TGD_PRICEE;
            TGD_PRICEL = goods.TGD_PRICEL;
            TGD_ORDER = goods.TGD_ORDER;
            TGD_TYPE = goods.TGD_TYPE;
            TGD_SHAPE = goods.TGD_SHAPE;
            TGD_MAKE = goods.TGD_MAKE;
            TGD_MEASUR = goods.TGD_MEASUR;
            TGD_MEASU2 = goods.TGD_MEASU2;
            TGD_MEASU3 = goods.TGD_MEASU3;
            TGD_TOTDEP = goods.TGD_TOTDEP;
            TGD_TABLEW = goods.TGD_TABLEW;
            TGD_CRHEIG = goods.TGD_CRHEIG;
            TGD_GIRDLE = goods.TGD_GIRDLE;
            TGD_GIRDL2 = goods.TGD_GIRDL2;
            TGD_DRILLE = goods.TGD_DRILLE;
            TGD_LAB = goods.TGD_LAB;
            TGD_CERTNR = goods.TGD_CERTNR;
            TGD_COLOR = goods.TGD_COLOR;
            TGD_CLARIT = goods.TGD_CLARIT;
            TGD_POLISH = goods.TGD_POLISH;
            TGD_SYMMET = goods.TGD_SYMMET;
            TGD_FLUORE = goods.TGD_FLUORE;
            TGD_LABELC = goods.TGD_LABELC;
            TGD_SHAPE1 = goods.TGD_SHAPE1;
            TGD_SHAPE2 = goods.TGD_SHAPE2;
            TGD_SHAPE3 = goods.TGD_SHAPE3;
            TGD_SHAPE4 = goods.TGD_SHAPE4;
            TGD_MAKEFR = goods.TGD_MAKEFR;
            TGD_MAKETO = goods.TGD_MAKETO;
            TGD_COLORF = goods.TGD_COLORF;
            TGD_COLORT = goods.TGD_COLORT;
            TGD_CLARI2 = goods.TGD_CLARI2;
            TGD_CLARI3 = goods.TGD_CLARI3;
            TGD_COLORE = goods.TGD_COLORE;
            TGD_INFO = goods.TGD_INFO;
            TGD_ATOMIC = goods.TGD_ATOMIC;
            TGD_CULET = goods.TGD_CULET;
            TGD_REF = goods.TGD_REF;
            TGD_CERTDA = goods.TGD_CERTDA;
            TGD_APPRAI = goods.TGD_APPRAI;
            TGD_CERTPK = goods.TGD_CERTPK;
            TGD_CUT = goods.TGD_CUT;
            TGD_STATUS = goods.TGD_STATUS;
        }
    }
}

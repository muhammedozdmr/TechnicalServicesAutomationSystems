//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeknikServisOtomasyon
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLFATURABILGI
    {
        public int ID { get; set; }
        public string SERI { get; set; }
        public string SIRANO { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public string SAAT { get; set; }
        public byte[] VERGIDAIRE1 { get; set; }
        public Nullable<int> CARI { get; set; }
        public Nullable<short> PERSONEL { get; set; }
        public string VERGIDAIRE { get; set; }
    
        public virtual TBLCARI TBLCARI { get; set; }
        public virtual TBLPERSONEL TBLPERSONEL { get; set; }
        public virtual TBLFATURADETAY TBLFATURADETAY { get; set; }
    }
}

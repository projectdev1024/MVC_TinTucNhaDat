//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebsiteMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class House
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public House()
        {
            this.AddressHouses = new HashSet<AddressHouse>();
            this.ImageHouses = new HashSet<ImageHouse>();
            this.InfoHouses = new HashSet<InfoHouse>();
        }
    
        public int IDHouse { get; set; }
        public string Code { get; set; }
        public Nullable<int> IDTaiKhoan { get; set; }
        public string Name { get; set; }
        public string Sumary { get; set; }
        public Nullable<int> IDDuAn { get; set; }
        public Nullable<int> Views { get; set; }
        public string Type { get; set; }
        public string IDMap { get; set; }
        public Nullable<int> BedRoom { get; set; }
        public Nullable<int> Area { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<byte> State { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> CreateBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AddressHouse> AddressHouses { get; set; }
        public virtual DuAn DuAn { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImageHouse> ImageHouses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoHouse> InfoHouses { get; set; }
    }
}

namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonHang")]
    public partial class DonHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDonHang { get; set; }

        [StringLength(30)]
        public string TenKhachHang { get; set; }

        [StringLength(30)]
        public string SanPham { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiaTien { get; set; }

        public int? MaKhachHang { get; set; }

        public bool? MaPhanQuyen { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual PhanQuen PhanQuen { get; set; }
    }
}

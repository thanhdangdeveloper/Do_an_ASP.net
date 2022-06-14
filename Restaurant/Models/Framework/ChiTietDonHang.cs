namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDonHang")]
    public partial class ChiTietDonHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDonHang { get; set; }

        [StringLength(30)]
        public string TenSanPham { get; set; }

        [Column(TypeName = "image")]
        public byte[] AnhSanPham { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(30)]
        public string TenKhachHang { get; set; }

        public int? Sdt { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }
    }
}

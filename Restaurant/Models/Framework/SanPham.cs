namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSanPham { get; set; }

        [StringLength(30)]
        public string TenSanPham { get; set; }

        [Column(TypeName = "image")]
        public byte[] AnhSanPham { get; set; }

        [StringLength(30)]
        public string NguyenLieu { get; set; }

        [StringLength(30)]
        public string ChiTiet { get; set; }

        [Column(TypeName = "money")]
        public decimal? Tien { get; set; }

        public int? GiamGia { get; set; }

        public int? KichThuoc { get; set; }

        public int? SoLuongSanPham { get; set; }

        public DateTime? NgayNhap { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public int? MaLoaiSanPham { get; set; }

        public int? MaThucDon { get; set; }

        public virtual loaiSanPham loaiSanPham { get; set; }

        public virtual ThucDon ThucDon { get; set; }
    }
}

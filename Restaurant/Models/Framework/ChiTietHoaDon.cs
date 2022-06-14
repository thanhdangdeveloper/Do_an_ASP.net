namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHoaDon { get; set; }

        public int TenSanPham { get; set; }

        public int? TongTien { get; set; }

        public DateTime? NgayLap { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public int? SoLuong { get; set; }

        public int Sdt { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }
    }
}

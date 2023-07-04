using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }

        public string Email { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Luong { get; set; }
        public string SDT { get; set; }
        public string ChucVu { get; set; }
        public byte[] AnhNV { get; set; }

        //Merge code
        public byte[] ImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        //Merge code
    }
}

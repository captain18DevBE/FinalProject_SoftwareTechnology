using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using DevExpress.XtraPrinting;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace WindowsFormsApp1
{
    internal class Controller
    {
        public DataModel dm;
        public Controller() 
        {
            dm = new DataModel();
        }
        public string Login(string sdt, string password)
        {
            TaiKhoan acc = new TaiKhoan();
            acc.SDT = sdt;
            acc.MatKhau = password;

            return dm.Login(acc);
        }
        public string Signup(string TenKH, string Email, string GioiTinh, DateTime NgaySinh, string DiaChi, string SDT, string MatKhau, string AnhKH)
        {
            TaiKhoan acc = new TaiKhoan();
            acc.SDT = SDT;
            acc.MatKhau = MatKhau;
            KhachHang kh = new KhachHang();
            kh.TenKH= TenKH;
            kh.Email= Email;
            kh.GioiTinh = GioiTinh;
            kh.NgaySinh = NgaySinh;
            kh.DiaChi = DiaChi;
            kh.SDT = SDT;
            return dm.Signup(kh, acc);
        }
        public KhachHang getInfoKH(string SDT)
        {
            return dm.ShowInfoKH(SDT);
        }
        public NhanVien getInfoNV(string SDT)
        {
            return dm.ShowInfoNV(SDT);
        }
        public string showTypeAccount(string SDT)
        {
            return dm.ShowTypeAccount(SDT);
        }
        public void ChangePsd(string newPSd, string sdt, string matkhau)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.SDT = sdt;
            tk.MatKhau = matkhau;
            dm.ChangePsd(newPSd, tk);
        }
        public void editKHInfo(string id, string hoten, string sdt, DateTime dateOfBirth, string gender, string email, string address)
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = id;
            kh.TenKH = hoten;
            kh.GioiTinh = gender;
            kh.NgaySinh = dateOfBirth;
            kh.DiaChi = address;
            kh.SDT = sdt;
            kh.Email = email;
            dm.editKHInfo(kh);
        }
        public void editNVInfo(string id, string hoten, string email, string address, DateTime dateOfBirth, string gender, string sdt)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = id;
            nv.TenNV = hoten;
            nv.Email = email;
            nv.DiaChi = address;
            nv.NgaySinh = dateOfBirth;
            nv.GioiTinh = gender;
            nv.SDT = sdt;
            dm.editNVInfo(nv);
        }
        public void editAvaKH(string maKh,byte[] stream)
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = maKh;
            kh.AnhKH = stream;
            dm.editAvaKH(kh);
        }
        public void editAvaNV(string manv, byte[] stream)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = manv;
            nv.AnhNV = stream;
            dm.editAvaNV(nv);
        }

        //HoaDon
        public List<HoaDon> LoadDataToGridView()
        {
            return dm.GetHoaDon();
        }
        public List<HoaDon> LoadDataToGridViewByPhone(string sdt)
        {
            return dm.GetHoaDonKhachHang(sdt);
        }

        public List<HoaDon> FilterHoaDon(string maHD, string maKH, string tenKH, string maDV, string tenDV, string maNV, string tenNV, string maPhong, DateTime fromDay, DateTime toDay)
        {
            return dm.GetFilterHoaDon(maHD, maKH, tenKH, maDV, tenDV, maNV, tenNV, maPhong, fromDay, toDay);
        }
        public List<ThongKe> FilterThongKeDoanhThuDichVu(string loaingay, DateTime ngay)
        {
            return dm.GetFilterThongKeDoanhThuDichVu(loaingay, ngay);
        }
        public List<ThongKe> FilterThongKeChiTieuKhachHang(string loaingay, DateTime ngay)
        {
            return dm.GetFilterThongKeChiTieuKhachHang(loaingay, ngay);
        }
        public List<ThongKe> FilterThongKeSoLanDungKhachHang(string loaingay, DateTime ngay)
        {
            return dm.GetFilterThongKeSoLanDungDichVu(loaingay, ngay);
        }

        public string ExExcel(DataGridView grv, string fileName)
        {

            return dm.ExportExcel(grv, fileName);
        }

        // Dang Ky Dich Vu
        public List<DichVu> LoadDataToGridViewDKDV()
        {
            return dm.GetDichVu();
        }

        // Thiet BI
        public List<ThietBi> LoadDataToGridViewThietBi()
        {
            return dm.GetThietBi();
        }

        // Phong
        public List<Phong> LoadDataToGridViewPhong()
        {
            return dm.GetPhong();
        }

        //Merge code
        //Merge code

        //Phương thức chuyển đổi hình ảnh sang dãy nhị phân
        public byte[] ImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        //Phương thức trả về toàn bộ danh sách nhân viên theo bảng NHANVIEN
        public List<NhanVien> displayEmployerToDGV()
        {
            return dm.getListEmployer();
        }

        //Phương thức thêm dữ liệu nhân viên mới
        public void insertEmployer(NhanVien nhanVien)
        {
            bool result = dm.insertEmployer(nhanVien);
            if (result)
            {
                MessageBox.Show("Thêm dữ liệu, tài khoản nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu, tài khoản nhân viên thất bại");
            }
        }

        //Phương thức cập nhật thông tin nhân viên
        public void updateEmployer(NhanVien nhanVien)
        {
            bool result = dm.updateEmployer(nhanVien);
            if (result)
            {
                MessageBox.Show("Cập nhật thông tin, tài khoản nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin, tài khoản nhân viên thất bại");
            }
        }

        //Phương thức trả về toàn bộ danh sách dịch vụ theo bảng DICHVU
        public List<DichVu> displayServiceToDGV()
        {
            return dm.getListService();
        }

        //Phương thức thêm dữ liệu vào Hóa Đơn
        public void insertHoaDon(HoaDon hoaDon)
        {
            bool result = dm.insertHoaDon(hoaDon);
        }


        //Phương thức thêm dữ liệu dịch vụ mới
        public void insertService(DichVu dichVu)
        {
            bool result = dm.insertService(dichVu);
            if (result)
            {
                MessageBox.Show("Thêm dữ liệu dịch vụ thành công");
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu dịch vụ thất bại");
            }
        }

        //Phương thức cập nhật thông tin dữ liệu gói dịch vụ
        public void updateService(DichVu dichVu)
        {
            bool result = dm.updateService(dichVu);
            if (result)
            {
                MessageBox.Show("Cập nhật dữ liệu gói dịch vụ thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật dữ liệu gói dịch vụ thất bại");
            }
        }

        //Phương thức xóa dữ liệu gói dịch vụ
        public void deleteService(DichVu dichVu)
        {
            bool result = dm.deleteService(dichVu);
            if (result)
            {
                MessageBox.Show("Xóa dữ liệu gói dịch vụ thành công");
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu gói dịch vụ thất bại");
            }
        }

        //Phương thức trả về toàn bộ danh sách khách hàng theo bảng KHACHHANG
        public List<KhachHang> displayCustomerToDGV()
        {
            return dm.getListCustomer();
        }

        public void updateCustomer(string id, string height, string weight)
        {
            bool result = dm.updateCustomer(id, height, weight);
            if (result)
            {
                MessageBox.Show("Cập nhật dữ liệu khách hàng thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật dữ liệu khách hàng thất bại");
            }
        }


        //Merge code
        
        // Thêm thiết bị
        public void insertEquipment(ThietBi thietbi)
        {
            bool result = dm.insertEquipment(thietbi);
            if (result)
            {
                MessageBox.Show("Thêm dữ liệu thiết bị thành công");
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thiết bị thất bại");
            }
        }

        public void editEquipmentInfo(string matb, string tentb, int soluong, string tinhtrang, DateTime date, byte[] AnhTB)
        {
            ThietBi thietbi = new ThietBi();
            thietbi.MaTB = matb;
            thietbi.TenTB = tentb;
            thietbi.SoLuong = soluong;
            thietbi.TinhTrang = tinhtrang;
            thietbi.NgayNhap = date;
            thietbi.AnhTB = AnhTB; // Chưa set ảnh
            dm.editEquipmentInfo(thietbi);
        }

        //Phương thức xóa dữ liệu gói dịch vụ
        public void deleteEquipment(string maTB)
        {
            bool result = dm.deleteEquipment(maTB);
            if (result)
            {
                MessageBox.Show("Xóa dữ liệu thiết bị thành công");
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu thiết bị thất bại");
            }
        }

        public List<ThietBi> searchEquipment(string maTB)
        {
            return dm.searchEquipment(maTB);
        }

        // PHONG

        // Thêm Phòng
        public void insertRoom(Phong phong)
        {
            bool result = dm.insertRoom(phong);
            if (result)
            {
                MessageBox.Show("Thêm dữ liệu thiết bị thành công");
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thiết bị thất bại");
            }
        }

        public void editRoomInfo(string maphong, string tenphong, string hientrang, int soluong, byte[] AnhTB)
        {
            Phong phong = new Phong();
            phong.MaPhong = maphong;
            phong.TenPhong = tenphong;
            phong.HienTrang = hientrang;
            phong.SoNguoi = soluong;
            phong.AnhPhong = AnhTB; // Chưa set ảnh
            dm.editRoomInfo(phong);
        }

        //Phương thức xóa dữ liệu gói dịch vụ
        public void deleteRoom(string maPhong)
        {
            bool result = dm.deleteRoom(maPhong);
            if (result)
            {
                MessageBox.Show("Xóa dữ liệu thiết bị thành công");
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu thiết bị thất bại");
            }
        }

        public List<ThietBi> searchRoom(string maPhong)
        {
            return dm.searchEquipment(maPhong);
        }

    }
}

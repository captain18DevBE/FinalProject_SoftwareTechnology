using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

//file này gộp code để push lên

namespace WindowsFormsApp1
{
    internal class DataModel
    {
        
        private SqlConnection connection;
        string connectionString = @"Data Source=LEDUYMACBOOK\SQLEXPRESS01;Initial Catalog=QUANLYPHONGGYM;Integrated Security=True";
        public DataModel()
        {
            connection = new SqlConnection(connectionString);
        }
        /*login code*/
        public string Login(TaiKhoan acc)
        {
            string stri = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Select * from TaiKhoan where Sdt = '" + acc.SDT + "'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                if (command.ExecuteReader().Read())
                {
                    connection.Close();
                    stri = "exist";
                }
                if (stri == "exist")
                {
                    string query2 = "Select * from TaiKhoan where Sdt = '" + acc.SDT + "' and Password = '" + acc.MatKhau + "'";
                    SqlCommand command2 = new SqlCommand(query2, connection);
                    connection.Open();
                    if (command2.ExecuteReader().Read())
                    {
                        connection.Close();
                        stri = "success";
                    }
                    else
                    {
                        stri = "failed";
                    }
                }
                else
                {
                    stri = "notexist";
                }
                connection.Close();
                return stri;
            }
        }
        /*Đăng ký*/
        public string Signup(KhachHang user, TaiKhoan acc)
        {
            string noti;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command;

                string query3 = "SELECT COUNT(*) FROM TaiKhoan where Sdt = @SDT";
                connection.Open();
                SqlCommand command3 = new SqlCommand(query3, connection);
                command3.Parameters.AddWithValue("@SDT", user.SDT);
                int rowsAffected = (int)command3.ExecuteScalar();
                if (rowsAffected == 0)
                {
                    string query2 = "exec insertKHACHHANG @TenKH, @Email,@GioiTinh, @NgaySinh, @DiaChi, @SDT, @MatKhau, @AnhKH";
                    command = new SqlCommand(query2, connection);
                    command.Parameters.AddWithValue("@TenKH", user.TenKH);
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.AddWithValue("@GioiTinh", user.GioiTinh);
                    command.Parameters.AddWithValue("@NgaySinh", user.NgaySinh);
                    command.Parameters.AddWithValue("@DiaChi", user.DiaChi);
                    command.Parameters.AddWithValue("@SDT", user.SDT);
                    command.Parameters.AddWithValue("@MatKhau", acc.MatKhau);
                    command.Parameters.AddWithValue("@AnhKH", user.AnhKH);
                    noti = "Đăng ký thành công";
                    connection.Close();
                    return noti;
                }
                else
                {
                   noti = "SDT đã được đăng ký";
                   return noti;
                }
            }   
        }
        /*Trả về thông tin cá nhân của khách hàng*/
        public KhachHang ShowInfoKH(string sdt)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM KHACHHANG WHERE SDT = @sdt";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@sdt", sdt);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                KhachHang us = null;
                if (reader.Read())
                {
                    us = new KhachHang();
                    us.MaKH = reader.GetString(0);
                    us.TenKH = reader.GetString(1);
                    us.Email = reader.GetString(2);
                    us.GioiTinh = reader.GetString(3);
                    us.NgaySinh = reader.GetDateTime(4);
                    us.DiaChi= reader.GetString(5);
                    us.SDT= reader.GetString(6);
                    us.AnhKH = (byte[])reader["AnhKH"];
                }

                connection.Close();
                return us;
            }
        }
        /*Trả về thông tin cá nhân của nhân viên*/
        public NhanVien ShowInfoNV(string sdt)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM NHANVIEN WHERE SDT = @sdt";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@sdt", sdt);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                NhanVien em = null;
                if (reader.Read())
                {
                    em = new NhanVien();
                    em.MaNV = reader.GetString(0);
                    em.TenNV = reader.GetString(1);
                    em.Email = reader.GetString(2);
                    em.DiaChi = reader.GetString(3);
                    em.NgaySinh = reader.GetDateTime(4);
                    em.GioiTinh = reader.GetString(5);
                    em.Luong = reader.GetInt32(6).ToString();
                    em.SDT = reader.GetString(7);
                    em.ChucVu = reader.GetString(8);
                    em.AnhNV = (byte[])reader[9];
                }

                connection.Close();
                return em;
            }
        }
        /*Trả về loại account: nhân viên,khách hàng*/
        public string ShowTypeAccount(string sdt)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM NHANVIEN WHERE Sdt = @sdt";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@sdt", sdt);

                connection.Open();
                int rowsAffected = (int)command.ExecuteScalar();

                if(rowsAffected== 1)
                {
                    connection.Close();
                    return "Nhân viên";
                    
                }
                else
                {
                    connection.Close();
                    return "Khách hàng";
                }   
            }
        }
        /*Đổi mật khẩu*/
        public void ChangePsd(string newPsd, TaiKhoan acc)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Update TAIKHOAN set Password = @matkhau  where Sdt = @sdt";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@sdt", acc.SDT);
                command.Parameters.AddWithValue("@matkhau", newPsd);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void editKHInfo(KhachHang kh)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE KHACHHANG set TenKH = @hoten,Email = @email, GioiTinh = @gioitinh, NgaySinh = @ngaysinh, DiaChi = @diachi where MaKH =@makh ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@makh", kh.MaKH);
                command.Parameters.AddWithValue("@hoten", kh.TenKH);
                command.Parameters.AddWithValue("@email", kh.Email);
                command.Parameters.AddWithValue("@gioitinh", kh.GioiTinh);
                command.Parameters.AddWithValue("@ngaysinh", kh.NgaySinh);
                command.Parameters.AddWithValue("@diachi", kh.DiaChi);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        /*Thay đổi thông tin nhân viên*/
        public void editNVInfo(NhanVien nv)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE NHANVIEN set TenNV = @hoten,Email = @email, DiaChi = @diachi, NgaySinh = @ngaysinh, GioiTinh = @gioitinh where MaNV =@manv ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@manv", nv.MaNV);
                command.Parameters.AddWithValue("@hoten", nv.TenNV);
                command.Parameters.AddWithValue("@email", nv.Email);
                command.Parameters.AddWithValue("@diachi", nv.DiaChi);
                command.Parameters.AddWithValue("@ngaysinh", nv.NgaySinh);
                command.Parameters.AddWithValue("@gioitinh", nv.GioiTinh);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close()
                ;
            }
        }
        /*Thay đổi avatar Khách hàng*/
        public void editAvaKH(KhachHang kh)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE KHACHHANG set AnhKH= @image where MaKH = @makh";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@makh", kh.MaKH);
                command.Parameters.AddWithValue("@image", kh.AnhKH);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        /*Thay đổi avatar Nhân viên*/
        public void editAvaNV(NhanVien nv)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE NHANVIEN set AnhNV= @image where MaNV = @manv";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@manv", nv.MaNV);
                command.Parameters.AddWithValue("@image", nv.AnhNV);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        //Merge code

        //Merge code
        //Phương thức lấy toàn bộ danh sách Khách hàng theo bảng KHACHANG
        public List<KhachHang> getListCustomer()
        {
            List<KhachHang> khachHangs = new List<KhachHang>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM KHACHHANG";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    KhachHang khachHang = new KhachHang();
                    khachHang.MaKH = reader["MaKH"].ToString();
                    khachHang.TenKH = reader["TenKH"].ToString();
                    khachHang.Email = reader["Email"].ToString();
                    khachHang.GioiTinh = reader["GioiTinh"].ToString();
                    khachHang.NgaySinh = reader.GetDateTime(reader.GetOrdinal("NgaySinh"));
                    khachHang.DiaChi = reader["DiaChi"].ToString();
                    khachHang.SDT = reader["Sdt"].ToString();
                    khachHang.ChieuCao = reader["ChieuCao"].ToString();
                    khachHang.CanNang = reader["CanNang"].ToString();
                    //khachHang.AnhKH = reader["AnhNV"].ToString();
                    khachHangs.Add(khachHang);
                }
                reader.Close();
            }
            return khachHangs;
        }

        //Phương thức cập nhật thông tin chiều cao, cân nặng của khách hàng
        public bool updateCustomer(string id, string height, string weight)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Chinh sua proc
                connection.Open();
                string queryInsert = "exec UpdateKHACHHANG @MaKH,@ChieuCao,@CanNang";
                using (SqlCommand insertCommand = new SqlCommand(queryInsert, connection))
                {
                    insertCommand.Parameters.AddWithValue("@MaKH", id);
                    insertCommand.Parameters.AddWithValue("@ChieuCao", height);
                    insertCommand.Parameters.AddWithValue("@CanNang", weight);
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        result = true;
                    }
                }
                connection.Close();
            }
            return result;
        }

        //Phương thức lấy toàn bộ danh sách Nhân viên theo bảng NHANVIEN
        public List<NhanVien> getListEmployer()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM NHANVIEN";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    NhanVien nhanVien = new NhanVien();
                    nhanVien.MaNV = reader["MaNV"].ToString();
                    nhanVien.TenNV = reader["TenNV"].ToString();
                    nhanVien.Email = reader["Email"].ToString();
                    nhanVien.DiaChi = reader["DiaChi"].ToString();
                    nhanVien.NgaySinh = reader.GetDateTime(reader.GetOrdinal("NgaySinh"));
                    nhanVien.GioiTinh = reader["GioiTinh"].ToString();
                    nhanVien.Luong = reader["Luong"].ToString();
                    nhanVien.SDT = reader["Sdt"].ToString();
                    nhanVien.ChucVu = reader["ChucVu"].ToString();
                    //nhanVien.AnhNV = reader["AnhNV"].ToString();

                    nhanViens.Add(nhanVien);
                }
                reader.Close();
            }

            return nhanViens;
        }

        //Phương thức thêm dữ liệu nhân viên mới vào hệ thống (insert into)
        public bool insertEmployer(NhanVien nhanVien)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string queryCheckPhone = "select count(*) from NHANVIEN where SDT=@Phone";
                using (SqlCommand command = new SqlCommand(queryCheckPhone, connection))
                {
                    command.Parameters.AddWithValue("@Phone", nhanVien.SDT);
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        return result;
                    }
                    else
                    {
                        string queryInsert = "exec InsertNHANVIEN @TenNV,@Email,@DiaChi,@NgaySinh,@GioiTinh,@LUONG,@Sdt,@ChucVu, @AnhNV";
                        using (SqlCommand insertCommand = new SqlCommand(queryInsert, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@TenNV", nhanVien.TenNV);
                            insertCommand.Parameters.AddWithValue("@Email", nhanVien.Email);
                            insertCommand.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi);
                            insertCommand.Parameters.AddWithValue("@NgaySinh", nhanVien.NgaySinh);
                            insertCommand.Parameters.AddWithValue("@GioiTinh", nhanVien.GioiTinh);
                            insertCommand.Parameters.AddWithValue("@LUONG", nhanVien.Luong);
                            insertCommand.Parameters.AddWithValue("@Sdt", nhanVien.SDT);
                            insertCommand.Parameters.AddWithValue("@ChucVu", nhanVien.ChucVu);
                            insertCommand.Parameters.AddWithValue("@AnhNV", nhanVien.AnhNV); //chua insert anh
                            int rowsAffected = insertCommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                result = true;
                            }
                        }
                        connection.Close();
                    }
                }
            }
            return result;
        }

        //Phương thức cập nhật thông tin nhân viên
        public bool updateEmployer(NhanVien nhanVien)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Chinh sua proc
                connection.Open();
                string queryInsert = "exec UpdateNHANVIEN @MaNV, @TenNV,@Email,@DiaChi,@NgaySinh,@GioiTinh,@LUONG,@Sdt,@ChucVu";
                using (SqlCommand insertCommand = new SqlCommand(queryInsert, connection))
                {
                    insertCommand.Parameters.AddWithValue("@MaNV", nhanVien.MaNV);
                    insertCommand.Parameters.AddWithValue("@TenNV", nhanVien.TenNV);
                    insertCommand.Parameters.AddWithValue("@Email", nhanVien.Email);
                    insertCommand.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi);
                    insertCommand.Parameters.AddWithValue("@NgaySinh", nhanVien.NgaySinh);
                    insertCommand.Parameters.AddWithValue("@GioiTinh", nhanVien.GioiTinh);
                    insertCommand.Parameters.AddWithValue("@LUONG", nhanVien.Luong);
                    insertCommand.Parameters.AddWithValue("@Sdt", nhanVien.SDT);
                    insertCommand.Parameters.AddWithValue("@ChucVu", nhanVien.ChucVu);
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        result = true;
                    }
                }
                connection.Close();
            }
            return result;
        }

        //Phương thức thêm dữ liệu HOADON Đã Đăng Ký vào hệ thống (insert into)
        public bool insertHoaDon(HoaDon hoaDon)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Chinh sua proc
                connection.Open();
                string queryInsert = "EXEC InsertHoaDon @MaKH, @MaNV, @Phong, @MaDV, @TongTien, @Ngay, @SoLuong";
                using (SqlCommand insertCommand = new SqlCommand(queryInsert, connection))
                {
                    insertCommand.Parameters.AddWithValue("@MaKH", hoaDon.MaKH);
                    insertCommand.Parameters.AddWithValue("@MaNV", hoaDon.MaNV);
                    insertCommand.Parameters.AddWithValue("@Phong", hoaDon.Phong);
                    insertCommand.Parameters.AddWithValue("@MaDV", hoaDon.MaDV);
                    insertCommand.Parameters.AddWithValue("@TongTien", hoaDon.TongTien);
                    insertCommand.Parameters.AddWithValue("@Ngay", hoaDon.Ngay);
                    insertCommand.Parameters.AddWithValue("@SoLuong", hoaDon.SoLuong);

                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        result = true;
                    }
                }
                connection.Close();
            }
            return result;
        }

        //Phương thức lấy toàn bộ danh sách Dịch vụ theo bảng DICHVU
        public List<DichVu> getListService()
        {
            List<DichVu> dichVus = new List<DichVu>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM DICHVU";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DichVu dichVu = new DichVu();
                    dichVu.MaDV = reader["MaDV"].ToString();
                    dichVu.TenDV = reader["TenDV"].ToString();
                    dichVu.Gia = int.Parse(reader["Gia"].ToString());
                    //dichVu.Phong = reader["Phong"].ToString();
                    dichVu.Ngay = reader.GetDateTime(reader.GetOrdinal("Ngay"));
                    dichVu.LichTap = reader["LichTap"].ToString();
                    //dichVu.AnhDV = reader["AnhDV"].ToString();

                    dichVus.Add(dichVu);
                }
                reader.Close();
            }
            return dichVus;
        }

        //Phương thức thêm dữ liệu dịch vụ mới vào hệ thống (insert into)
        public bool insertService(DichVu dichVu)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Chinh sua proc
                connection.Open();
                string queryInsert = "EXEC sp_InsertDichVu @TenDV,@Gia,@Ngay,@LichTap,@AnhDV";
                using (SqlCommand insertCommand = new SqlCommand(queryInsert, connection))
                {
                    insertCommand.Parameters.AddWithValue("@TenDV", dichVu.TenDV);
                    insertCommand.Parameters.AddWithValue("@Gia", dichVu.Gia);
                    insertCommand.Parameters.AddWithValue("@Ngay", dichVu.Ngay);
                    insertCommand.Parameters.AddWithValue("@LichTap", dichVu.LichTap);
                    insertCommand.Parameters.AddWithValue("@AnhDV", dichVu.AnhDV);
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        result = true;
                    }
                }
                connection.Close();
            }
            return result;
        }

        //Phương thức cập nhật thông tin gói dịch vụ
        public bool updateService(DichVu dichVu)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Chinh sua proc
                connection.Open();
                string queryUpdate = "EXEC sp_UpdateDICHVU @MaDV, @TenDV,@Gia,@Ngay";
                using (SqlCommand insertCommand = new SqlCommand(queryUpdate, connection))
                {
                    insertCommand.Parameters.AddWithValue("@MaDV", dichVu.MaDV);
                    insertCommand.Parameters.AddWithValue("@TenDV", dichVu.TenDV);
                    insertCommand.Parameters.AddWithValue("@Gia", dichVu.Gia);
                    insertCommand.Parameters.AddWithValue("@Ngay", dichVu.Ngay);
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        result = true;
                    }
                }
                connection.Close();
            }
            return result;
        }

        //Phương thức xóa gói dịch vụ
        public bool deleteService(DichVu dichVu)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string queryDelete = "Delete from DICHVU where MaDV=@MaDV";
                using (SqlCommand deleteCommand = new SqlCommand(queryDelete, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@MaDV", dichVu.MaDV);
                    int rowsAffected = deleteCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        result = true;
                    }
                }
                connection.Close();
            }
            return result;
        }


        // Merge code
        public List<HoaDon> GetHoaDon()
        {
            List<HoaDon> hoadon = new List<HoaDon>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT HOADON.*, KHACHHANG.TenKH, DICHVU.TenDV, NHANVIEN.TenNV FROM HOADON INNER JOIN KHACHHANG ON HOADON.MaKH = KHACHHANG.MaKH INNER JOIN DICHVU ON HOADON.MaDV = DICHVU.MaDV INNER JOIN NHANVIEN ON HOADON.MaNV = NHANVIEN.MaNV";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    HoaDon hoaDon = new HoaDon();
                    hoaDon.MaHD = reader["MaHD"].ToString();
                    hoaDon.MaKH = reader["MaKH"].ToString();
                    hoaDon.MaNV = reader["MaNV"].ToString();
                    hoaDon.Phong = reader["Phong"].ToString();
                    hoaDon.MaDV = reader["MaDV"].ToString();
                    hoaDon.TongTien = int.Parse(reader["TongTien"].ToString());
                    hoaDon.Ngay = DateTime.Parse(reader["Ngay"].ToString());
                    hoaDon.SoLuong = int.Parse(reader["SoLuong"].ToString());
                    hoaDon.TenKH = reader["TenKH"].ToString();
                    hoaDon.TenDV = reader["TenDV"].ToString();
                    hoaDon.TenNV = reader["TenNV"].ToString();
                    hoadon.Add(hoaDon);
                }
                reader.Close();
            }

            return hoadon;
        }

        //Lấy thông tin hóa đơn theo số điện thoại khách hàng
        public List<HoaDon> GetHoaDonKhachHang(string sdt)
        {
            List<HoaDon> hoadon = new List<HoaDon>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT HOADON.*, KHACHHANG.TenKH, KHACHHANG.Sdt, DICHVU.TenDV, NHANVIEN.TenNV FROM HOADON INNER JOIN KHACHHANG ON HOADON.MaKH = KHACHHANG.MaKH INNER JOIN DICHVU ON HOADON.MaDV = DICHVU.MaDV INNER JOIN NHANVIEN ON HOADON.MaNV = NHANVIEN.MaNV WHERE KHACHHANG.Sdt = @sdt";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@sdt", sdt);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    HoaDon hoaDon = new HoaDon();
                    hoaDon.MaHD = reader["MaHD"].ToString();
                    hoaDon.MaKH = reader["MaKH"].ToString();
                    hoaDon.MaNV = reader["MaNV"].ToString();
                    hoaDon.Phong = reader["Phong"].ToString();
                    hoaDon.MaDV = reader["MaDV"].ToString();
                    hoaDon.TongTien = int.Parse(reader["TongTien"].ToString());
                    hoaDon.Ngay = DateTime.Parse(reader["Ngay"].ToString());
                    hoaDon.SoLuong = int.Parse(reader["SoLuong"].ToString());
                    hoaDon.TenKH = reader["TenKH"].ToString();
                    hoaDon.TenDV = reader["TenDV"].ToString();
                    hoaDon.TenNV = reader["TenNV"].ToString();
                    hoadon.Add(hoaDon);
                }
                reader.Close();
            }

            return hoadon;
        }
        //Lấy thông tin từ bộ lọc hóa đơn
        public List<HoaDon> GetFilterHoaDon(string maHD, string maKH, string tenKH, string maDV, string tenDV, string maNV, string tenNV, string maPhong, DateTime fromDay, DateTime toDay)
        {
            List<HoaDon> hoaDonList = new List<HoaDon>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("SELECT HOADON.*, KHACHHANG.TenKH, DICHVU.TenDV, NHANVIEN.TenNV FROM HOADON INNER JOIN KHACHHANG ON HOADON.MaKH = KHACHHANG.MaKH INNER JOIN DICHVU ON HOADON.MaDV = DICHVU.MaDV INNER JOIN NHANVIEN ON HOADON.MaNV = NHANVIEN.MaNV ");
                if (!string.IsNullOrEmpty(maHD))
                {
                    queryBuilder.AppendFormat("AND HOADON.MaHD LIKE '%{0}%' ", maHD);
                }
                if (!string.IsNullOrEmpty(maKH))
                {
                    queryBuilder.AppendFormat("AND HOADON.MaKH LIKE '%{0}%' ", maKH);
                }
                if (!string.IsNullOrEmpty(tenKH))
                {
                    queryBuilder.AppendFormat("AND KHACHHANG.TenKH LIKE N'%{0}%' ", tenKH);
                }
                if (!string.IsNullOrEmpty(maDV))
                {
                    queryBuilder.AppendFormat("AND HOADON.MaDV LIKE '%{0}%' ", maDV);
                }
                if (!string.IsNullOrEmpty(tenDV))
                {
                    queryBuilder.AppendFormat("AND DICHVU.TenDV LIKE N'%{0}%' ", tenDV);
                }
                if (!string.IsNullOrEmpty(maNV))
                {
                    queryBuilder.AppendFormat("AND HOADON.MaNV LIKE '%{0}%' ", maNV);
                }
                if (!string.IsNullOrEmpty(tenNV))
                {
                    queryBuilder.AppendFormat("AND NHANVIEN.TenNV LIKE N'%{0}%' ", tenNV);
                }
                if (!string.IsNullOrEmpty(maPhong))
                {
                    queryBuilder.AppendFormat("AND HOADON.MaPhong LIKE '%{0}%' ", maPhong);
                }
                if (fromDay != null && toDay != null)
                {
                    queryBuilder.AppendFormat("AND HOADON.Ngay >= '{0}' AND HOADON.Ngay <= '{1}' ", fromDay.ToString("yyyy-MM-dd"), toDay.ToString("yyyy-MM-dd"));
                }
                SqlCommand command = new SqlCommand(queryBuilder.ToString(), connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    HoaDon hoaDon = new HoaDon();
                    hoaDon.MaHD = reader["MaHD"].ToString();
                    hoaDon.MaKH = reader["MaKH"].ToString();
                    hoaDon.MaNV = reader["MaNV"].ToString();
                    hoaDon.Phong = reader["Phong"].ToString();
                    hoaDon.MaDV = reader["MaDV"].ToString();
                    hoaDon.TenKH = reader["TenKH"].ToString();
                    hoaDon.TenDV = reader["TenDV"].ToString();
                    hoaDon.TenNV = reader["TenNV"].ToString();
                    hoaDon.TongTien = int.Parse(reader["TongTien"].ToString());
                    hoaDon.Ngay = DateTime.Parse(reader["Ngay"].ToString());
                    hoaDon.SoLuong = int.Parse(reader["SoLuong"].ToString());
                    hoaDonList.Add(hoaDon);
                }
                reader.Close();
            }
            return hoaDonList;
        }
        //Lấy thông tin hóa đơn theo bộ lọc thống kê doanh thu dịch vụ
        public List<ThongKe> GetFilterThongKeDoanhThuDichVu(string loaingay, DateTime ngay)
        {
            List<ThongKe> thongkeList = new List<ThongKe>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("SELECT DICHVU.MaDV, DICHVU.TenDV, SUM(HOADON.TongTien) AS TongTien FROM HOADON, DICHVU WHERE DICHVU.MaDV = HOADON.MaDV ");
                if (loaingay.Equals("NGÀY"))
                {
                    queryBuilder.AppendFormat("AND HOADON.Ngay = '{0}' ", ngay.ToString("yyyy - MM - dd"));

                }
                if (loaingay.Equals("THÁNG"))
                {
                    queryBuilder.AppendFormat("AND MONTH(HOADON.Ngay) = {0} AND YEAR(HOADON.Ngay) = {1} ", ngay.Month, ngay.Year);

                }
                if (loaingay.Equals("NĂM"))
                {
                    queryBuilder.AppendFormat("AND YEAR(HOADON.Ngay) = {0} ", ngay.Year);

                }
                queryBuilder.AppendFormat("GROUP BY DICHVU.MaDV, DICHVU.TenDV;");
                SqlCommand command = new SqlCommand(queryBuilder.ToString(), connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ThongKe thongKe = new ThongKe();
                    thongKe.Ma = reader["MaDV"].ToString();
                    thongKe.Ten = reader["TenDV"].ToString();
                    thongKe.TongTien = int.Parse(reader["TongTien"].ToString());
                    thongkeList.Add(thongKe);
                }
                reader.Close();
            }
            return thongkeList;
        }

        //Lấy thông tin hóa đơn theo bộ lọc thống kê số lượng dùng dịch vụ
        public List<ThongKe> GetFilterThongKeSoLanDungDichVu(string loaingay, DateTime ngay)
        {
            List<ThongKe> thongkeList = new List<ThongKe>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("SELECT DICHVU.MaDV, DICHVU.TenDV, Count(HOADON.MaDV) AS SoLanDung FROM HOADON, DICHVU WHERE DICHVU.MaDV = HOADON.MaDV ");
                if (loaingay.Equals("NGÀY"))
                {
                    queryBuilder.AppendFormat("AND HOADON.Ngay = '{0}' ", ngay.ToString("yyyy - MM - dd"));

                }
                if (loaingay.Equals("THÁNG"))
                {
                    queryBuilder.AppendFormat("AND MONTH(HOADON.Ngay) = {0} AND YEAR(HOADON.Ngay) = {1} ", ngay.Month, ngay.Year);

                }
                if (loaingay.Equals("NĂM"))
                {
                    queryBuilder.AppendFormat("AND YEAR(HOADON.Ngay) = {0} ", ngay.Year);

                }
                queryBuilder.AppendFormat("GROUP BY DICHVU.MaDV, DICHVU.TenDV;");
                SqlCommand command = new SqlCommand(queryBuilder.ToString(), connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ThongKe thongKe = new ThongKe();
                    thongKe.Ma = reader["MaDV"].ToString();
                    thongKe.Ten = reader["TenDV"].ToString();
                    thongKe.TongTien = int.Parse(reader["SoLanDung"].ToString());
                    thongkeList.Add(thongKe);
                }
                reader.Close();
            }
            return thongkeList;
        }

        //Lấy thông tin hóa đơn theo bộ lọc thống kê chi tiêu khách hàng
        public List<ThongKe> GetFilterThongKeChiTieuKhachHang(string loaingay, DateTime ngay)
        {
            List<ThongKe> thongkeList = new List<ThongKe>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("SELECT KHACHHANG.MaKH, KHACHHANG.TenKH, SUM(HOADON.TongTien) AS TongTien FROM HOADON, KHACHHANG WHERE KHACHHANG.MaKH = HOADON.MaKH ");
                if (loaingay.Equals("NGÀY"))
                {
                    queryBuilder.AppendFormat("AND HOADON.Ngay = '{0}' ", ngay.ToString("yyyy - MM - dd"));

                }
                if (loaingay.Equals("THÁNG"))
                {
                    queryBuilder.AppendFormat("AND MONTH(HOADON.Ngay) = {0} AND YEAR(HOADON.Ngay) = {1} ", ngay.Month, ngay.Year);

                }
                if (loaingay.Equals("NĂM"))
                {
                    queryBuilder.AppendFormat("AND YEAR(HOADON.Ngay) = {0} ", ngay.Year);

                }
                queryBuilder.AppendFormat("GROUP BY KHACHHANG.MaKH, KHACHHANG.TenKH;");
                SqlCommand command = new SqlCommand(queryBuilder.ToString(), connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ThongKe thongKe = new ThongKe();
                    thongKe.Ma = reader["MaKH"].ToString();
                    thongKe.Ten = reader["TenKH"].ToString();
                    thongKe.TongTien = int.Parse(reader["TongTien"].ToString());
                    thongkeList.Add(thongKe);
                }
                reader.Close();
            }
            return thongkeList;
        }
        public string ExportExcel(DataGridView grv, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "Thống Kê";

                for (int i = 0; i < grv.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = grv.Columns[i].HeaderText;
                }
                for (int i = 0; i < grv.RowCount; i++)
                {
                    for (int j = 0; j < grv.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = grv.Rows[i].Cells[j].Value.ToString();
                    }
                }
                worksheet.Cells[1, 1].ColumnWidth = 10;
                worksheet.Cells[1, 2].ColumnWidth = 25;
                worksheet.Cells[1, 3].ColumnWidth = 10;
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
            return fileName;
        }

        // Dich Vu
        public List<DichVu> GetDichVu()
        {
            List<DichVu> dichvus = new List<DichVu>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM DICHVU";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DichVu dichvu = new DichVu();
                    dichvu.MaDV = reader["MaDV"].ToString();
                    dichvu.TenDV = reader["TenDV"].ToString();
                    dichvu.Gia = int.Parse(reader["Gia"].ToString());
                    dichvu.Phong = reader["Phong"].ToString();
                    dichvu.Ngay = DateTime.Parse(reader["Ngay"].ToString());
                    dichvu.LichTap = reader["LichTap"].ToString();
                    dichvus.Add(dichvu);
                }
                reader.Close();
            }

            return dichvus;
        }

        // Thiet Bi 
        public List<ThietBi> GetThietBi()
        {
            List<ThietBi> thietbis = new List<ThietBi>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM THIETBI";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ThietBi thietbi = new ThietBi();
                    thietbi.MaTB = reader["MaTB"].ToString();
                    thietbi.TenTB = reader["TeNTB"].ToString();
                    thietbi.SoLuong = int.Parse(reader["SoLuong"].ToString());
                    thietbi.TinhTrang = reader["TinhTrang"].ToString();
                    thietbi.NgayNhap = DateTime.Parse(reader["NgayNhap"].ToString());
                    thietbis.Add(thietbi);
                }
                reader.Close();
            }
            return thietbis;
        }

        // Phương thức thêm thiết bị
        public bool insertEquipment(ThietBi thietbi)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Chinh sua proc
                connection.Open();
                string queryInsert = "EXEC InsertThietBi @TenTB, @SoLuong, @TinhTrang, @NgayNhap, @AnhTB";
                using (SqlCommand insertCommand = new SqlCommand(queryInsert, connection))
                {
                    insertCommand.Parameters.AddWithValue("@TenTB", thietbi.TenTB);
                    insertCommand.Parameters.AddWithValue("@SoLuong", thietbi.SoLuong);
                    insertCommand.Parameters.AddWithValue("@TinhTrang", thietbi.TinhTrang);
                    insertCommand.Parameters.AddWithValue("@NgayNhap", thietbi.NgayNhap);
                    insertCommand.Parameters.AddWithValue("@AnhTB", thietbi.AnhTB);

                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        result = true;
                    }
                }
                connection.Close();
            }
            return result;
        }

        // Phương thức chỉnh sữa Thiết Bị
        public void editEquipmentInfo(ThietBi thietbi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE THIETBI set TenTB = @tentb, SoLuong = @soluong, TinhTrang = @tinhtrang, NgayNhap = @ngaynhap, AnhTB = @anhtb where MaTB = @matb";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@matb", thietbi.MaTB);
                command.Parameters.AddWithValue("@tentb", thietbi.TenTB);
                command.Parameters.AddWithValue("@soluong", thietbi.SoLuong);
                command.Parameters.AddWithValue("@tinhtrang", thietbi.TinhTrang);
                command.Parameters.AddWithValue("@ngaynhap", thietbi.NgayNhap);
                command.Parameters.AddWithValue("@anhtb", thietbi.AnhTB);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        //Phương thức xóa gói Thiết Bị
        public bool deleteEquipment(string matb)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string queryDelete = "Delete from THIETBI where MaTB = @MaTB";
                using (SqlCommand deleteCommand = new SqlCommand(queryDelete, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@MaTB", matb);
                    int rowsAffected = deleteCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        result = true;
                    }
                }
                connection.Close();
            }
            return result;
        }

        // Phương thức Search Thiết Bị theo MaTB
        public List<ThietBi> searchEquipment(string maTB)
        {
            string querySelect = "SELECT * FROM ThietBi WHERE MaTB LIKE @MaTB";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand selectCommand = new SqlCommand(querySelect, connection))
                {
                    selectCommand.Parameters.AddWithValue("@MaTB", "%" + maTB + "%");
                    connection.Open();
                    SqlDataReader reader = selectCommand.ExecuteReader();
                    List<ThietBi> equipmentList = new List<ThietBi>();
                    while (reader.Read())
                    {
                        ThietBi equipment = new ThietBi();
                        equipment.MaTB = reader.GetString(0);
                        equipment.TenTB = reader.GetString(1);
                        equipment.SoLuong = reader.GetInt32(2);
                        equipment.TinhTrang = reader.GetString(3);
                        equipment.NgayNhap = reader.GetDateTime(4);
                        equipmentList.Add(equipment);
                    }
                    return equipmentList;
                }
            }
        }

        // Phong
        public List<Phong> GetPhong()
        {
            List<Phong> phongs = new List<Phong>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PHONG";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Phong phong = new Phong();
                    phong.MaPhong = reader["MaPhong"].ToString();
                    phong.TenPhong = reader["TenPhong"].ToString();
                    phong.HienTrang = reader["HienTrang"].ToString();
                    phong.SoNguoi = int.Parse(reader["SoNguoi"].ToString());
                    phongs.Add(phong);  
                }
                reader.Close();
            }
            return phongs;
        }

        // Phương thức thêm Phong
        public bool insertRoom(Phong phong)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Chinh sua proc
                connection.Open();
                string queryInsert = "EXEC InsertPHONG @TenPhong, @HienTrang, @SoNguoi, @AnhPhong";
                using (SqlCommand insertCommand = new SqlCommand(queryInsert, connection))
                {
                    insertCommand.Parameters.AddWithValue("@TenPhong", phong.TenPhong);
                    insertCommand.Parameters.AddWithValue("@HienTrang", phong.HienTrang);
                    insertCommand.Parameters.AddWithValue("@SoNguoi", phong.SoNguoi);
                    insertCommand.Parameters.AddWithValue("@AnhPhong", phong.AnhPhong);

                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        result = true;
                    }
                }
                connection.Close();
            }
            return result;
        }

        // Phương thức chỉnh sữa Phong
        public void editRoomInfo(Phong phong)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE PHONG set TenPhong = @tenphong, HienTrang = @hientrang, SoNguoi = @songuoi, AnhPhong = @anhphong where MaPhong = @maphong";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@maphong", phong.MaPhong);
                command.Parameters.AddWithValue("@tenphong", phong.TenPhong);
                command.Parameters.AddWithValue("@HienTrang", phong.HienTrang);
                command.Parameters.AddWithValue("@SoNguoi", phong.SoNguoi);
                command.Parameters.AddWithValue("@AnhPhong", phong.AnhPhong);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        //Phương thức xóa Phong
        public bool deleteRoom(string maphong)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string queryDelete = "Delete from PHONG where MaPhong = @MapPhong";
                using (SqlCommand deleteCommand = new SqlCommand(queryDelete, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@MapPhong", maphong);
                    int rowsAffected = deleteCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        result = true;
                    }
                }
                connection.Close();
            }
            return result;
        }

        // Phương thức tìm kiếm phòng
        public List<Phong> searchPhong(string maPhong)
        {
            string querySelect = "SELECT * FROM PHONG WHERE MaPhong LIKE @MaPhong";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand selectCommand = new SqlCommand(querySelect, connection))
                {
                    selectCommand.Parameters.AddWithValue("@MaPhong", "%" + maPhong + "%");
                    connection.Open();
                    SqlDataReader reader = selectCommand.ExecuteReader();
                    List<Phong> phongList = new List<Phong>();
                    while (reader.Read())
                    {
                        Phong phong = new Phong();
                        phong.MaPhong = reader.GetString(0);
                        phong.TenPhong = reader.GetString(1);
                        phong.HienTrang = reader.GetString(3);
                        phong.SoNguoi = reader.GetInt32(2);
                        phongList.Add(phong);
                    }
                    return phongList;
                }
            }
        }
    }
}

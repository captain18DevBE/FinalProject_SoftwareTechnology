using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_DangNhap());
            //Application.Run(new Form_QuanLyDichVu());
            //Application.Run(new Form_QuanLyNhanVien());
            //Application.Run(new Form_DangNhap());   
            //Application.Run(new Form_QuanLyKH());
            //Application.Run(new Form_Main());
        }
    }
}

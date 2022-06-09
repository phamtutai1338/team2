﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Program
    {
        static Dictionary<string, string> dic = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                menu();

                Console.WriteLine("Bạn có muốn sử dụng từ điển không ?(Y/N):");
                string s = Console.ReadLine();
                if (s == "N")
                    break;

            }
            Console.WriteLine("Exit!");
            Console.ReadLine(); 
        }
        private static void menu()
        {
            Console.WriteLine("\t\t\t\t\tTra cứu từ điển ");
            Console.WriteLine("\t\t\t---------------------------------------------\n\n");
            Console.WriteLine("1: Tạo từ mới");
            Console.WriteLine("2: Sửa từ");
            Console.WriteLine("3: Tra cứu từ");
            Console.WriteLine("4: Xóa từ");
            Console.WriteLine("Bạn chọn chức năng gì ?");
            try
            {
                int cn = int.Parse(Console.ReadLine());
                switch (cn)
                {
                    case 1:
                        TaoTuMoi();
                        break;
                    case 2:
                        SuaTu();
                        break;
                    case 3:
                        TraCuu();
                        break;
                    case 4:
                        XoaTu();
                        break;
                    default:
                        Console.WriteLine("Vui lòng nhập lại!");
                        break;


                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi gì đó : " + ex.Message);
            }
        }
        private static void XoaTu()
        {
            Console.WriteLine("Mời bạn nhập vào từ muốn xóa:");
            string ta = Console.ReadLine();
            if (dic.ContainsKey(ta))
            {
                dic.Remove(ta);
                Console.WriteLine("Xóa thành công từ [{0}]", ta);
            }
            else
            {
                Console.WriteLine("Không tìm thấy từ [{0}] để xóa", ta);
            }

        }
        private static void TraCuu()
        {
            Console.WriteLine("Mời bạn nhập vào từ Tiếng Anh:");
            string ta = Console.ReadLine();
            if (dic.ContainsKey(ta))

            {
                string tv = dic[ta];
                Console.WriteLine("Nghĩa của [{0}] là [{1}]", ta, tv);
            }
            else
            {
                Console.WriteLine("Từ điển chưa có cập nhật từ[{0}]", ta);
            }
        }
        private static void SuaTu()
        {
            Console.WriteLine("Nhập vào Tiếng Anh để sửa lại nghĩa:");
            string ta = Console.ReadLine();
            if (dic.ContainsKey(ta) == false)
            {
                Console.WriteLine("Không tìm thấy [{0}] để sửa", ta);
            }
            else
            {
                Console.WriteLine("Mời bạn nhập lại nghĩa Tiếng Việt");
                string tv = Console.ReadLine();
                dic[ta] = tv;
            }
        }

        private static void TaoTuMoi()
        {
            Console.WriteLine("Mời bạn nhập vào từ Tiếng Anh:");
            string ta = Console.ReadLine();
            if (dic.ContainsKey(ta))
            {
                Console.WriteLine("Từ [{0}] đã tồn tại rồi", ta);
            }
            else
            {
                Console.WriteLine("Mời bạn nhập vào nghĩa Tiếng Việt:");
                string tv = Console.ReadLine();
                dic.Add(ta, tv);
            }

        }
    }
}






    

using System;
using ConsoleApp91.cac_chuc_nang_khac_demo_;
using ConsoleApp91.Entity;

namespace ConsoleApp91
{
    class Program
    {
        static void Main(string[] args)
        {





            _ = new Author("van cao");
            _ = new Author("huy can");
            _ = new Author("ba huyen thanh quan");
            _ = new Author("lam buu");

            _ = new Readers("hanh", new DateTime(2099, 2, 20));
            _ = new Readers("hung", new DateTime(4000, 4, 15));
            _ = new Readers("vuong", new DateTime(2099, 3, 20));
            _ = new Readers("tuan", new DateTime(4000, 11, 15));
            _ = new Readers("lan", new DateTime(2119, 6, 20));
            _ = new Readers("ngoc", new DateTime(1000, 9, 15));
            _ = new Readers("nhu", new DateTime(2299, 5, 20));
            _ = new Readers("anh", new DateTime(4090, 11, 15));

            _ = new Publisher("NXB tre");
            _ = new Publisher("NXB gia");
            _ = new Publisher("NXB non");
            _ = new Publisher("NXB om");



            _ = new Book("lao hac", 120.6, 1997, 200, new DateTime(2022, 1, 12), 1, 1);
            _ = new Book("tat den", 100.1, 1097, 2100, new DateTime(2000, 2, 10), 1, 2);
            _ = new Book("de men phuu luu ky", 120.6, 1997, 200, new DateTime(2002, 1, 1), 3, 3);
            _ = new Book("chiec thuyen ngoai xa", 100.1, 1097, 2100, new DateTime(2090, 2, 10), 2, 4);
            _ = new Book("lao hac2", 120.6, 1997, 200, new DateTime(2022, 1, 12), 1, 1);
            _ = new Book("tat den2", 100.1, 1097, 2100, new DateTime(2000, 2, 10), 1, 2);
            _ = new Book("de men phuu luu ky2", 120.6, 1997, 200, new DateTime(2002, 1, 1), 3, 3);
            _ = new Book("chiec thuyen ngoai xa2", 100.1, 1097, 2100, new DateTime(2090, 2, 10), 2, 4);


            _ = new LoanSlip(1, 1, 1);
            _ = new LoanSlip(2, 1, 1);
            _ = new LoanSlip(3, 2, 1);
            _ = new LoanSlip(4, 3, 2);


            menu.giaoDienLuaChon();


            //ManagementOfLibrary.loginInterface();
            //ManagementOfLibrary.input();

        }
    }
}

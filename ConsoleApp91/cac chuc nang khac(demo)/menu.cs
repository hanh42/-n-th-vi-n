using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp91.Entity;
namespace ConsoleApp91.cac_chuc_nang_khac_demo_
{
    class menu
    {

        public static void giaoDienLuaChon()
        {


            char chonChucNang = '\0';
            char chonChucNangChoQuanLySach = '\0';
            char chonChucNangChoQuanLyPhieuMuon = '\0';
            char chonChucNangChoQuanLyDocGia = '\0';

            do
            {



                chonChucNang = choose();

                switch (chonChucNang)
                {
                    case '1':
                        chonChucNangChoQuanLySach = menuChoChucNangQuanLySach();
                        switch (chonChucNangChoQuanLySach)
                        {
                            case '1':
                                hienThiThongTinSach();
                                break;
                            case '2':
                                xuatCacSach();
                                themVaoSachMoi();
                                break;
                            case '3':
                                xuatCacSach();
                                xoaSachKhoiDanhSach();
                                break;
                        }
                        break;
                    case '2':

                        chonChucNangChoQuanLyPhieuMuon = menuChoChucNangQuanLyPhieuMuon();
                        switch (chonChucNangChoQuanLyPhieuMuon)
                        {
                            case '1':
                                hienThiToanBoPhieuMuon();
                                break;
                            case '2':
                                xuatCacBanDoc();
                                taoPhieuMuonSach();
                                break;
                            case '3':
                                xuatCacphieu();
                                traPhieuMuonSach();
                                break;
                        }
                        break;

                    case '3':
                        chonChucNangChoQuanLyDocGia = menuChoChucNangQuanLyDocGia();
                        switch (chonChucNangChoQuanLyDocGia)
                        {

                            case '1':

                                hienThiTatCaCacDocGia();
                                break;
                            case '2':
                                themDocGiaMoi();
                                break;
                            case '3':
                                hienThiToanBoPhieuMuon();
                                xoaTheDocGia();
                                break;


                        }
                        break;
                }
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("ban co muon tiep tuc khong:\n1-tiep tuc an phim bat ky\n2-an esc de thoat ");
                chonChucNang = Console.ReadKey(true).KeyChar;
                Console.ReadKey();
                Console.Clear();
            } while (chonChucNang != (char)ConsoleKey.Escape);
        }





        public static void xuatCacSach()
        {

            foreach (var item in Book.ListOfBook)
            {
                Console.WriteLine($"\nid of book:{ item.Id,-10}      name of book:{item.NameOfBook,-10}");
            }

        }




        public static void xuatCacphieu()
        {

            foreach (var item in LoanSlip.ListOfLoanSlip)
            {
                Console.WriteLine($"\nid of loanslip:{ item.Id,-10}      name of personOfLoanSlip:{item.ReaderOfLoanSlip.Name}");
            }

        }



        public static void xuatCacBanDoc()
        {

            foreach (var item in Readers.ListOfReader)
            {
                Console.WriteLine($"\nid of reader:{ item.Id,-10}      name of reader:{item.Name,-10}");
            }

        }




        public static char choose()
        {
            char choose = '\0';
            do
            {
                Console.WriteLine("1 - Quan Ly Sach");
                Console.WriteLine("2 - Quan Ly Phieu Muon");
                Console.WriteLine("3 - quan ly doc gia");
                choose = Console.ReadKey(false).KeyChar;
            } while (choose != '1' && choose != '2' && choose != '3');

            Console.Clear();

            return choose;

        }



        public static char menuChoChucNangQuanLySach()
        {
            char choose = '\0';
            do
            {
                Console.WriteLine("1 - Hien Thi Thong Tin Sach ");
                Console.WriteLine("2 - Them Sach ");
                Console.WriteLine("3 - Xoa Sach");
                choose = Console.ReadKey(false).KeyChar;
            } while (choose != '1' && choose != '2' && choose != '3');

            Console.Clear();

            return choose;



        }


        public static void hienThiThongTinSach()
        {
            Console.WriteLine("thong tin ve tat ca sach cua thu vien!");
            foreach (var item in Book.ListOfBook)
            {
                Console.WriteLine(item);
            }



        }



        public static void themVaoSachMoi()
        {

            int idOfNewBook = 0;
            string namOfNewBook = null;
            double price = 0;
            int releaseyear;
            int numOfPage = 0;
            DateTime inPutDate;
            int idOfPublisher;
            int idOfAuthor;
            int dayInput = 0;
            int monthInput = 0;
            int yearInput = 0;
            //id tu them
            Console.WriteLine("hay nhap id cua sach moi ");
            int.TryParse(Console.ReadLine(), out idOfNewBook);
            Console.WriteLine("hay nhap cac thong tin cua cuon sach ma ban muon them!");
            Console.WriteLine("hay nhap ten sach");
            namOfNewBook = Console.ReadLine();
            Console.WriteLine("hay nhap gia sach");
            double.TryParse(Console.ReadLine(), out price);
            Console.WriteLine("hay nhap nam phat hanh");
            int.TryParse(Console.ReadLine(), out releaseyear);
            Console.WriteLine("hay nhap so trang");
            int.TryParse(Console.ReadLine(), out numOfPage);
            Console.WriteLine("hay nhap ngay nhap kho");
            int.TryParse(Console.ReadLine(), out dayInput);
            Console.WriteLine("hay nhap thang nhap  kho");
            int.TryParse(Console.ReadLine(), out monthInput);
            Console.WriteLine("hay nhap nam nhap kho");
            int.TryParse(Console.ReadLine(), out yearInput);
            inPutDate = new DateTime(yearInput, monthInput, dayInput);
            Console.WriteLine("hay nhap id cua nha xuat ban");
            int.TryParse(Console.ReadLine(), out idOfPublisher);
            Console.WriteLine("hay nhap id cua tac gia");
            int.TryParse(Console.ReadLine(), out idOfAuthor);
            var book = Book.findBook(idOfNewBook);
            // nho sua id tu nhap chu khong phai tu dong
            if (book != null)
            {
                throw new Exception("da ton tai cuon sach nay!");
            }
            Book sachMoi = new Book(namOfNewBook, price, releaseyear, numOfPage, inPutDate, idOfPublisher, idOfAuthor);
            Console.WriteLine("da them sach thanh cong!");

        }

        public static void xoaSachKhoiDanhSach()
        {
            int id = 0;
            Console.WriteLine("hay nhap ma sach");
            int.TryParse(Console.ReadLine(), out id);
            var book = Book.findBook(id);
            if (book == null)
            {
                throw new Exception("khong ton tai cuon sach co id :" + id);
            }

            if (book.Status == 0)
            {
                Book.ListOfBook.Remove(book);
                Console.WriteLine("xoa thanh cong sach co id:" + id);
            }
            else
            {
                Console.WriteLine("cuon sach chua duoc hoan tra nen khong the xoa ra khoi danh sach duoc!");
            }

        }










        public static char menuChoChucNangQuanLyPhieuMuon()
        {

            char choose = '\0';
            do
            {
                Console.WriteLine("1 - Hien Thi Cac Thong Tin Phieu Muon");
                Console.WriteLine("2 - Muon Sach");
                Console.WriteLine("3 - Tra Sach");

                choose = Console.ReadKey(false).KeyChar;
            } while (choose != '1' && choose != '2' && choose != '3');

            Console.Clear();

            return choose;

        }

        public static void hienThiToanBoPhieuMuon()
        {
            Console.WriteLine("tat ca cac phieu muon la:");

            foreach (var item in LoanSlip.ListOfLoanSlip)
            {
                Console.WriteLine("\n" + item);
            }

        }


        public static void taoPhieuMuonSach()
        {
            int maSach = -1;
            int mabanDoc = -1;

            Console.WriteLine("hay nhap ma ban doc cua nguoi muon!");
            int.TryParse(Console.ReadLine(), out mabanDoc);
            Console.WriteLine("hay nhap  ma sach can muon ");
            int.TryParse(Console.ReadLine(), out maSach);




            LoanSlip loanSlip = new LoanSlip(maSach, mabanDoc);

            Console.WriteLine("da tao phieu muon thanh cong!");


        }



        public static void traPhieuMuonSach()
        {
            int idOfLoanSlip = -1;
            int idOfBookForChangeStatus = -1;
            Console.WriteLine("hay nhap so  phieu muon cua ban [id of LoanSlip ]");
            int.TryParse(Console.ReadLine(), out idOfLoanSlip);
            var loanSlip = LoanSlip.findLoanSlip(idOfLoanSlip);
            //Console.WriteLine(loanSlip);
            if (loanSlip == null)
            {
                throw new Exception("khong co phieu muon nao co id:" + idOfLoanSlip);
            }
            else
            {

                if (loanSlip.Status != 0)
                {

                    if (loanSlip.BookOfLoanSlip.Status != 0)
                    {
                        idOfBookForChangeStatus = loanSlip.BookOfLoanSlip.Id;
                        LoanSlip.ListOfLoanSlip.Remove(loanSlip);

                        var book = Book.findBook(idOfBookForChangeStatus);
                        book.Status = 0;
                        loanSlip.Status = 0;
                        Console.WriteLine("da tra thanh cong!");
                    }

                }
                else
                {
                    throw new Exception("khong the tra phieu nay vi phieu nay da duoc tra roi!");
                }

            }





        }




        public static char menuChoChucNangQuanLyDocGia()
        {

            char choose = '\0';
            do
            {
                Console.WriteLine("1 - Hien Thi tat ca cac doc gia");
                Console.WriteLine("2 - Them doc gia");
                Console.WriteLine("3 - xoa doc gia");

                choose = Console.ReadKey(false).KeyChar;
            } while (choose != '1' && choose != '2' && choose != '3');

            Console.Clear();

            return choose;

        }



        public static void hienThiTatCaCacDocGia()
        {
            Console.WriteLine("tat ca cac doc gia:");
            foreach (var item in Readers.ListOfReader)
            {
                Console.WriteLine(item);
            }



        }

        //demo them doc gia
        public static void themDocGiaMoi()
        {
            string nameOfNewReader = "";
            Console.WriteLine("hay nhap ten cua doc gia moi!");
            nameOfNewReader = Console.ReadLine();
            Readers newReader = new Readers(nameOfNewReader);
            Console.WriteLine("da them doc gia moi thanh cong!");
        }


        public static void xoaTheDocGia()
        {
            Boolean flag = true;
            int idOfReader = -1;
            Console.WriteLine("hay nhap id doc gia!");
            int.TryParse(Console.ReadLine(), out idOfReader);
            var reader = Readers.findReaderByid(idOfReader);
            if (reader != null)
            {


                foreach (var item in reader.ListLoanSlipOfReader)
                {
                    if (item.Status != 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
                {
                    Readers.ListOfReader.Remove(reader);
                    Console.WriteLine("da xoa thanh cong doc gia co id:" + reader.Id);
                }
                else
                {
                    Console.WriteLine("khong the xoa nguoi doc vi cac phieu van chua duoc tra!");
                }
            }
            else
            {
                Console.WriteLine("khong ton tai the doc gia co id:" + idOfReader);
            }

        }


    }



}

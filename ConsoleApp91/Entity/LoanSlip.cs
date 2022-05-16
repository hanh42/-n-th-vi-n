using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp91.Entity
{
    class LoanSlip
    {
        private static List<LoanSlip> _listOfLoanSlip;
        private static int _autoIncreatment = 0;
        private int id;
        private Book bookOfLoanSlip;
        private Readers readerOfLoanSlip;
        private DateTime bookLoanDay;
        private DateTime bookReturnDate;
        private int status;
        private int numberOfLoanSlip;



        public int Id { get => id; }
        public DateTime BookLoanDay { get => bookLoanDay; }
        public DateTime BookReturnDate { get => bookReturnDate; }
        public int Status { get => status; set => status = value; }
        public int NumberOfLoanSlip { get => numberOfLoanSlip; }
        public static List<LoanSlip> ListOfLoanSlip { get => _listOfLoanSlip; }
        public Book BookOfLoanSlip { get => bookOfLoanSlip; set => bookOfLoanSlip = value; }
        public Readers ReaderOfLoanSlip { get => readerOfLoanSlip; set => readerOfLoanSlip = value; }

        public LoanSlip(int bookId = 0, int idOfReader = 0, int? loanSlipId = null)
        {



            var readerOfLoanShip = Readers.findReaderByid(idOfReader);
            if (readerOfLoanShip == null)
            {
                throw new Exception("khong ton tai khach hang co id:" + id);
            }



            var book = Book.findBook(bookId);

            if (book == null)
            {
                throw new Exception("khong ton tai sach co id:" + bookId);
            }
            else
            {


                if (book.Status != 0)
                {
                    throw new Exception("khong the tao phieu muon cho cuon sach co id:[" + bookId + "] da duoc muon boi :" + LoanSlip.findBookInSloanSlip(book.Id).readerOfLoanSlip.Id);
                }
                else
                {

                 book.Status = readerOfLoanShip.ListLoanSlipOfReader.Count+1;

                }

            }


            if (ListOfLoanSlip == null)
            {
                _listOfLoanSlip = new List<LoanSlip>();
            }

            this.id = ++_autoIncreatment;
            this.bookOfLoanSlip = book;
            //ngay muonlay ngay hien tai!
            this.bookLoanDay = DateTime.Now;
            this.bookReturnDate = this.bookLoanDay.AddDays(7);
            this.status = 1;
            this.readerOfLoanSlip = readerOfLoanShip;
            this.readerOfLoanSlip.ListLoanSlipOfReader.Add(this);
            this.numberOfLoanSlip = readerOfLoanShip.ListLoanSlipOfReader.Count;
            ListOfLoanSlip.Add(this);

        }



        public static LoanSlip findBookInSloanSlip(int id)
        {
            if (LoanSlip.ListOfLoanSlip != null)
            {
                foreach (var item in LoanSlip.ListOfLoanSlip)
                {
                    if (item.bookOfLoanSlip.Id == id)
                    {
                        return item;
                    }
                }
            }
            return null;

        }


        public static LoanSlip findLoanSlip(int id)
        {
            if (LoanSlip.ListOfLoanSlip != null)
            {
                foreach (var item in LoanSlip._listOfLoanSlip)
                {
                    if (item.id == id)
                    {
                        return item;
                    }
                }
            }
            return null;
        }




        public static string[] ToFile()
        {
            List<string> strs = new List<string>();
            strs.Add($"{_autoIncreatment}");
            foreach (var item in _listOfLoanSlip)
            {
                strs.Add($"{item.id}-{item.readerOfLoanSlip.Id}-{item.bookOfLoanSlip.Id}-{item.bookLoanDay}-{item.bookReturnDate}-{item.status}-{item.numberOfLoanSlip}");
            }

            return strs.ToArray();
        }

        public override string ToString()
        {
            return $"number of loanSlip:{this.numberOfLoanSlip}\nid of loanSlip:{this.id}\nid of reader:{this.readerOfLoanSlip.Id}\nid of book:{this.bookOfLoanSlip.Id}\ndate loan:{this.bookLoanDay}\ndate return:{this.bookReturnDate}\nnmuber of loanslip :{this.numberOfLoanSlip}   status:{this.status} ";
        }
    }
}
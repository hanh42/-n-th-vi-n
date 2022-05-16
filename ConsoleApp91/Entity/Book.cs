using ConsoleApp91.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp91
{
    class Book
    {

        private static List<Book> _listOfBook;
        private static int _autoIncreatment = 0;
        private int _id;
        private string _nameOfBook;
        private double _price;
        private int _releaseYear;
        private int _numberOfPage;
        private DateTime _inputDay;
        private int _status;
        private readonly Author authorOfBook;
        private readonly Publisher publisherOfBook;



        public int Id { get => _id; }
        public string NameOfBook { get => _nameOfBook; set => _nameOfBook = value; }
        public double Price { get => _price; set => _price = value; }
        public int ReleaseYear { get => _releaseYear; }
        public int NumberOfPage { get => _numberOfPage; set => _numberOfPage = value; }
        public DateTime InputDay { get => _inputDay; set => _inputDay = value; }
        public int Status { get => _status; set => _status = value; }


        public static List<Book> ListOfBook { get => _listOfBook; }
        public Author AuthorOfBook => authorOfBook;

        public Publisher PublisherOfBook => publisherOfBook;

        public Book(string nameOfBook = "", double price = 0, int releaseYear = 0, int numOfPage = 0, DateTime inputday = new DateTime(),  int idOfPublisherToFind = 0, int idOfAuthorToFind = 0)
        {
            if (nameOfBook == "")
            {
                throw new Exception("loi khong co ten sach");
            }
            if (price == 0)
            {
                throw new Exception("loi khong co gia sach");
            }
            if(numOfPage == 0)
            {
                throw new Exception("loi hay nhap so trang");
            }
            if (releaseYear == 0)
            {
                throw new Exception("loi yeu cau nhap vao nam xuat ban");
            }
            var authorOfBook = Author.findAuThor(idOfAuthorToFind);
            if (authorOfBook == null)
            {
                throw new Exception("khong ton tai tac gia co id la:" + idOfAuthorToFind);

            }

            var publisherOfBook = Publisher.findPublisher(idOfPublisherToFind);
            if (publisherOfBook == null)
            {
                throw new Exception("khong tim thay nha san xuat co id:" + idOfPublisherToFind);
            }


            if (_listOfBook == null)
            {
                _listOfBook = new List<Book>();
            }

           

            this._id = ++_autoIncreatment;
            this._nameOfBook = nameOfBook;





            //dang cho giai quyet
            //var checkBookHasSloanYet = LoanSlip.findBookInSloanSlip(_id);
            //if (checkBookHasSloanYet == null)
            //{
            //    this._status = 0;
            //}
            //else
            //{
            //    checkBookHasSloanYet.ReaderOfLoanSlip.ListLoanSlipOfReader.Count
            //    this._status = 1;

            //}





            this._status = 0;
            this._price = price;
            this._releaseYear = releaseYear;
            this._numberOfPage = numOfPage;
            this._inputDay = inputday;
           
            this.authorOfBook = authorOfBook;
            this.publisherOfBook = publisherOfBook;
            this.publisherOfBook.ListBookOfPublisher.Add(this);
            this.authorOfBook.ListBookOfAuthor.Add(this);
            _listOfBook.Add(this);


        }

        public static Book findBook(int id)
        {
            if (_listOfBook != null)
            {
                for (int i = 0; i < _listOfBook.Count; i++)
                {
                    if (_listOfBook[i].Id == id)
                    {
                        return _listOfBook[i];
                    }
                }

            }
            return null;
        }

        public static string[] ToFile()
        {
            List<string> strs = new List<string>();
            strs.Add($"{_autoIncreatment}");
            foreach (var item in _listOfBook)
            {
                strs.Add(
                    $"{item.Id}-{item.NameOfBook}-{item.AuthorOfBook.Id}-{item.Price}-{item.publisherOfBook.Id}-{item.ReleaseYear}-{item.NumberOfPage}-{item.InputDay}-{item.Status}"
                    );
            }

            return strs.ToArray();
        }


        public override string ToString()
        {

            return $"\nid of book:{this.Id}\nname of book:{this.NameOfBook}\nname of author:{this.AuthorOfBook.NamOfAuthor}" +
                $"\nPublisher:{this.publisherOfBook.NameOfPublisher}\nprice:{this.Price}\nreleaseYear:{this.ReleaseYear}" +
                $"\nnumOfPage:{this.NumberOfPage}\ninputDay:{this.InputDay}\nstatus:{this.Status}";
          
        }
    }
}

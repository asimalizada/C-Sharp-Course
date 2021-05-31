using System;

namespace Lesson12___OOP_Intro
{
    class Credit
    {
        public int Percent;
        public decimal InitialPrice;

        private decimal _price;

        public decimal GetPrice()
        {
            _price = InitialPrice + Percent * InitialPrice / 100;
            return _price;
        }

        //public void SetPrice(decimal price)
        //{
        //    _price = price;
        //}
        public void GiveCredit()
        {
            Console.WriteLine($"{_customer} musterisine {Price} azn mebleginde kredit  verildi");
        }
        public decimal Price => InitialPrice + Percent * InitialPrice / 100;
        private string _customer;
        public string Customer { set => _customer = value; }
    }
}
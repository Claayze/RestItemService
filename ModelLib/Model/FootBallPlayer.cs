using System;

namespace ModelLib.Model
{
        public class FootBallPlayer
    {
        private string _name;
        private int _price;
        private int _shirtNumber;

        public int Id { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 4) throw new ArgumentOutOfRangeException();
                _name = value;
            }
        }
        public int Price
        {
            get => _price;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                _price = value;
            }
        }

        public int ShirtNumber
        {
            get => _shirtNumber;
            set
            {
                if (value < 1 || value > 100) throw new ArgumentOutOfRangeException();
                _shirtNumber = value;
            }
        }

        public FootBallPlayer(string name, int price, int shirtnumber, int id)
        {
            Name = name;

            Price = price;

            ShirtNumber = shirtnumber;

            Id = id;
        }

        public FootBallPlayer()
        {

        }
        public override string ToString()
        {
            return Name + Id + Price + ShirtNumber.ToString();
        }

    }
}
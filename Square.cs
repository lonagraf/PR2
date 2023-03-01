using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabinet {
    internal class Square {
        private int _squarecabinet;
        private int _squarepodsobka;
        public int SquareCabinet 
        {
            get => _squarecabinet;
            private set => _squarecabinet = value;
        }
        public int SquarePodsobka
        {
            get => _squarepodsobka;
            private set => _squarepodsobka = value;
        }
        public Square(int squarepodsobka, int squarecabinet) 
        {
            _squarecabinet = squarecabinet;
            _squarepodsobka = squarepodsobka;
        } 
    }
}

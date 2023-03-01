using System;
using System.Collections.Generic;

namespace Cabinet
{
    public class CabinetDatabase
    {
        private Random _random = new Random();
        private int RandSquareCabinet {
            get => _random.Next(10, 100);
        }
        private int RandSquarePodsobka { 
        get => _random.Next(3, 15);
        }
        internal List<Cabinet> Cabinets { get; private set; }

        public void Initialize()
        {
            Cabinets = new List<Cabinet>
            {
                new Cabinet(new ZavCabinet("Иван","Иванов","Иванович"), RandSquareCabinet, RandSquarePodsobka),
                new Cabinet(new ZavCabinet("Петр","Петров","Петрович"), RandSquareCabinet, RandSquarePodsobka),
                new Cabinet(new ZavCabinet("Андрей","Петров","Андреевич"), RandSquareCabinet, RandSquarePodsobka),
                new Cabinet(new ZavCabinet("Рахмет","Бады","Исламович"), RandSquareCabinet, RandSquarePodsobka),
                new Cabinet(new ZavCabinet("Кристина","Лезных","Юрьевна"), RandSquareCabinet, RandSquarePodsobka),
                new Cabinet(new ZavCabinet("Илона","Граф","Константиновна"), RandSquareCabinet, RandSquarePodsobka),
                new Cabinet(new ZavCabinet("Полина","Чертыкова","Павловна"), RandSquareCabinet, RandSquarePodsobka),
                new Cabinet(new ZavCabinet("Дарья","Чистанова","Александровна"), RandSquareCabinet, RandSquarePodsobka),
            };
        }
    }
}
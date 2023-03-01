namespace Cabinet
{

    internal class Cabinet
    {
        private ZavCabinet _zavcabinet;
        private int _squarecabinet;
        private int _squarepodsobka;

        public int SquareCabinet
        {
            get => _squarecabinet;
        }

        public int SquarePodsobka
        {
            get => _squarepodsobka;
        }
        private ZavCabinet ZavCabinet 
        {
            get => _zavcabinet;
        }

        public string firstname
        {
            get { return ZavCabinet != null ? ZavCabinet.FirstName : "Не назначено"; }
        }
        public string lastname {
            get { return ZavCabinet != null ? ZavCabinet.LastName : "Не назначено"; }
        }
        public string patronymic {
            get { return ZavCabinet != null ? ZavCabinet.Patronymic : "Не назначено"; }
        }


        public Cabinet(ZavCabinet zavCabinet, int squarecabinet, int squarepodsobka)
        {

            _squarecabinet = squarecabinet;
            _squarepodsobka = squarepodsobka;
            _zavcabinet = zavCabinet;
        }


    }
}

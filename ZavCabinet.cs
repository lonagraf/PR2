namespace Cabinet
{
    internal class ZavCabinet
    {
        private string _firstname;
        private string _lastname;
        private string _patronymic;

        public string FirstName
        {
            get => _firstname;
            private set => _firstname = value;
        }
        public string LastName 
        {
            get => _lastname;
            private set => _lastname = value;
        }
        public string Patronymic 
        {
            get => _patronymic;
            private set => _patronymic = value;
        }
        public ZavCabinet(string firstname, string lastname, string partonymic)
        {
            _firstname = firstname;
            _lastname = lastname;
            _patronymic = partonymic;
        }
    }
}

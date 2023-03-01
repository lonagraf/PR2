using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Cabinet
{
    public partial class CabinetForm : Form
    {
        private CabinetDatabase _cabinet;

        public CabinetForm()
        {
            InitializeComponent();

            _cabinet = new CabinetDatabase();
            _cabinet.Initialize();

            CabinetDataGrid.DataSource = _cabinet.Cabinets.ToList();
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e) {
            List<Cabinet> LastName = _cabinet.Cabinets.Where(x => x.lastname.Contains(textBox1.Text)).ToList();
            CabinetDataGrid.DataSource = LastName;
        }

        private void button1_Click(object sender, System.EventArgs e) {

            CabinetDataGrid.DataSource = _cabinet.Cabinets.ToList();
        }

        private void button2_Click(object sender, System.EventArgs e) {

            List<Cabinet> Square = _cabinet.Cabinets.Where(x => x.SquareCabinet > 10).ToList();
            List<Cabinet> LastName = _cabinet.Cabinets.Where(_x => _x.lastname.Contains("Иванов")).ToList();
            CabinetDataGrid.DataSource = Square;
            CabinetDataGrid.DataSource = LastName;
        }

        private void button3_Click(object sender, System.EventArgs e) {

            List<Cabinet> Square = _cabinet.Cabinets.OrderBy(x => x.SquareCabinet).ToList();
            CabinetDataGrid.DataSource = Square;
        }
    }
}
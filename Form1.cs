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

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                CabinetDataGrid.DataSource = _cabinet.Cabinets.ToList();
            }
            else
            {
                var initials = _cabinet.Cabinets.Where(s => s.lastname.ToLower().Contains(textBox1.Text.ToLower())).ToList();
                CabinetDataGrid.DataSource = initials;
            }
        }

        private void button1_Click(object sender, System.EventArgs e) {

            CabinetDataGrid.DataSource = _cabinet.Cabinets.ToList();
        }

        private void button2_Click(object sender, System.EventArgs e) {

            List<Cabinet> Square = _cabinet.Cabinets.Where(x => x.SquareCabinet > 50).ToList();
            CabinetDataGrid.DataSource = Square;

        }

        private void button3_Click(object sender, System.EventArgs e) {

            List<Cabinet> Square = _cabinet.Cabinets.OrderBy(x => x.SquareCabinet).ToList();
            CabinetDataGrid.DataSource = Square;
        }
    }
}
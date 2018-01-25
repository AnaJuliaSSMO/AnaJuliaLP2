using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFarmOfUs
{
    public partial class ConsultarEstoqueAgricultura : Form
    {
        public ConsultarEstoqueAgricultura()
        {
            InitializeComponent();
        }

        private void ConsultarAgricultura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lOGINUSERDataSet1.Plantas' table. You can move, or remove it, as needed.
            this.plantasTableAdapter.Fill(this.lOGINUSERDataSet1.Plantas);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Vista
{
    public partial class FORMHuesped : Form
    {
        public FORMHuesped()
        {
            InitializeComponent();
        }

        private void FORMHuesped_Load(object sender, EventArgs e)
        {
            frmHuesped huesped = new frmHuesped();
            this.Controls.Add(huesped);
            huesped.Dock = System.Windows.Forms.DockStyle.Fill;
        }
    }
}

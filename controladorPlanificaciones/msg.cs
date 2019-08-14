using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controladorPlanificaciones
{
    public partial class msg : Form
    {
        public msg()
        {
            InitializeComponent();
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

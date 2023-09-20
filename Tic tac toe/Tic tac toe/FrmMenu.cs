using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_toe
{
    public partial class FrmMenu : Form
    {
        /*coment*/
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            FrmBoard board = new FrmBoard();
            board.ShowDialog();
            board.Dispose();
        }

        private void btnCasilla0_Click(object sender, EventArgs e)
        {
            FrmBoard board = new FrmBoard(true);
            board.ShowDialog();
            board.Dispose();
        }

        private void btnCPUvsCPU_Click(object sender, EventArgs e)
        {
            FrmBoard board = new FrmBoard("", true);
            board.ShowDialog();
            board.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doubler
{
    public partial class Main : Form
    {
        int selectedGame;

        public Main()
        {
            InitializeComponent();

            cmbGameSelect.SelectedIndex = 0;
        }

        private void cmbGameSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            selectedGame = cmb.SelectedIndex;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            switch (selectedGame)
            {
                case 0:
                    //Main.ActiveForm.Hide();
                    this.Visible = false;
                    Doubler doubler = new Doubler();
                    doubler.ShowDialog();
                    doubler.Close();
                    //this.ShowDialog();
                    this.Visible = true;
                    break;

                case 1:
                    //Main.ActiveForm.Hide();
                    this.Visible = false;
                    GuessNumber guessNumber = new GuessNumber();
                    guessNumber.ShowDialog();
                    guessNumber.Close();
                    //this.ShowDialog();
                    this.Visible = true;
                    break;
            }
        }
    }
}

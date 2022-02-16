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
    public partial class GuessNumber : Form
    {
        private Random rnd = new Random();
        private int computerNumber;
        private int userNumber;
        private int userAttemptCount;

        public GuessNumber()
        {
            InitializeComponent();


            computerNumber = rnd.Next(1, 100);
            UpdateAttemptCounter(userAttemptCount = 0);
        }

        private void tbUserNumber_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string str = tb.Text;
            if(int.TryParse(str, out userNumber))
            {
                
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckWin();
        }

        private void UpdateCmdCounter(int counter)
        {
            lbAttemptCounter.Text = $"Счётчик попыток: {counter}";
        }

        private void CheckWin()
        {
            UpdateAttemptCounter(++userAttemptCount);

            if (userNumber < computerNumber)
            {
                UpdateGameStatus("<");
            }
            else if (userNumber > computerNumber)
            {
                UpdateGameStatus(">");
            }
            else
            {
                MessageBox.Show("Вы успешно завершили игру", "Угадай число",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (MessageBox.Show("Желаете сыграть ещё раз?", "Угадай Число",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    computerNumber = rnd.Next(1, 100);
                    UpdateAttemptCounter(userAttemptCount = 0);
                }
                else
                {
                    Close();
                }
            }
        }

        private void UpdateAttemptCounter(int number)
        {
            lbAttemptCounter.Text = $"Счётчик попыток: {number}";
        }

        private void UpdateGameStatus(string str)
        {
            lbGameStatus.Text = $"{str} загаданного числа";
        }
    }
}

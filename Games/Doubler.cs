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
    public partial class Doubler : Form
    {
        private Random random = new Random();
        private Stack<int> stack = new Stack<int>();
        private int computerNumber;
        private int userNumber;
        private int userCmdCounter;
        private int userProgressCount;

        public Doubler()
        {
            InitializeComponent();

            

            userNumber = 0;
            stack.Clear();
            stack.Push(userNumber);
            UpdateCmdCounter(userCmdCounter = 0);
            UpdateGameState(userNumber, random.Next(50));
            userProgressCount = GetProgressCount(computerNumber);
            UpdateProgressCounter(userProgressCount);
        }

        private void UpdateGameState(int userNumber)
        {
            //this.userNumber = userNumber;
            lbUserNumber.Text = $"Текущее число: {userNumber}";
        }

        private void UpdateGameState(int userNumber, int computerNumber)
        {
            UpdateGameState(userNumber);
            this.computerNumber = computerNumber;
            lbComputerNumber.Text = $"Получите число: {computerNumber}";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            userNumber = 0;
            stack.Clear();
            stack.Push(userNumber);
            UpdateCmdCounter(userCmdCounter = 0);
            UpdateGameState(userNumber, random.Next(50));
            userProgressCount = GetProgressCount(computerNumber);
            UpdateProgressCounter(userProgressCount);
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            try
            {
                userNumber = stack.Pop();
                UpdateGameState(userNumber);
            }
            catch (Exception ex)
            {
                userNumber = 0;
                stack.Clear();
                stack.Push(userNumber);
                UpdateGameState(userNumber);
            }

            UpdateCmdCounter(++userCmdCounter);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            stack.Push(userNumber);
            UpdateGameState(++userNumber);
            UpdateCmdCounter(++userCmdCounter);
            CheckWin();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            stack.Push(userNumber);
            UpdateGameState(userNumber *= 2);
            UpdateCmdCounter(++userCmdCounter);
            CheckWin();
        }

        private void CheckWin()
        {
            if (computerNumber == userNumber)
            {
                MessageBox.Show("Вы успешно завершили игру", "Удвоитель",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (MessageBox.Show("Желаете сыграть ещё раз?", "Удвоитель",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userNumber = 0;
                    stack.Clear();
                    stack.Push(userNumber);
                    UpdateCmdCounter(userCmdCounter = 0);
                    UpdateGameState(userNumber, random.Next(50));
                    userProgressCount = GetProgressCount(computerNumber);
                    UpdateProgressCounter(userProgressCount);
                }
                else
                {
                    Close();
                }
            }
        }

        private void UpdateCmdCounter(int counter)
        {
            lbCmdCounter.Text = $"Счётчик команд: {counter}";
        }


        private void UpdateProgressCounter(int number)
        {
            lbProgress.Text = $"Минимальное кол-во ходов: {number}";
        }


        private int GetProgressCount(int number)
        {
            int Progress = 0;

            while (number > 0)
            {
                if(number % 2 > 0)
                {
                    number--;
                }
                else
                {
                    number /= 2;
                }

                Progress++;
            }

            return Progress;
        }
    }
}

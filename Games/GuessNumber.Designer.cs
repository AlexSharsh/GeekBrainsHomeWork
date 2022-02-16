namespace Doubler
{
    partial class GuessNumber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbUserNumber = new System.Windows.Forms.TextBox();
            this.lbComputerNumber = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lbGameStatus = new System.Windows.Forms.Label();
            this.lbAttemptCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUserNumber
            // 
            this.tbUserNumber.Location = new System.Drawing.Point(176, 77);
            this.tbUserNumber.Name = "tbUserNumber";
            this.tbUserNumber.Size = new System.Drawing.Size(31, 20);
            this.tbUserNumber.TabIndex = 0;
            this.tbUserNumber.TextChanged += new System.EventHandler(this.tbUserNumber_TextChanged);
            // 
            // lbComputerNumber
            // 
            this.lbComputerNumber.AutoSize = true;
            this.lbComputerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbComputerNumber.Location = new System.Drawing.Point(49, 33);
            this.lbComputerNumber.Name = "lbComputerNumber";
            this.lbComputerNumber.Size = new System.Drawing.Size(304, 16);
            this.lbComputerNumber.TabIndex = 1;
            this.lbComputerNumber.Text = "Угадайте загаданное  число от 1 до 100";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheck.Location = new System.Drawing.Point(138, 116);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(103, 68);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lbGameStatus
            // 
            this.lbGameStatus.AutoSize = true;
            this.lbGameStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGameStatus.Location = new System.Drawing.Point(213, 80);
            this.lbGameStatus.Name = "lbGameStatus";
            this.lbGameStatus.Size = new System.Drawing.Size(0, 13);
            this.lbGameStatus.TabIndex = 3;
            // 
            // lbAttemptCounter
            // 
            this.lbAttemptCounter.AutoSize = true;
            this.lbAttemptCounter.Location = new System.Drawing.Point(248, 239);
            this.lbAttemptCounter.Name = "lbAttemptCounter";
            this.lbAttemptCounter.Size = new System.Drawing.Size(96, 13);
            this.lbAttemptCounter.TabIndex = 4;
            this.lbAttemptCounter.Text = "Счётчик попыток:";
            // 
            // GuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lbAttemptCounter);
            this.Controls.Add(this.lbGameStatus);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lbComputerNumber);
            this.Controls.Add(this.tbUserNumber);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "GuessNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Угадай число (Шаршуков Александр Сергеевич)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserNumber;
        private System.Windows.Forms.Label lbComputerNumber;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lbGameStatus;
        private System.Windows.Forms.Label lbAttemptCounter;
    }
}
namespace Doubler
{
    partial class Doubler
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnRevert = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.lbProgress = new System.Windows.Forms.Label();
            this.lbComputerNumber = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbUserNumber = new System.Windows.Forms.Label();
            this.lbCmdCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlay.Location = new System.Drawing.Point(252, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(120, 42);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Раздать";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRevert
            // 
            this.btnRevert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRevert.Location = new System.Drawing.Point(252, 60);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(120, 42);
            this.btnRevert.TabIndex = 1;
            this.btnRevert.Text = "Отмена хода";
            this.btnRevert.UseVisualStyleBackColor = true;
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(252, 108);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(120, 42);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+1";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMul
            // 
            this.btnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMul.Location = new System.Drawing.Point(252, 156);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(120, 42);
            this.btnMul.TabIndex = 3;
            this.btnMul.Text = "x2";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSize = true;
            this.lbProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbProgress.Location = new System.Drawing.Point(19, 41);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(174, 13);
            this.lbProgress.TabIndex = 4;
            this.lbProgress.Text = "Минимальное кол-во ходов:";
            // 
            // lbComputerNumber
            // 
            this.lbComputerNumber.AutoSize = true;
            this.lbComputerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbComputerNumber.Location = new System.Drawing.Point(19, 12);
            this.lbComputerNumber.Name = "lbComputerNumber";
            this.lbComputerNumber.Size = new System.Drawing.Size(104, 13);
            this.lbComputerNumber.TabIndex = 5;
            this.lbComputerNumber.Text = "Получите число:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbUserNumber
            // 
            this.lbUserNumber.AutoSize = true;
            this.lbUserNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUserNumber.Location = new System.Drawing.Point(19, 146);
            this.lbUserNumber.Name = "lbUserNumber";
            this.lbUserNumber.Size = new System.Drawing.Size(101, 13);
            this.lbUserNumber.TabIndex = 7;
            this.lbUserNumber.Text = "Текущее число:";
            // 
            // lbCmdCounter
            // 
            this.lbCmdCounter.AutoSize = true;
            this.lbCmdCounter.Location = new System.Drawing.Point(249, 239);
            this.lbCmdCounter.Name = "lbCmdCounter";
            this.lbCmdCounter.Size = new System.Drawing.Size(91, 13);
            this.lbCmdCounter.TabIndex = 8;
            this.lbCmdCounter.Text = "Счётчик команд:";
            // 
            // Doubler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lbCmdCounter);
            this.Controls.Add(this.lbUserNumber);
            this.Controls.Add(this.lbComputerNumber);
            this.Controls.Add(this.lbProgress);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnRevert);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Doubler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удвоитель (Шаршуков Александр Сергеевич)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnRevert;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Label lbProgress;
        private System.Windows.Forms.Label lbComputerNumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbUserNumber;
        private System.Windows.Forms.Label lbCmdCounter;
    }
}


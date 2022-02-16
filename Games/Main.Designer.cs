namespace Doubler
{
    partial class Main
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.lbGameSelect = new System.Windows.Forms.Label();
            this.cmbGameSelect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlay.Location = new System.Drawing.Point(237, 61);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(106, 122);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Играть";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lbGameSelect
            // 
            this.lbGameSelect.AutoSize = true;
            this.lbGameSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGameSelect.Location = new System.Drawing.Point(48, 61);
            this.lbGameSelect.Name = "lbGameSelect";
            this.lbGameSelect.Size = new System.Drawing.Size(122, 16);
            this.lbGameSelect.TabIndex = 1;
            this.lbGameSelect.Text = "Выберите игру:";
            // 
            // cmbGameSelect
            // 
            this.cmbGameSelect.DisplayMember = "(нет)";
            this.cmbGameSelect.FormattingEnabled = true;
            this.cmbGameSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbGameSelect.Items.AddRange(new object[] {
            "Удвоитель",
            "Угадай число"});
            this.cmbGameSelect.Location = new System.Drawing.Point(51, 80);
            this.cmbGameSelect.Name = "cmbGameSelect";
            this.cmbGameSelect.Size = new System.Drawing.Size(121, 21);
            this.cmbGameSelect.TabIndex = 2;
            this.cmbGameSelect.SelectedIndexChanged += new System.EventHandler(this.cmbGameSelect_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.cmbGameSelect);
            this.Controls.Add(this.lbGameSelect);
            this.Controls.Add(this.btnPlay);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игры (Шаршуков Александр Сергеевич)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lbGameSelect;
        private System.Windows.Forms.ComboBox cmbGameSelect;
    }
}
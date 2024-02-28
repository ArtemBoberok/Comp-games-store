
namespace Computer_games_store
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.продукцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контактыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузкаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxInf = new System.Windows.Forms.TextBox();
            this.buttonAut = new System.Windows.Forms.Button();
            this.DGVGames = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGames)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.продукцияToolStripMenuItem,
            this.контактыToolStripMenuItem,
            this.выгрузкаДанныхToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // продукцияToolStripMenuItem
            // 
            this.продукцияToolStripMenuItem.Name = "продукцияToolStripMenuItem";
            this.продукцияToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.продукцияToolStripMenuItem.Text = "Продукция";
            this.продукцияToolStripMenuItem.Click += new System.EventHandler(this.продукцияToolStripMenuItem_Click);
            // 
            // контактыToolStripMenuItem
            // 
            this.контактыToolStripMenuItem.Name = "контактыToolStripMenuItem";
            this.контактыToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.контактыToolStripMenuItem.Text = "Контакты";
            this.контактыToolStripMenuItem.Click += new System.EventHandler(this.контактыToolStripMenuItem_Click);
            // 
            // выгрузкаДанныхToolStripMenuItem
            // 
            this.выгрузкаДанныхToolStripMenuItem.Name = "выгрузкаДанныхToolStripMenuItem";
            this.выгрузкаДанныхToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.выгрузкаДанныхToolStripMenuItem.Text = "Выгрузка данных";
            this.выгрузкаДанныхToolStripMenuItem.Visible = false;
            this.выгрузкаДанныхToolStripMenuItem.Click += new System.EventHandler(this.выгрузкаДанныхToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(12, 35);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(365, 26);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Магазин «Компьютерные игры»";
            // 
            // textBoxInf
            // 
            this.textBoxInf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxInf.Enabled = false;
            this.textBoxInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInf.Location = new System.Drawing.Point(12, 75);
            this.textBoxInf.Multiline = true;
            this.textBoxInf.Name = "textBoxInf";
            this.textBoxInf.Size = new System.Drawing.Size(365, 40);
            this.textBoxInf.TabIndex = 3;
            this.textBoxInf.Text = "Добро пожаловать в магазин «Компьютерные игры»!\r\nЗдесь вы найдете все, что вам ну" +
    "жно!";
            // 
            // buttonAut
            // 
            this.buttonAut.Location = new System.Drawing.Point(475, 426);
            this.buttonAut.Name = "buttonAut";
            this.buttonAut.Size = new System.Drawing.Size(97, 23);
            this.buttonAut.TabIndex = 4;
            this.buttonAut.Text = "Авторизация";
            this.buttonAut.UseVisualStyleBackColor = true;
            this.buttonAut.Click += new System.EventHandler(this.buttonAut_Click);
            // 
            // DGVGames
            // 
            this.DGVGames.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DGVGames.Location = new System.Drawing.Point(12, 123);
            this.DGVGames.Name = "DGVGames";
            this.DGVGames.Size = new System.Drawing.Size(343, 190);
            this.DGVGames.TabIndex = 5;
            this.DGVGames.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Игры";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Цена";
            this.Column2.Name = "Column2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Computer_games_store.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.DGVGames);
            this.Controls.Add(this.buttonAut);
            this.Controls.Add(this.textBoxInf);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Магазин \"Компьютерные игры\"";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem продукцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контактыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выгрузкаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxInf;
        private System.Windows.Forms.Button buttonAut;
        private System.Windows.Forms.DataGridView DGVGames;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}


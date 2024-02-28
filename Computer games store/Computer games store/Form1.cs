using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Computer_games_store
{
    public partial class Form1 : Form
    {
        Form2 fr = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        string[] Game =
        {
            "Шахматы", "Крестики нолики", "Сапер", "Ведьмак", "Киберпанк"
        };

        string[] Price =
        {
            "3210", "4320", "3430", "3215", "4000"
        };

        private void buttonAut_Click(object sender, EventArgs e)
        {
            fr = new Form2();
            fr.Show();
            
        }

        public void vhod()
        {
            выгрузкаДанныхToolStripMenuItem.Visible = true;
        }

        private void контактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3();
            newForm3.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Предупреждение",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void выгрузкаДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var application = new Excel.Application();
            application.SheetsInNewWorkbook = 1;
            Excel.Workbook workbook = application.Workbooks.Add(Type.Missing);

            Excel.Worksheet worksheet = application.Worksheets.Item[1];
            worksheet.Name = "Список видеоигр";
            worksheet.Cells[1, 1] = DGVGames.Columns[0].HeaderCell.Value;
            worksheet.Cells[1, 2] = DGVGames.Columns[1].HeaderCell.Value;

            int n = Game.Length;
            for (int i = 2; i < n + 2; i++)
            {
                worksheet.Cells[i, 1] = DGVGames[0, i - 2].Value;
                worksheet.Cells[i, 2] = DGVGames[1, i - 2].Value;
            }
            application.Visible = true;
        }

        private void продукцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGVGames.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            int n = Game.Length;
            DGVGames.RowCount = n;
            for (int j = 0; j < DGVGames.RowCount; j++)
            {
                DGVGames[0, j].Value = Game[j];
                DGVGames[1, j].Value = Price[j];
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (fr.Login == "admin" && fr.Password == "QweRt098")
            {
                выгрузкаДанныхToolStripMenuItem.Visible = true;
            }
        }
    }
}

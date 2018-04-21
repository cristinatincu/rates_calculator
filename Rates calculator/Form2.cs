using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Rates_calculator
{
    public partial class Form2 : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void choose_file_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file = new OpenFileDialog() { Filter = "Excel Workbook|* .xlsx", ValidateNames = true })
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText("path", file.FileName);
                    FileStream fs = File.Open(file.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(fs);
                    reader.IsFirstRowAsColumnNames = true;
                    rates = reader.AsDataSet();
                    reader.Close();
                }
            }
        }
    }
}

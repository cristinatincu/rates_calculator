using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using Excel;

namespace Rates_calculator
{
    public partial class Form1 : Form
    {
        DataSet rates;
        FileStream fs;
        DateTime arrdate;
        DateTime depdate;
        DataTable agency;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                fs = File.Open("HotelbedsRates.xlsx", FileMode.Open, FileAccess.Read);
            }
            catch
            {
                string readText = File.ReadAllText("path");
                try
                {
                    fs = File.Open(readText, FileMode.Open, FileAccess.Read);
                }
                catch
                {
                    using (OpenFileDialog file = new OpenFileDialog() { Filter = "Excel Workbook|* .xlsx", ValidateNames = true })
                    {
                        if (file.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllText("path", file.FileName);
                            try
                            {
                                fs = File.Open(file.FileName, FileMode.Open, FileAccess.Read);
                            }
                            catch
                            {
                                MessageBox.Show("Rates calculator can not access the file beacause it is opened, please close the chosen file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }

            }

            IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(fs);
            reader.IsFirstRowAsColumnNames = true;
            rates = reader.AsDataSet();
            reader.Close();

            foreach (DataTable dt in rates.Tables)
                comboBox1.Items.Add(dt.TableName);
            comboBox1.SelectedIndex = 0;

            arrdate = dateTimePicker1.Value;
            depdate = arrdate.AddDays(1);
        }        

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            clearListView();

            bool bb = false;
            bool nrf = false;
            int type = 0;
            int nights = Decimal.ToInt32(numericNights.Value);             
            int totaldates = agency.Rows.Count - 1;
            string[] dates = new string[totaldates];
            double[] sgls = new double[totaldates];
            double[] dbls = new double[totaldates];
            double[] trps = new double[totaldates];

            for (int i = 1; i <= totaldates; i++)
            {
                dates[i - 1] = agency.Rows[i].ItemArray.GetValue(0).ToString();
                sgls[i - 1] = Double.Parse(agency.Rows[i].ItemArray.GetValue(2).ToString());
                dbls[i - 1] = Double.Parse(agency.Rows[i].ItemArray.GetValue(3).ToString());
                trps[i - 1] = Double.Parse(agency.Rows[i].ItemArray.GetValue(4).ToString());
            }

            if (radioBB.Checked == true)
                bb = true;
            else if (radioNBB.Checked == true)
                bb = false;

            if (radioBar.Checked == true)
                nrf = false;
            else if (radioNRF.Checked == true)
                nrf = true;

            if (radioSgl.Checked == true)
                type = 0;
            else if (radioDbl.Checked == true)
                type = 1;
            else if (radioTrp.Checked == true)
                type = 2;

            double total = 0;            
;
            for (int i = 0; i < totaldates; i++)
            {
                DateTime current = DateTime.ParseExact(dates[i], "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

                if (DateTime.Compare(current.Date, arrdate.Date) >= 0 && DateTime.Compare(current.Date, depdate.Date) < 0) 
                {
                    String result;

                    int bb_total = type + 1 * 3;

                    if (!bb)
                    {
                        if (nrf)
                        {
                            if (nights >= 2)
                            {
                                if (type == 0)
                                    result = ((sgls[i] - bb_total) * 0.88).ToString();
                                else if (type == 1)
                                    result = ((dbls[i] - bb_total) * 0.88).ToString();
                                else
                                    result = ((trps[i] - bb_total) * 0.88).ToString();
                            }// end ndrf 2+ nights
                            else
                            {
                                if (type == 0)
                                    result = ((sgls[i] - bb_total) * 0.9).ToString();
                                else if (type == 1)
                                    result = ((dbls[i] - bb_total) * 0.9).ToString();
                                else
                                    result = ((trps[i] - bb_total) * 0.9).ToString();
                            }
                        }
                        else
                        {
                            if (type == 0)
                                result = (sgls[i] - bb_total).ToString();
                            else if (type == 1)
                                result = (dbls[i] - bb_total).ToString();
                            else
                                result = (trps[i] - bb_total).ToString();
                        }
                    }
                    else
                    {
                        if (nrf)
                        {
                            if (nights >= 2)
                            {
                                if (type == 0)
                                    result = (sgls[i] * 0.88).ToString();
                                else if (type == 1)
                                    result = (dbls[i] * 0.88).ToString();
                                else
                                    result = (trps[i] * 0.88).ToString();
                            }// end ndrf bb 2+ nights
                            else
                            {
                                if (type == 0)
                                    result = (sgls[i] * 0.9).ToString();
                                else if (type == 1)
                                    result = (dbls[i] * 0.9).ToString();
                                else
                                    result = (trps[i] * 0.9).ToString();
                            }
                        }// end nrf bb
                        else
                        {
                            if (type == 0)
                                result = (sgls[i]).ToString();
                            else if (type == 1)
                                result = (dbls[i]).ToString();
                            else
                                result = (trps[i]).ToString();
                        }
                    }
                    ListViewItem lvi = new ListViewItem(new[] { current.Date.ToString("dd/MM/yyyy"), (Math.Round(Double.Parse(result), 2)).ToString() });
                    listDays.Items.Add(lvi);

                    total = total + Double.Parse(result);
                    labelDaily.Text = "Daily: " + (Math.Round(total/nights, 2)).ToString();
                    labelTotal.Text = "Total: " + (Math.Round(total, 2)).ToString();

                }
            }
        }       

        private void clearListView(object sender, DateRangeEventArgs e)
        {
            clearListView();
        }        

        private void clearListView(object sender, EventArgs e)
        {
            clearListView();
        }   

        private void numericNights_ValueChanged(object sender, EventArgs e)
        {
            clearListView();
            depdate = arrdate.AddDays(Decimal.ToInt32(numericNights.Value));
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            clearListView();
            arrdate = dateTimePicker1.Value;
            depdate = arrdate.AddDays(Decimal.ToInt32(numericNights.Value));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearListView();
            agency = rates.Tables[comboBox1.SelectedIndex];
        }

        private void clearListView()
        {
            listDays.Items.Clear();
            labelDaily.Text = "Daily:";
            labelTotal.Text = "Total:";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void btnAddRoomType_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeleteMealPlan_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteRateType_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteRoomType_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMealPlan_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRateType_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Globalization;

namespace TryTaxCalculation20210716
{
    public partial class Form1 : Form
    {


        #region Events
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.label5_from.Visible = false; //隱藏日期
            this.label6_to.Visible = false;
            this.dateTimePicker1_startDate.Visible = false;
            this.dateTimePicker2_endDate.Visible = false;
            this.label5_result.Text = "";

            dateTimePicker1_startDate.Format = DateTimePickerFormat.Custom;
            dateTimePicker2_endDate.Format = DateTimePickerFormat.Custom;
            dateTimePicker1_startDate.CustomFormat = $"民國{dateTimePicker1_startDate.Value.Year - 1911}年MM月dd日";
            dateTimePicker2_endDate.CustomFormat = $"民國{dateTimePicker2_endDate.Value.Year - 1911}年MM月dd日";
        }

        private void radioButton1_allYear_CheckedChanged(object sender, EventArgs e)
        {
            this.label5_from.Visible = false; //隱藏日期
            this.label6_to.Visible = false;
            this.dateTimePicker1_startDate.Visible = false;
            this.dateTimePicker2_endDate.Visible = false;
            this.comboBox1_use.SelectedItem = null;
            this.comboBox2_cc.SelectedItem = null;
            this.label5_result.Text = "";
        }

        private void radioButton2_duration_CheckedChanged(object sender, EventArgs e)
        {
            this.label5_from.Visible = true; //顯示日期
            this.label6_to.Visible = true;
            this.dateTimePicker1_startDate.Visible = true;
            this.dateTimePicker2_endDate.Visible = true;
            this.comboBox1_use.SelectedItem = null;
            this.comboBox2_cc.SelectedItem = null;
            this.label5_result.Text = "";
        }


        private void comboBox1_use_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox2_cc.Items.Clear();
            if (comboBox1_use.SelectedItem as string == "機車")
            {
                this.comboBox2_cc.Items.Add("150以下 / 12HP以下(12.2PS以下)");
                this.comboBox2_cc.Items.Add("151-250 / 12.1-20HP(12.3-20.3PS)");
                this.comboBox2_cc.Items.Add("251-500 / 20.1HP以上(20.4PS以上)");
                this.comboBox2_cc.Items.Add("501-600");
                this.comboBox2_cc.Items.Add("601-1200");
                this.comboBox2_cc.Items.Add("1201-1800");
                this.comboBox2_cc.Items.Add("1801或以上");
            }
            else if (comboBox1_use.SelectedItem as string == "貨車")
            {
                this.comboBox2_cc.Items.Add("500以下");
                this.comboBox2_cc.Items.Add("501-600");
                this.comboBox2_cc.Items.Add("601-1200");
                this.comboBox2_cc.Items.Add("1201-1800");
                this.comboBox2_cc.Items.Add("1801-2400");
                this.comboBox2_cc.Items.Add("2401-3000 / 138HP以下(140.1PS以下)");
                this.comboBox2_cc.Items.Add("3001-3600");
                this.comboBox2_cc.Items.Add("3601-4200 / 138.1-200HP(140.2-203.0PS)");
                this.comboBox2_cc.Items.Add("4201-4800");
                this.comboBox2_cc.Items.Add("4801-5400 / 200.1-247HP(203.1-250.7PS)");
                this.comboBox2_cc.Items.Add("5401-6000");
                this.comboBox2_cc.Items.Add("6001-6600 / 247.1-286HP(250.8-290.3PS)");
                this.comboBox2_cc.Items.Add("6601-7200");
                this.comboBox2_cc.Items.Add("7201-7800 / 286.1-336HP(290.4-341.0PS)");
                this.comboBox2_cc.Items.Add("7801-8400");
                this.comboBox2_cc.Items.Add("8401-9000 / 336.1-361HP(341.1-366.4PS)");
                this.comboBox2_cc.Items.Add("9001-9600");
                this.comboBox2_cc.Items.Add("9601-10200 / 361.1HP以上(366.5PS以上)");
                this.comboBox2_cc.Items.Add("10201以上");
            }
            else if (comboBox1_use.SelectedItem as string == "大客車")
            {
                this.comboBox2_cc.Items.Add("600以下");
                this.comboBox2_cc.Items.Add("601-1200");
                this.comboBox2_cc.Items.Add("1201-1800");
                this.comboBox2_cc.Items.Add("1801-2400");
                this.comboBox2_cc.Items.Add("2401-3000 / 138HP以下(140.1PS以下)");
                this.comboBox2_cc.Items.Add("3001-3600");
                this.comboBox2_cc.Items.Add("3601-4200 / 138.1-200HP(140.2-203.0PS)");
                this.comboBox2_cc.Items.Add("4201-4800");
                this.comboBox2_cc.Items.Add("4801-5400 / 200.1-247HP(203.1-250.7PS)");
                this.comboBox2_cc.Items.Add("5401-6000");
                this.comboBox2_cc.Items.Add("6001-6600 / 247.1-286HP(250.8-290.3PS)");
                this.comboBox2_cc.Items.Add("6601-7200");
                this.comboBox2_cc.Items.Add("7201-7800 / 286.1-336HP(290.4-341.0PS)");
                this.comboBox2_cc.Items.Add("7801-8400");
                this.comboBox2_cc.Items.Add("8401-9000 / 336.1-361HP(341.1-366.4PS)");
                this.comboBox2_cc.Items.Add("9001-9600");
                this.comboBox2_cc.Items.Add("9601-10200 / 361.1HP以上(366.5PS以上)");
                this.comboBox2_cc.Items.Add("10201以上");
            }
            else if (comboBox1_use.SelectedItem as string == "自用小客車")
            {
                this.comboBox2_cc.Items.Add("500以下 / 38HP以下(38.6PS以下)");
                this.comboBox2_cc.Items.Add("501~600 / 38.1-56HP(38.7-56.8PS)");
                this.comboBox2_cc.Items.Add("601~1200 / 56.1-83HP(56.9-84.2PS)");
                this.comboBox2_cc.Items.Add("1201~1800 / 83.1-182HP(84.3-184.7PS)");
                this.comboBox2_cc.Items.Add("1801~2400 / 182.1-262HP(184.8-265.9PS)");
                this.comboBox2_cc.Items.Add("2401~3000 / 262.1-322HP(266-326.8PS)");
                this.comboBox2_cc.Items.Add("3001-4200 / 322.1-414HP(326.9-420.2PS)");
                this.comboBox2_cc.Items.Add("4201-5400 / 414.1-469HP(420.3-476.0PS)");
                this.comboBox2_cc.Items.Add("5401-6600 / 469.1-509HP(476.1-516.6PS)");
                this.comboBox2_cc.Items.Add("6601-7800 / 509.1HP以上(516.7PS以上)");
                this.comboBox2_cc.Items.Add("7801以上");
            }
            else if (comboBox1_use.SelectedItem as string == "營業用小客車")
            {
                this.comboBox2_cc.Items.Add("500以下 / 38HP以下(38.6PS以下)");
                this.comboBox2_cc.Items.Add("501~600 / 38.1-56HP(38.7-56.8PS)");
                this.comboBox2_cc.Items.Add("601~1200 / 56.1-83HP(56.9-84.2PS)");
                this.comboBox2_cc.Items.Add("1201~1800 / 83.1-182HP(84.3-184.7PS)");
                this.comboBox2_cc.Items.Add("1801~2400 / 182.1-262HP(184.8-265.9PS)");
                this.comboBox2_cc.Items.Add("2401~3000 / 262.1-322HP(266-326.8PS)");
                this.comboBox2_cc.Items.Add("3001-4200 / 322.1-414HP(326.9-420.2PS)");
                this.comboBox2_cc.Items.Add("4201-5400 / 414.1-469HP(420.3-476.0PS)");
                this.comboBox2_cc.Items.Add("5401-6600 / 469.1-509HP(476.1-516.6PS)");
                this.comboBox2_cc.Items.Add("6601-7800 / 509.1HP以上(516.7PS以上)");
                this.comboBox2_cc.Items.Add("7801以上");
            }
        }


        private void button1_calculate_Click(object sender, EventArgs e) //計算結果
        {
            if (radioButton1_allYear.Checked)
            {
                this.GetAllYear();
            }
            else
            {
                this.GetDuration();
            }
        }

        private void button2_reset_Click(object sender, EventArgs e) //重製
        {
            this.FormReset();
        }
        #endregion

        #region Custom Methods

        int leapOrNot;
        /// <summary>計算年值</summary>
        private void GetAllYear()
        {
            int laepYear = DateTime.Now.Year;
            if (DateTime.IsLeapYear(laepYear)) //判斷是否為閏年
            {
                leapOrNot = 366;
            }
            else
            {
                leapOrNot = 365;
            }

            if (comboBox1_use.SelectedItem == null || comboBox2_cc.SelectedItem == null)
            {
                this.label5_result.Text = "請選擇正確用途及CC數";
                return;
            }
            else
            {
                this.TaxCalculate();
            }

            this.label5_result.Text = $@"
             使用期間:民國{dateTimePicker1_startDate.Value.Year - 1911}年01月01日 ~ 民國{dateTimePicker2_endDate.Value.Year - 1911}年12月31日
             計算天數:365天
             汽缸CC數:{comboBox1_use.SelectedItem as string}
             用途:{comboBox2_cc.SelectedItem as string}
             計算公式:{taxValue}*{leapOrNot}/{leapOrNot} = {taxValue * leapOrNot / leapOrNot}元
             應納稅額: 共{taxValue}元";
        }

        int dateDuration;
        /// <summary>計算日期差值</summary>
        private void GetDuration()
        {
            //CultureInfo cui = new CultureInfo("zh-TW", true); 切換格式
            //cui.DateTimeFormat.Calendar = new TaiwanCalendar();
            //dateTimePicker1_startDate.CustomFormat = dateTimePicker1_startDate.Value.ToString("yy/M/d", cui);


            DateTime dateStart = dateTimePicker1_startDate.Value.Date;
            DateTime dateEnd = dateTimePicker2_endDate.Value.Date;
            dateDuration = new TimeSpan(dateEnd.Ticks - dateStart.Ticks).Days;

            if (comboBox1_use.SelectedItem == null || comboBox2_cc.SelectedItem == null)
            {
                this.label5_result.Text = "請選擇正確用途及CC數";
                return;
            }
            else if (dateStart >= dateEnd)
            {
                this.label5_result.Text = "請選擇正確日期";
                return;
            }
            else
            {
                this.TaxCalculate();
            }

            this.label5_result.Text = $@"
             使用期間:民國{ dateTimePicker1_startDate.Value.Year - 1911}年{dateTimePicker1_startDate.Value.Month}月{dateTimePicker1_startDate.Value.Day}日 ~ 民國{dateTimePicker2_endDate.Value.Year - 1911}年{dateTimePicker2_endDate.Value.Month}月{dateTimePicker2_endDate.Value.Day}日
             計算天數:{Convert.ToString(dateDuration)}天
             汽缸CC數:{comboBox1_use.SelectedItem as string}
             用途:{comboBox2_cc.SelectedItem as string}
             計算公式:{taxValue}*{dateDuration}/365 = {taxValue * dateDuration / 365}元
             應納稅額: 共{taxValue * dateDuration / 365}元";
        }

        /// <summary>控制項初始化</summary>
        private void FormReset()
        {
            this.label5_from.Visible = false; //隱藏日期
            this.label6_to.Visible = false;
            this.dateTimePicker1_startDate.Value = DateTime.Today;
            this.dateTimePicker2_endDate.Value = DateTime.Today;
            this.dateTimePicker1_startDate.Visible = false;
            this.dateTimePicker2_endDate.Visible = false;
            this.radioButton1_allYear.Checked = true;
            this.label5_result.Text = "";
            this.comboBox1_use.SelectedItem = null;
            this.comboBox2_cc.SelectedItem = null;
        }

        int taxValue;
        /// <summary>稅務公式 </summary>
        private void TaxCalculate()
        {
            if (comboBox1_use.SelectedItem as string == "機車" && comboBox2_cc.SelectedItem as string == "150以下 / 12HP以下(12.2PS以下)")
            {
                taxValue = 0;
            }
            else if (comboBox1_use.SelectedItem as string == "機車" && comboBox2_cc.SelectedItem as string == "151-250 / 12.1-20HP(12.3-20.3PS)")
            {
                taxValue = 800;
            }
            else if (comboBox1_use.SelectedItem as string == "機車" && comboBox2_cc.SelectedItem as string == "251-500 / 20.1HP以上(20.4PS以上)")
            {
                taxValue = 1620;
            }
            else if (comboBox1_use.SelectedItem as string == "機車" && comboBox2_cc.SelectedItem as string == "501-600")
            {
                taxValue = 2160;
            }
            else if (comboBox1_use.SelectedItem as string == "機車" && comboBox2_cc.SelectedItem as string == "601-1200")
            {
                taxValue = 4320;
            }
            else if (comboBox1_use.SelectedItem as string == "機車" && comboBox2_cc.SelectedItem as string == "1201-1800")
            {
                taxValue = 7120;
            }
            else if (comboBox1_use.SelectedItem as string == "機車" && comboBox2_cc.SelectedItem as string == "1801或以上")
            {
                taxValue = 11230;
            }
            else if (comboBox1_use.SelectedItem as string == "貨車" && comboBox2_cc.SelectedItem as string == "500以下")
            {
                taxValue = 900;
            }
            else if (comboBox1_use.SelectedItem as string == "貨車" && comboBox2_cc.SelectedItem as string == "501-600")
            {
                taxValue = 1080;
            }
            else if (comboBox1_use.SelectedItem as string == "貨車" && comboBox2_cc.SelectedItem as string == "601-1200")
            {
                taxValue = 1800;
            }
            else if (comboBox1_use.SelectedItem as string == "貨車" && comboBox2_cc.SelectedItem as string == "1201-1800")
            {
                taxValue = 2700;
            }
            else if (comboBox1_use.SelectedItem as string == "貨車" && comboBox2_cc.SelectedItem as string == "1801-2400")
            {
                taxValue = 3600;
            }
            else if (comboBox1_use.SelectedItem as string == "貨車" && comboBox2_cc.SelectedItem as string == "2401-3000 / 138HP以下(140.1PS以下)")
            {
                taxValue = 4500;
            }
            else if (comboBox1_use.SelectedItem as string == "貨車" && comboBox2_cc.SelectedItem as string == "3001-3600")
            {
                taxValue = 5400;
            }
            else if (comboBox1_use.SelectedItem as string == "貨車" && comboBox2_cc.SelectedItem as string == "3601-4200 / 138.1-200HP(140.2-203.0PS)")
            {
                taxValue = 6300;
            }
            else if (comboBox1_use.SelectedItem as string == "貨車" && comboBox2_cc.SelectedItem as string == "4201-4800")
            {
                taxValue = 7200;
            }
            else if (comboBox1_use.SelectedItem as string == "貨車" && comboBox2_cc.SelectedItem as string == "4801-5400 / 200.1-247HP(203.1-250.7PS)")
            {
                taxValue = 8100;
            }
            else if (comboBox1_use.SelectedItem as string == "貨車" && comboBox2_cc.SelectedItem as string == "5401-6000")
            {
                taxValue = 9000;
            }
            else if (comboBox1_use.SelectedItem as string == "貨車" && comboBox2_cc.SelectedItem as string == "6001-6600 / 247.1-286HP(250.8-290.3PS)")
            {
                taxValue = 9900;
            }
            else if (comboBox1_use.SelectedItem as string == "貨車" && comboBox2_cc.SelectedItem as string == "6601-7200")
            {
                taxValue = 10800;
            }
            else if (comboBox1_use.SelectedItem as string == "貨車" && comboBox2_cc.SelectedItem as string == "7201-7800 / 286.1-336HP(290.4-341.0PS)")
            {
                taxValue = 11700;
            }
            else if (comboBox1_use.SelectedItem as string == "貨車" && comboBox2_cc.SelectedItem as string == "7801-8400")
            {
                taxValue = 12600;
            }
            else if (comboBox1_use.SelectedItem as string == "貨車" && comboBox2_cc.SelectedItem as string == "8401-9000 / 336.1-361HP(341.1-366.4PS)")
            {
                taxValue = 13500;
            }
            else if (comboBox1_use.SelectedItem as string == "貨車" && comboBox2_cc.SelectedItem as string == "9001-9600")
            {
                taxValue = 14400;
            }
            else if (comboBox1_use.SelectedItem as string == "貨車" && comboBox2_cc.SelectedItem as string == "9601-10200 / 361.1HP以上(366.5PS以上)")
            {
                taxValue = 15300;
            }
            else if (comboBox1_use.SelectedItem as string == "貨車" && comboBox2_cc.SelectedItem as string == "10201以上")
            {
                taxValue = 16200;
            }
            else if (comboBox1_use.SelectedItem as string == "大客車" && comboBox2_cc.SelectedItem as string == "600以下")
            {
                taxValue = 1080;
            }
            else if (comboBox1_use.SelectedItem as string == "大客車" && comboBox2_cc.SelectedItem as string == "601-1200")
            {
                taxValue = 1800;
            }
            else if (comboBox1_use.SelectedItem as string == "大客車" && comboBox2_cc.SelectedItem as string == "1201-1800")
            {
                taxValue = 2700;
            }
            else if (comboBox1_use.SelectedItem as string == "大客車" && comboBox2_cc.SelectedItem as string == "1801-2400")
            {
                taxValue = 3600;
            }
            else if (comboBox1_use.SelectedItem as string == "大客車" && comboBox2_cc.SelectedItem as string == "2401-3000 / 138HP以下(140.1PS以下)")
            {
                taxValue = 4500;
            }
            else if (comboBox1_use.SelectedItem as string == "大客車" && comboBox2_cc.SelectedItem as string == "3001-3600")
            {
                taxValue = 5400;
            }
            else if (comboBox1_use.SelectedItem as string == "大客車" && comboBox2_cc.SelectedItem as string == "3601-4200 / 138.1-200HP(140.2-203.0PS)")
            {
                taxValue = 6300;
            }
            else if (comboBox1_use.SelectedItem as string == "大客車" && comboBox2_cc.SelectedItem as string == "4201-4800")
            {
                taxValue = 7200;
            }
            else if (comboBox1_use.SelectedItem as string == "大客車" && comboBox2_cc.SelectedItem as string == "4801-5400 / 200.1-247HP(203.1-250.7PS)")
            {
                taxValue = 8100;
            }
            else if (comboBox1_use.SelectedItem as string == "大客車" && comboBox2_cc.SelectedItem as string == "5401-6000")
            {
                taxValue = 9000;
            }
            else if (comboBox1_use.SelectedItem as string == "大客車" && comboBox2_cc.SelectedItem as string == "6001-6600 / 247.1-286HP(250.8-290.3PS)")
            {
                taxValue = 9900;
            }
            else if (comboBox1_use.SelectedItem as string == "大客車" && comboBox2_cc.SelectedItem as string == "6601-7200")
            {
                taxValue = 10800;
            }
            else if (comboBox1_use.SelectedItem as string == "大客車" && comboBox2_cc.SelectedItem as string == "7201-7800 / 286.1-336HP(290.4-341.0PS)")
            {
                taxValue = 11700;
            }
            else if (comboBox1_use.SelectedItem as string == "大客車" && comboBox2_cc.SelectedItem as string == "7801-8400")
            {
                taxValue = 12600;
            }
            else if (comboBox1_use.SelectedItem as string == "大客車" && comboBox2_cc.SelectedItem as string == "8401-9000 / 336.1-361HP(341.1-366.4PS)")
            {
                taxValue = 13500;
            }
            else if (comboBox1_use.SelectedItem as string == "大客車" && comboBox2_cc.SelectedItem as string == "9001-9600")
            {
                taxValue = 14400;
            }
            else if (comboBox1_use.SelectedItem as string == "大客車" && comboBox2_cc.SelectedItem as string == "9601-10200 / 361.1HP以上(366.5PS以上)")
            {
                taxValue = 15300;
            }
            else if (comboBox1_use.SelectedItem as string == "大客車" && comboBox2_cc.SelectedItem as string == "10201以上")
            {
                taxValue = 16200;
            }
            else if (comboBox1_use.SelectedItem as string == "自用小客車" && comboBox2_cc.SelectedItem as string == "500以下 / 38HP以下(38.6PS以下)")
            {
                taxValue = 1620;
            }
            else if (comboBox1_use.SelectedItem as string == "自用小客車" && comboBox2_cc.SelectedItem as string == "501~600 / 38.1-56HP(38.7-56.8PS)")
            {
                taxValue = 2160;
            }
            else if (comboBox1_use.SelectedItem as string == "自用小客車" && comboBox2_cc.SelectedItem as string == "601~1200 / 56.1-83HP(56.9-84.2PS)")
            {
                taxValue = 4320;
            }
            else if (comboBox1_use.SelectedItem as string == "自用小客車" && comboBox2_cc.SelectedItem as string == "1201~1800 / 83.1-182HP(84.3-184.7PS)")
            {
                taxValue = 7120;
            }
            else if (comboBox1_use.SelectedItem as string == "自用小客車" && comboBox2_cc.SelectedItem as string == "1801~2400 / 182.1-262HP(184.8-265.9PS)")
            {
                taxValue = 11230;
            }
            else if (comboBox1_use.SelectedItem as string == "自用小客車" && comboBox2_cc.SelectedItem as string == "2401~3000 / 262.1-322HP(266-326.8PS)")
            {
                taxValue = 15210;
            }
            else if (comboBox1_use.SelectedItem as string == "自用小客車" && comboBox2_cc.SelectedItem as string == "3001-4200 / 322.1-414HP(326.9-420.2PS)")
            {
                taxValue = 28220;
            }
            else if (comboBox1_use.SelectedItem as string == "自用小客車" && comboBox2_cc.SelectedItem as string == "4201-5400 / 414.1-469HP(420.3-476.0PS)")
            {
                taxValue = 46170;
            }
            else if (comboBox1_use.SelectedItem as string == "自用小客車" && comboBox2_cc.SelectedItem as string == "5401-6600 / 469.1-509HP(476.1-516.6PS)")
            {
                taxValue = 69690;
            }
            else if (comboBox1_use.SelectedItem as string == "自用小客車" && comboBox2_cc.SelectedItem as string == "6601-7800 / 509.1HP以上(516.7PS以上)")
            {
                taxValue = 117000;
            }
            else if (comboBox1_use.SelectedItem as string == "自用小客車" && comboBox2_cc.SelectedItem as string == "7801以上")
            {
                taxValue = 151200;
            }
            else if (comboBox1_use.SelectedItem as string == "營業用小客車" && comboBox2_cc.SelectedItem as string == "500以下 / 38HP以下(38.6PS以下)")
            {
                taxValue = 900;
            }
            else if (comboBox1_use.SelectedItem as string == "營業用小客車" && comboBox2_cc.SelectedItem as string == "501~600 / 38.1-56HP(38.7-56.8PS)")
            {
                taxValue = 1260;
            }
            else if (comboBox1_use.SelectedItem as string == "營業用小客車" && comboBox2_cc.SelectedItem as string == "601~1200 / 56.1-83HP(56.9-84.2PS)")
            {
                taxValue = 2160;
            }
            else if (comboBox1_use.SelectedItem as string == "營業用小客車" && comboBox2_cc.SelectedItem as string == "1201~1800 / 83.1-182HP(84.3-184.7PS)")
            {
                taxValue = 3060;
            }
            else if (comboBox1_use.SelectedItem as string == "營業用小客車" && comboBox2_cc.SelectedItem as string == "1801~2400 / 182.1-262HP(184.8-265.9PS)")
            {
                taxValue = 6480;
            }
            else if (comboBox1_use.SelectedItem as string == "營業用小客車" && comboBox2_cc.SelectedItem as string == "2401~3000 / 262.1-322HP(266-326.8PS)")
            {
                taxValue = 9900;
            }
            else if (comboBox1_use.SelectedItem as string == "營業用小客車" && comboBox2_cc.SelectedItem as string == "3001-4200 / 322.1-414HP(326.9-420.2PS)")
            {
                taxValue = 16380;
            }
            else if (comboBox1_use.SelectedItem as string == "營業用小客車" && comboBox2_cc.SelectedItem as string == "4201-5400 / 414.1-469HP(420.3-476.0PS)")
            {
                taxValue = 24300;
            }
            else if (comboBox1_use.SelectedItem as string == "營業用小客車" && comboBox2_cc.SelectedItem as string == "5401-6600 / 469.1-509HP(476.1-516.6PS)")
            {
                taxValue = 33660;
            }
            else if (comboBox1_use.SelectedItem as string == "營業用小客車" && comboBox2_cc.SelectedItem as string == "6601-7800 / 509.1HP以上(516.7PS以上)")
            {
                taxValue = 44460;
            }
            else if (comboBox1_use.SelectedItem as string == "營業用小客車" && comboBox2_cc.SelectedItem as string == "7801以上")
            {
                taxValue = 56700;
            }
            #endregion


        }
    }
}

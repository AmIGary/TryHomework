
namespace TryTaxCalculation20210716
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1_allYear = new System.Windows.Forms.RadioButton();
            this.radioButton2_duration = new System.Windows.Forms.RadioButton();
            this.label5_from = new System.Windows.Forms.Label();
            this.label6_to = new System.Windows.Forms.Label();
            this.comboBox1_use = new System.Windows.Forms.ComboBox();
            this.comboBox2_cc = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1_startDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2_endDate = new System.Windows.Forms.DateTimePicker();
            this.button1_calculate = new System.Windows.Forms.Button();
            this.button2_reset = new System.Windows.Forms.Button();
            this.label5_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "使用期間";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "用途";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "汽缸CC數／馬達馬力";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "試算結果";
            // 
            // radioButton1_allYear
            // 
            this.radioButton1_allYear.AutoSize = true;
            this.radioButton1_allYear.Location = new System.Drawing.Point(120, 22);
            this.radioButton1_allYear.Name = "radioButton1_allYear";
            this.radioButton1_allYear.Size = new System.Drawing.Size(73, 19);
            this.radioButton1_allYear.TabIndex = 4;
            this.radioButton1_allYear.TabStop = true;
            this.radioButton1_allYear.Text = "全年度";
            this.radioButton1_allYear.UseVisualStyleBackColor = true;
            this.radioButton1_allYear.CheckedChanged += new System.EventHandler(this.radioButton1_allYear_CheckedChanged);
            // 
            // radioButton2_duration
            // 
            this.radioButton2_duration.AutoSize = true;
            this.radioButton2_duration.Location = new System.Drawing.Point(255, 22);
            this.radioButton2_duration.Name = "radioButton2_duration";
            this.radioButton2_duration.Size = new System.Drawing.Size(73, 19);
            this.radioButton2_duration.TabIndex = 5;
            this.radioButton2_duration.TabStop = true;
            this.radioButton2_duration.Text = "依期間";
            this.radioButton2_duration.UseVisualStyleBackColor = true;
            this.radioButton2_duration.CheckedChanged += new System.EventHandler(this.radioButton2_duration_CheckedChanged);
            // 
            // label5_from
            // 
            this.label5_from.AutoSize = true;
            this.label5_from.Location = new System.Drawing.Point(388, 24);
            this.label5_from.Name = "label5_from";
            this.label5_from.Size = new System.Drawing.Size(22, 15);
            this.label5_from.TabIndex = 6;
            this.label5_from.Text = "從";
            // 
            // label6_to
            // 
            this.label6_to.AutoSize = true;
            this.label6_to.Location = new System.Drawing.Point(652, 24);
            this.label6_to.Name = "label6_to";
            this.label6_to.Size = new System.Drawing.Size(22, 15);
            this.label6_to.TabIndex = 7;
            this.label6_to.Text = "至";
            // 
            // comboBox1_use
            // 
            this.comboBox1_use.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1_use.FormattingEnabled = true;
            this.comboBox1_use.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.comboBox1_use.Location = new System.Drawing.Point(195, 81);
            this.comboBox1_use.Name = "comboBox1_use";
            this.comboBox1_use.Size = new System.Drawing.Size(209, 23);
            this.comboBox1_use.TabIndex = 10;
            this.comboBox1_use.SelectedIndexChanged += new System.EventHandler(this.comboBox1_use_SelectedIndexChanged);
            // 
            // comboBox2_cc
            // 
            this.comboBox2_cc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2_cc.FormattingEnabled = true;
            this.comboBox2_cc.Location = new System.Drawing.Point(195, 136);
            this.comboBox2_cc.Name = "comboBox2_cc";
            this.comboBox2_cc.Size = new System.Drawing.Size(209, 23);
            this.comboBox2_cc.TabIndex = 11;
            // 
            // dateTimePicker1_startDate
            // 
            this.dateTimePicker1_startDate.Location = new System.Drawing.Point(427, 22);
            this.dateTimePicker1_startDate.Name = "dateTimePicker1_startDate";
            this.dateTimePicker1_startDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1_startDate.TabIndex = 15;
            this.dateTimePicker1_startDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_startDate_ValueChanged);
            // 
            // dateTimePicker2_endDate
            // 
            this.dateTimePicker2_endDate.Location = new System.Drawing.Point(695, 22);
            this.dateTimePicker2_endDate.Name = "dateTimePicker2_endDate";
            this.dateTimePicker2_endDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2_endDate.TabIndex = 16;
            this.dateTimePicker2_endDate.ValueChanged += new System.EventHandler(this.dateTimePicker2_endDate_ValueChanged);
            // 
            // button1_calculate
            // 
            this.button1_calculate.Location = new System.Drawing.Point(498, 301);
            this.button1_calculate.Name = "button1_calculate";
            this.button1_calculate.Size = new System.Drawing.Size(75, 23);
            this.button1_calculate.TabIndex = 17;
            this.button1_calculate.Text = "button1";
            this.button1_calculate.UseVisualStyleBackColor = true;
            this.button1_calculate.Click += new System.EventHandler(this.button1_calculate_Click);
            // 
            // button2_reset
            // 
            this.button2_reset.Location = new System.Drawing.Point(708, 301);
            this.button2_reset.Name = "button2_reset";
            this.button2_reset.Size = new System.Drawing.Size(75, 23);
            this.button2_reset.TabIndex = 18;
            this.button2_reset.Text = "button2";
            this.button2_reset.UseVisualStyleBackColor = true;
            this.button2_reset.Click += new System.EventHandler(this.button2_reset_Click);
            // 
            // label5_result
            // 
            this.label5_result.AutoSize = true;
            this.label5_result.Location = new System.Drawing.Point(116, 195);
            this.label5_result.Name = "label5_result";
            this.label5_result.Size = new System.Drawing.Size(43, 15);
            this.label5_result.TabIndex = 19;
            this.label5_result.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 453);
            this.Controls.Add(this.label5_result);
            this.Controls.Add(this.button2_reset);
            this.Controls.Add(this.button1_calculate);
            this.Controls.Add(this.dateTimePicker2_endDate);
            this.Controls.Add(this.dateTimePicker1_startDate);
            this.Controls.Add(this.comboBox2_cc);
            this.Controls.Add(this.comboBox1_use);
            this.Controls.Add(this.label6_to);
            this.Controls.Add(this.label5_from);
            this.Controls.Add(this.radioButton2_duration);
            this.Controls.Add(this.radioButton1_allYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1_allYear;
        private System.Windows.Forms.RadioButton radioButton2_duration;
        private System.Windows.Forms.Label label5_from;
        private System.Windows.Forms.Label label6_to;
        private System.Windows.Forms.ComboBox comboBox1_use;
        private System.Windows.Forms.ComboBox comboBox2_cc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_startDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2_endDate;
        private System.Windows.Forms.Button button1_calculate;
        private System.Windows.Forms.Button button2_reset;
        private System.Windows.Forms.Label label5_result;
    }
}


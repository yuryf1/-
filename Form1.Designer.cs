namespace Брахман
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxHealth = new System.Windows.Forms.TextBox();
			this.textBoxSex = new System.Windows.Forms.TextBox();
			this.textBoxBusiness = new System.Windows.Forms.TextBox();
			this.textBoxSuperman = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.BusinessDay1 = new System.Windows.Forms.TextBox();
			this.SupermanDay1 = new System.Windows.Forms.TextBox();
			this.SexDay1 = new System.Windows.Forms.TextBox();
			this.HealthDay1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.BusinessDay11 = new System.Windows.Forms.TextBox();
			this.SupermanDay11 = new System.Windows.Forms.TextBox();
			this.SexDay11 = new System.Windows.Forms.TextBox();
			this.HealthDay11 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.textBoxOut = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(348, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Добро пожаловать в программу расчета эффективности Брахман.";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(200, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Сколько часов Вы уделяете в день...?";
			// 
			// textBoxHealth
			// 
			this.textBoxHealth.Location = new System.Drawing.Point(161, 148);
			this.textBoxHealth.MaxLength = 3;
			this.textBoxHealth.Name = "textBoxHealth";
			this.textBoxHealth.Size = new System.Drawing.Size(29, 20);
			this.textBoxHealth.TabIndex = 2;
			this.textBoxHealth.Text = "0";
			this.textBoxHealth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			this.textBoxHealth.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxHealth_Validating);
			// 
			// textBoxSex
			// 
			this.textBoxSex.Location = new System.Drawing.Point(161, 174);
			this.textBoxSex.MaxLength = 3;
			this.textBoxSex.Name = "textBoxSex";
			this.textBoxSex.Size = new System.Drawing.Size(29, 20);
			this.textBoxSex.TabIndex = 3;
			this.textBoxSex.Text = "0";
			this.textBoxSex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			this.textBoxSex.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxHealth_Validating);
			// 
			// textBoxBusiness
			// 
			this.textBoxBusiness.Location = new System.Drawing.Point(161, 223);
			this.textBoxBusiness.MaxLength = 3;
			this.textBoxBusiness.Name = "textBoxBusiness";
			this.textBoxBusiness.Size = new System.Drawing.Size(29, 20);
			this.textBoxBusiness.TabIndex = 5;
			this.textBoxBusiness.Text = "0";
			this.textBoxBusiness.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			this.textBoxBusiness.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxHealth_Validating);
			// 
			// textBoxSuperman
			// 
			this.textBoxSuperman.Location = new System.Drawing.Point(161, 197);
			this.textBoxSuperman.MaxLength = 3;
			this.textBoxSuperman.Name = "textBoxSuperman";
			this.textBoxSuperman.Size = new System.Drawing.Size(29, 20);
			this.textBoxSuperman.TabIndex = 4;
			this.textBoxSuperman.Text = "0";
			this.textBoxSuperman.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			this.textBoxSuperman.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxHealth_Validating);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(196, 149);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 94);
			this.button1.TabIndex = 6;
			this.button1.Text = "Расчет";
			this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// BusinessDay1
			// 
			this.BusinessDay1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BusinessDay1.Location = new System.Drawing.Point(277, 224);
			this.BusinessDay1.Name = "BusinessDay1";
			this.BusinessDay1.ReadOnly = true;
			this.BusinessDay1.Size = new System.Drawing.Size(26, 20);
			this.BusinessDay1.TabIndex = 10;
			// 
			// SupermanDay1
			// 
			this.SupermanDay1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SupermanDay1.Location = new System.Drawing.Point(277, 198);
			this.SupermanDay1.Name = "SupermanDay1";
			this.SupermanDay1.ReadOnly = true;
			this.SupermanDay1.Size = new System.Drawing.Size(26, 20);
			this.SupermanDay1.TabIndex = 9;
			// 
			// SexDay1
			// 
			this.SexDay1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SexDay1.Location = new System.Drawing.Point(277, 175);
			this.SexDay1.Name = "SexDay1";
			this.SexDay1.ReadOnly = true;
			this.SexDay1.Size = new System.Drawing.Size(26, 20);
			this.SexDay1.TabIndex = 8;
			// 
			// HealthDay1
			// 
			this.HealthDay1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.HealthDay1.Location = new System.Drawing.Point(277, 149);
			this.HealthDay1.Name = "HealthDay1";
			this.HealthDay1.ReadOnly = true;
			this.HealthDay1.Size = new System.Drawing.Size(26, 20);
			this.HealthDay1.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(131, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "КРАСОТЕ И ЗВОРОВЬЮ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(25, 181);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "СЕКСУ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(25, 204);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "САМОРАЗВИТИЮ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(25, 230);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "БИЗНЕСУ";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(274, 118);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(91, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "Рекомендовано:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(19, 75);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(176, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "Какое обычно у Вас настроение?";
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "отличное",
            "хорошее",
            "нормальное",
            "плохое",
            "ужасное"});
			this.comboBox1.Location = new System.Drawing.Point(196, 67);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(199, 21);
			this.comboBox1.TabIndex = 17;
			// 
			// BusinessDay11
			// 
			this.BusinessDay11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BusinessDay11.Location = new System.Drawing.Point(323, 224);
			this.BusinessDay11.MaxLength = 2;
			this.BusinessDay11.Name = "BusinessDay11";
			this.BusinessDay11.ReadOnly = true;
			this.BusinessDay11.Size = new System.Drawing.Size(42, 20);
			this.BusinessDay11.TabIndex = 21;
			// 
			// SupermanDay11
			// 
			this.SupermanDay11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SupermanDay11.Location = new System.Drawing.Point(323, 198);
			this.SupermanDay11.MaxLength = 2;
			this.SupermanDay11.Name = "SupermanDay11";
			this.SupermanDay11.ReadOnly = true;
			this.SupermanDay11.Size = new System.Drawing.Size(42, 20);
			this.SupermanDay11.TabIndex = 20;
			// 
			// SexDay11
			// 
			this.SexDay11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SexDay11.Location = new System.Drawing.Point(323, 175);
			this.SexDay11.MaxLength = 2;
			this.SexDay11.Name = "SexDay11";
			this.SexDay11.ReadOnly = true;
			this.SexDay11.Size = new System.Drawing.Size(42, 20);
			this.SexDay11.TabIndex = 19;
			// 
			// HealthDay11
			// 
			this.HealthDay11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.HealthDay11.Location = new System.Drawing.Point(323, 149);
			this.HealthDay11.MaxLength = 2;
			this.HealthDay11.Name = "HealthDay11";
			this.HealthDay11.ReadOnly = true;
			this.HealthDay11.Size = new System.Drawing.Size(42, 20);
			this.HealthDay11.TabIndex = 18;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(305, 155);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(12, 13);
			this.label9.TabIndex = 22;
			this.label9.Text = "ч";
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(305, 182);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(12, 13);
			this.label10.TabIndex = 23;
			this.label10.Text = "ч";
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(305, 205);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(12, 13);
			this.label11.TabIndex = 24;
			this.label11.Text = "ч";
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(305, 230);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(12, 13);
			this.label12.TabIndex = 25;
			this.label12.Text = "ч";
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(371, 156);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(27, 13);
			this.label13.TabIndex = 26;
			this.label13.Text = "мин";
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(371, 182);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(27, 13);
			this.label14.TabIndex = 27;
			this.label14.Text = "мин";
			// 
			// label15
			// 
			this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(371, 205);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(27, 13);
			this.label15.TabIndex = 28;
			this.label15.Text = "мин";
			// 
			// label16
			// 
			this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(371, 231);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(27, 13);
			this.label16.TabIndex = 29;
			this.label16.Text = "мин";
			// 
			// trackBar1
			// 
			this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.trackBar1.Location = new System.Drawing.Point(188, 272);
			this.trackBar1.Maximum = 12;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(210, 45);
			this.trackBar1.TabIndex = 30;
			this.trackBar1.Value = 8;
			this.trackBar1.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxHealth_Validating);
			// 
			// label17
			// 
			this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(19, 282);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(163, 13);
			this.label17.TabIndex = 31;
			this.label17.Text = "Ваша продолжительность сна:";
			// 
			// label18
			// 
			this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(376, 304);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(19, 13);
			this.label18.TabIndex = 32;
			this.label18.Text = "12";
			// 
			// label19
			// 
			this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(196, 304);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(13, 13);
			this.label19.TabIndex = 33;
			this.label19.Text = "0";
			// 
			// label20
			// 
			this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(318, 304);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(13, 13);
			this.label20.TabIndex = 34;
			this.label20.Text = "8";
			// 
			// label21
			// 
			this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(345, 304);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(19, 13);
			this.label21.TabIndex = 35;
			this.label21.Text = "10";
			// 
			// label22
			// 
			this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(256, 304);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(13, 13);
			this.label22.TabIndex = 36;
			this.label22.Text = "4";
			// 
			// textBoxOut
			// 
			this.textBoxOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxOut.Location = new System.Drawing.Point(28, 334);
			this.textBoxOut.Multiline = true;
			this.textBoxOut.Name = "textBoxOut";
			this.textBoxOut.ReadOnly = true;
			this.textBoxOut.Size = new System.Drawing.Size(367, 46);
			this.textBoxOut.TabIndex = 37;
			this.textBoxOut.Text = "КРАСОТА И ЗДОРОВЬЕ    0,5 - 1,5 ч         САМОРАЗВИТИЕ    1,0 - 3,0 ч\r\n\r\nСЕКС    " +
    "                                0,5 - 2,5 ч         БИЗНЕС                   3,0" +
    " - 8,0 ч";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 394);
			this.Controls.Add(this.textBoxOut);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.BusinessDay11);
			this.Controls.Add(this.SupermanDay11);
			this.Controls.Add(this.SexDay11);
			this.Controls.Add(this.HealthDay11);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.BusinessDay1);
			this.Controls.Add(this.SupermanDay1);
			this.Controls.Add(this.SexDay1);
			this.Controls.Add(this.HealthDay1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBoxBusiness);
			this.Controls.Add(this.textBoxSuperman);
			this.Controls.Add(this.textBoxSex);
			this.Controls.Add(this.textBoxHealth);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(550, 430);
			this.Name = "Form1";
			this.Text = "Брахман";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHealth;
        private System.Windows.Forms.TextBox textBoxSex;
        private System.Windows.Forms.TextBox textBoxBusiness;
        private System.Windows.Forms.TextBox textBoxSuperman;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BusinessDay1;
        private System.Windows.Forms.TextBox SupermanDay1;
        private System.Windows.Forms.TextBox SexDay1;
        private System.Windows.Forms.TextBox HealthDay1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox BusinessDay11;
        private System.Windows.Forms.TextBox SupermanDay11;
        private System.Windows.Forms.TextBox SexDay11;
        private System.Windows.Forms.TextBox HealthDay11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxOut;
    }
}


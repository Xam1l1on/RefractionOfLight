namespace RefractionOfLight
{
    partial class WorkForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_MediaOne = new System.Windows.Forms.GroupBox();
            this.radioButton_MediaOneGlass = new System.Windows.Forms.RadioButton();
            this.radioButton_MediaOneOil = new System.Windows.Forms.RadioButton();
            this.radioButton_MediaOneWater = new System.Windows.Forms.RadioButton();
            this.radioButton_MediaOneAir = new System.Windows.Forms.RadioButton();
            this.groupBox_MediaTwo = new System.Windows.Forms.GroupBox();
            this.radioButton_MediaTwoGlass = new System.Windows.Forms.RadioButton();
            this.radioButton_MediaTwoOil = new System.Windows.Forms.RadioButton();
            this.radioButton_MediaTwoWater = new System.Windows.Forms.RadioButton();
            this.radioButton_MediaTwoAir = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_AngleOfRefraction = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_SinAlpha = new System.Windows.Forms.NumericUpDown();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox_MediaOne.SuspendLayout();
            this.groupBox_MediaTwo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SinAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_MediaOne
            // 
            this.groupBox_MediaOne.Controls.Add(this.radioButton_MediaOneGlass);
            this.groupBox_MediaOne.Controls.Add(this.radioButton_MediaOneOil);
            this.groupBox_MediaOne.Controls.Add(this.radioButton_MediaOneWater);
            this.groupBox_MediaOne.Controls.Add(this.radioButton_MediaOneAir);
            this.groupBox_MediaOne.Location = new System.Drawing.Point(886, 32);
            this.groupBox_MediaOne.Name = "groupBox_MediaOne";
            this.groupBox_MediaOne.Size = new System.Drawing.Size(300, 150);
            this.groupBox_MediaOne.TabIndex = 0;
            this.groupBox_MediaOne.TabStop = false;
            this.groupBox_MediaOne.Text = "Выбор первой среды";
            // 
            // radioButton_MediaOneGlass
            // 
            this.radioButton_MediaOneGlass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_MediaOneGlass.Location = new System.Drawing.Point(170, 90);
            this.radioButton_MediaOneGlass.Name = "radioButton_MediaOneGlass";
            this.radioButton_MediaOneGlass.Size = new System.Drawing.Size(100, 25);
            this.radioButton_MediaOneGlass.TabIndex = 3;
            this.radioButton_MediaOneGlass.Text = "Стекло";
            this.radioButton_MediaOneGlass.UseVisualStyleBackColor = true;
            // 
            // radioButton_MediaOneOil
            // 
            this.radioButton_MediaOneOil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_MediaOneOil.Location = new System.Drawing.Point(170, 22);
            this.radioButton_MediaOneOil.Name = "radioButton_MediaOneOil";
            this.radioButton_MediaOneOil.Size = new System.Drawing.Size(100, 30);
            this.radioButton_MediaOneOil.TabIndex = 2;
            this.radioButton_MediaOneOil.Text = "Масло";
            this.radioButton_MediaOneOil.UseVisualStyleBackColor = true;
            // 
            // radioButton_MediaOneWater
            // 
            this.radioButton_MediaOneWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_MediaOneWater.Location = new System.Drawing.Point(30, 90);
            this.radioButton_MediaOneWater.Name = "radioButton_MediaOneWater";
            this.radioButton_MediaOneWater.Size = new System.Drawing.Size(100, 30);
            this.radioButton_MediaOneWater.TabIndex = 1;
            this.radioButton_MediaOneWater.Text = "Вода";
            this.radioButton_MediaOneWater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_MediaOneWater.UseVisualStyleBackColor = true;
            // 
            // radioButton_MediaOneAir
            // 
            this.radioButton_MediaOneAir.Checked = true;
            this.radioButton_MediaOneAir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_MediaOneAir.Location = new System.Drawing.Point(30, 22);
            this.radioButton_MediaOneAir.Name = "radioButton_MediaOneAir";
            this.radioButton_MediaOneAir.Size = new System.Drawing.Size(100, 30);
            this.radioButton_MediaOneAir.TabIndex = 0;
            this.radioButton_MediaOneAir.TabStop = true;
            this.radioButton_MediaOneAir.Text = "Воздух";
            this.radioButton_MediaOneAir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_MediaOneAir.UseVisualStyleBackColor = true;
            // 
            // groupBox_MediaTwo
            // 
            this.groupBox_MediaTwo.Controls.Add(this.radioButton_MediaTwoGlass);
            this.groupBox_MediaTwo.Controls.Add(this.radioButton_MediaTwoOil);
            this.groupBox_MediaTwo.Controls.Add(this.radioButton_MediaTwoWater);
            this.groupBox_MediaTwo.Controls.Add(this.radioButton_MediaTwoAir);
            this.groupBox_MediaTwo.Location = new System.Drawing.Point(886, 212);
            this.groupBox_MediaTwo.Name = "groupBox_MediaTwo";
            this.groupBox_MediaTwo.Size = new System.Drawing.Size(300, 150);
            this.groupBox_MediaTwo.TabIndex = 1;
            this.groupBox_MediaTwo.TabStop = false;
            this.groupBox_MediaTwo.Text = "Выбор второй среды";
            // 
            // radioButton_MediaTwoGlass
            // 
            this.radioButton_MediaTwoGlass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_MediaTwoGlass.Location = new System.Drawing.Point(170, 90);
            this.radioButton_MediaTwoGlass.Name = "radioButton_MediaTwoGlass";
            this.radioButton_MediaTwoGlass.Size = new System.Drawing.Size(100, 25);
            this.radioButton_MediaTwoGlass.TabIndex = 7;
            this.radioButton_MediaTwoGlass.Text = "Стекло";
            this.radioButton_MediaTwoGlass.UseVisualStyleBackColor = true;
            // 
            // radioButton_MediaTwoOil
            // 
            this.radioButton_MediaTwoOil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_MediaTwoOil.Location = new System.Drawing.Point(170, 30);
            this.radioButton_MediaTwoOil.Name = "radioButton_MediaTwoOil";
            this.radioButton_MediaTwoOil.Size = new System.Drawing.Size(100, 25);
            this.radioButton_MediaTwoOil.TabIndex = 6;
            this.radioButton_MediaTwoOil.Text = "Масло";
            this.radioButton_MediaTwoOil.UseVisualStyleBackColor = true;
            // 
            // radioButton_MediaTwoWater
            // 
            this.radioButton_MediaTwoWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_MediaTwoWater.Location = new System.Drawing.Point(30, 90);
            this.radioButton_MediaTwoWater.Name = "radioButton_MediaTwoWater";
            this.radioButton_MediaTwoWater.Size = new System.Drawing.Size(100, 30);
            this.radioButton_MediaTwoWater.TabIndex = 5;
            this.radioButton_MediaTwoWater.Text = "Вода";
            this.radioButton_MediaTwoWater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_MediaTwoWater.UseVisualStyleBackColor = true;
            // 
            // radioButton_MediaTwoAir
            // 
            this.radioButton_MediaTwoAir.Checked = true;
            this.radioButton_MediaTwoAir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_MediaTwoAir.Location = new System.Drawing.Point(30, 30);
            this.radioButton_MediaTwoAir.Name = "radioButton_MediaTwoAir";
            this.radioButton_MediaTwoAir.Size = new System.Drawing.Size(100, 30);
            this.radioButton_MediaTwoAir.TabIndex = 4;
            this.radioButton_MediaTwoAir.TabStop = true;
            this.radioButton_MediaTwoAir.Text = "Воздух";
            this.radioButton_MediaTwoAir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_MediaTwoAir.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_AngleOfRefraction);
            this.panel1.Location = new System.Drawing.Point(103, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 500);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox_AngleOfRefraction
            // 
            this.textBox_AngleOfRefraction.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_AngleOfRefraction.Location = new System.Drawing.Point(574, 465);
            this.textBox_AngleOfRefraction.Name = "textBox_AngleOfRefraction";
            this.textBox_AngleOfRefraction.Size = new System.Drawing.Size(56, 20);
            this.textBox_AngleOfRefraction.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Угол падения =";
            // 
            // numericUpDown_SinAlpha
            // 
            this.numericUpDown_SinAlpha.BackColor = System.Drawing.SystemColors.Control;
            this.numericUpDown_SinAlpha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown_SinAlpha.Location = new System.Drawing.Point(103, 535);
            this.numericUpDown_SinAlpha.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpDown_SinAlpha.Name = "numericUpDown_SinAlpha";
            this.numericUpDown_SinAlpha.Size = new System.Drawing.Size(45, 16);
            this.numericUpDown_SinAlpha.TabIndex = 6;
            this.numericUpDown_SinAlpha.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numericUpDown_SinAlpha.ValueChanged += new System.EventHandler(this.numericUpDown_SinAlpha_ValueChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(25, 12);
            this.trackBar1.Maximum = 90;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 500);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 45;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(1086, 560);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 60);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // RefractionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.numericUpDown_SinAlpha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_MediaTwo);
            this.Controls.Add(this.groupBox_MediaOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RefractionForm";
            this.Text = "Преломление света";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RefractionForm_FormClosed);
            this.groupBox_MediaOne.ResumeLayout(false);
            this.groupBox_MediaTwo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SinAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_MediaOne;
        private System.Windows.Forms.RadioButton radioButton_MediaOneGlass;
        private System.Windows.Forms.RadioButton radioButton_MediaOneOil;
        private System.Windows.Forms.RadioButton radioButton_MediaOneWater;
        private System.Windows.Forms.RadioButton radioButton_MediaOneAir;
        private System.Windows.Forms.GroupBox groupBox_MediaTwo;
        private System.Windows.Forms.RadioButton radioButton_MediaTwoGlass;
        private System.Windows.Forms.RadioButton radioButton_MediaTwoOil;
        private System.Windows.Forms.RadioButton radioButton_MediaTwoWater;
        private System.Windows.Forms.RadioButton radioButton_MediaTwoAir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_SinAlpha;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox_AngleOfRefraction;
        private System.Windows.Forms.Button buttonExit;
    }
}

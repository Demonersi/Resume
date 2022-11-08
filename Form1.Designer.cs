namespace Resume
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lName = new System.Windows.Forms.Label();
            this.lAge = new System.Windows.Forms.Label();
            this.lSex = new System.Windows.Forms.Label();
            this.lLastName = new System.Windows.Forms.Label();
            this.lPatr = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.rbWoman = new System.Windows.Forms.RadioButton();
            this.lbItog = new System.Windows.Forms.ListBox();
            this.bReady = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(35, 23);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(34, 15);
            this.lName.TabIndex = 0;
            this.lName.Text = "Имя:";
            // 
            // lAge
            // 
            this.lAge.AutoSize = true;
            this.lAge.Location = new System.Drawing.Point(35, 135);
            this.lAge.Name = "lAge";
            this.lAge.Size = new System.Drawing.Size(53, 15);
            this.lAge.TabIndex = 1;
            this.lAge.Text = "Возраст:";
            // 
            // lSex
            // 
            this.lSex.AutoSize = true;
            this.lSex.Location = new System.Drawing.Point(36, 198);
            this.lSex.Name = "lSex";
            this.lSex.Size = new System.Drawing.Size(33, 15);
            this.lSex.TabIndex = 2;
            this.lSex.Text = "Пол:";
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Location = new System.Drawing.Point(35, 52);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(61, 15);
            this.lLastName.TabIndex = 3;
            this.lLastName.Text = "Фамилия:";
            // 
            // lPatr
            // 
            this.lPatr.AutoSize = true;
            this.lPatr.Location = new System.Drawing.Point(35, 81);
            this.lPatr.Name = "lPatr";
            this.lPatr.Size = new System.Drawing.Size(61, 15);
            this.lPatr.TabIndex = 4;
            this.lPatr.Text = "Отчество:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 23);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(95, 23);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(102, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(95, 23);
            this.textBox3.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(102, 133);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 23);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Location = new System.Drawing.Point(90, 185);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(77, 19);
            this.rbMan.TabIndex = 10;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Мужской";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // rbWoman
            // 
            this.rbWoman.AutoSize = true;
            this.rbWoman.Location = new System.Drawing.Point(90, 210);
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.Size = new System.Drawing.Size(75, 19);
            this.rbWoman.TabIndex = 11;
            this.rbWoman.TabStop = true;
            this.rbWoman.Text = "Женский";
            this.rbWoman.UseVisualStyleBackColor = true;
            // 
            // lbItog
            // 
            this.lbItog.FormattingEnabled = true;
            this.lbItog.ItemHeight = 15;
            this.lbItog.Location = new System.Drawing.Point(302, 12);
            this.lbItog.Name = "lbItog";
            this.lbItog.Size = new System.Drawing.Size(279, 289);
            this.lbItog.TabIndex = 12;
            // 
            // bReady
            // 
            this.bReady.Location = new System.Drawing.Point(35, 278);
            this.bReady.Name = "bReady";
            this.bReady.Size = new System.Drawing.Size(75, 23);
            this.bReady.TabIndex = 13;
            this.bReady.Text = "Готово";
            this.bReady.UseVisualStyleBackColor = true;
            this.bReady.Click += new System.EventHandler(this.bReady_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(148, 278);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 14;
            this.bClear.Text = "Очистить";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 334);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bReady);
            this.Controls.Add(this.lbItog);
            this.Controls.Add(this.rbWoman);
            this.Controls.Add(this.rbMan);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lPatr);
            this.Controls.Add(this.lLastName);
            this.Controls.Add(this.lSex);
            this.Controls.Add(this.lAge);
            this.Controls.Add(this.lName);
            this.Name = "Form1";
            this.Text = "Анкета";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lName;
        private Label lAge;
        private Label lSex;
        private Label lLastName;
        private Label lPatr;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private NumericUpDown numericUpDown1;
        private RadioButton rbMan;
        private RadioButton rbWoman;
        private ListBox lbItog;
        private Button bReady;
        private Button bClear;
    }
}
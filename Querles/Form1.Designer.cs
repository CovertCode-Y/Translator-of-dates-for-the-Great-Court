namespace Querles
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBoxYear = new ComboBox();
            comboBoxMonth = new ComboBox();
            comboBoxDayMonth = new ComboBox();
            comboBoxDayWeek = new ComboBox();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Zorea Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 177);
            label1.Location = new Point(442, 43);
            label1.Name = "label1";
            label1.Size = new Size(152, 26);
            label1.TabIndex = 0;
            label1.Text = "כתיבת התאריך";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("ZoreaMF", 9F, FontStyle.Italic);
            label2.Location = new Point(774, 132);
            label2.Name = "label2";
            label2.Size = new Size(88, 19);
            label2.TabIndex = 1;
            label2.Text = "היום בשבוע";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("ZoreaMF", 9F, FontStyle.Italic);
            label3.Location = new Point(553, 132);
            label3.Name = "label3";
            label3.Size = new Size(89, 19);
            label3.TabIndex = 1;
            label3.Text = "היום בחודש";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("ZoreaMF", 9F, FontStyle.Italic);
            label4.Location = new Point(363, 132);
            label4.Name = "label4";
            label4.Size = new Size(46, 19);
            label4.TabIndex = 1;
            label4.Text = "חודש";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("ZoreaMF", 9F, FontStyle.Italic);
            label5.Location = new Point(139, 132);
            label5.Name = "label5";
            label5.Size = new Size(37, 19);
            label5.TabIndex = 1;
            label5.Text = "שנה";
            // 
            // comboBoxYear
            // 
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Items.AddRange(new object[] { "תשפ''ד", "תשפ''ה", "תשפ''ו", "תשפ''ז", "תשפ''ח", "תשפ''ט", "תש''צ", "תשצ''א", "תשצ''ב", "תשצ''ג", "תשצ''ד" });
            comboBoxYear.Location = new Point(70, 189);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(182, 33);
            comboBoxYear.TabIndex = 2;
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Items.AddRange(new object[] { "תשרי", "מרחשוון", "כסלו", "טבת", "שבט", "אדר", "אדר א", "אדר ב", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול" });
            comboBoxMonth.Location = new Point(291, 189);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(182, 33);
            comboBoxMonth.TabIndex = 2;
            // 
            // comboBoxDayMonth
            // 
            comboBoxDayMonth.FormattingEnabled = true;
            comboBoxDayMonth.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            comboBoxDayMonth.Location = new Point(508, 189);
            comboBoxDayMonth.Name = "comboBoxDayMonth";
            comboBoxDayMonth.Size = new Size(182, 33);
            comboBoxDayMonth.TabIndex = 2;
            // 
            // comboBoxDayWeek
            // 
            comboBoxDayWeek.FormattingEnabled = true;
            comboBoxDayWeek.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "ששי" });
            comboBoxDayWeek.Location = new Point(728, 189);
            comboBoxDayWeek.Name = "comboBoxDayWeek";
            comboBoxDayWeek.Size = new Size(182, 33);
            comboBoxDayWeek.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(70, 260);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(840, 60);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "שמור והצג";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 575);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxDayWeek);
            Controls.Add(comboBoxDayMonth);
            Controls.Add(comboBoxMonth);
            Controls.Add(comboBoxYear);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxYear;
        private ComboBox comboBoxMonth;
        private ComboBox comboBoxDayMonth;
        private ComboBox comboBoxDayWeek;
        private Button buttonSave;
    }
}

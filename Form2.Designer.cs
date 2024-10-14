namespace SuperCalculator
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            choosenumcol = new Button();
            chooseactioncol = new Button();
            chooseappbackcol = new Button();
            choosetextcol = new Button();
            numbtncol = new Label();
            actionbtncol = new Label();
            appbackcol = new Label();
            txtcol = new Label();
            answerboxview = new TextBox();
            label6 = new Label();
            fontstylebox = new ListBox();
            symbolssize = new NumericUpDown();
            applyanswerboxsettings = new Button();
            chooseansbackcol = new Button();
            ansboxbackcol = new Label();
            label8 = new Label();
            fontdataView = new Label();
            error = new Label();
            ((System.ComponentModel.ISupportInitialize)symbolssize).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(166, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 50);
            label1.TabIndex = 0;
            label1.Text = "Settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 1;
            label2.Text = "color of number buttons:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 119);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 2;
            label3.Text = "color of action buttons:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 154);
            label4.Name = "label4";
            label4.Size = new Size(141, 15);
            label4.TabIndex = 3;
            label4.Text = "color of app background:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 190);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 4;
            label5.Text = "symbol color:";
            // 
            // choosenumcol
            // 
            choosenumcol.Location = new Point(158, 82);
            choosenumcol.Name = "choosenumcol";
            choosenumcol.Size = new Size(162, 23);
            choosenumcol.TabIndex = 5;
            choosenumcol.Text = "select";
            choosenumcol.UseVisualStyleBackColor = true;
            choosenumcol.Click += Choose_Num_Col;
            // 
            // chooseactioncol
            // 
            chooseactioncol.Location = new Point(158, 115);
            chooseactioncol.Name = "chooseactioncol";
            chooseactioncol.Size = new Size(162, 23);
            chooseactioncol.TabIndex = 6;
            chooseactioncol.Text = "select";
            chooseactioncol.UseVisualStyleBackColor = true;
            chooseactioncol.Click += Choose_Action_Col;
            // 
            // chooseappbackcol
            // 
            chooseappbackcol.Location = new Point(158, 150);
            chooseappbackcol.Name = "chooseappbackcol";
            chooseappbackcol.Size = new Size(162, 23);
            chooseappbackcol.TabIndex = 7;
            chooseappbackcol.Text = "select";
            chooseappbackcol.UseVisualStyleBackColor = true;
            chooseappbackcol.Click += Choose_App_Col;
            // 
            // choosetextcol
            // 
            choosetextcol.Location = new Point(97, 186);
            choosetextcol.Name = "choosetextcol";
            choosetextcol.Size = new Size(223, 23);
            choosetextcol.TabIndex = 8;
            choosetextcol.Text = "select";
            choosetextcol.UseVisualStyleBackColor = true;
            choosetextcol.Click += Choose_Text_Col;
            // 
            // numbtncol
            // 
            numbtncol.AutoSize = true;
            numbtncol.BackColor = SystemColors.Control;
            numbtncol.Location = new Point(358, 86);
            numbtncol.Name = "numbtncol";
            numbtncol.Size = new Size(106, 15);
            numbtncol.TabIndex = 9;
            numbtncol.Text = "num buttons color";
            // 
            // actionbtncol
            // 
            actionbtncol.AutoSize = true;
            actionbtncol.Location = new Point(358, 119);
            actionbtncol.Name = "actionbtncol";
            actionbtncol.Size = new Size(114, 15);
            actionbtncol.TabIndex = 10;
            actionbtncol.Text = "action buttons color";
            // 
            // appbackcol
            // 
            appbackcol.AutoSize = true;
            appbackcol.Location = new Point(358, 154);
            appbackcol.Name = "appbackcol";
            appbackcol.Size = new Size(124, 15);
            appbackcol.TabIndex = 11;
            appbackcol.Text = "app background color";
            // 
            // txtcol
            // 
            txtcol.AutoSize = true;
            txtcol.Location = new Point(358, 190);
            txtcol.Name = "txtcol";
            txtcol.Size = new Size(79, 15);
            txtcol.TabIndex = 12;
            txtcol.Text = "symbol  color";
            // 
            // answerboxview
            // 
            answerboxview.Location = new Point(12, 276);
            answerboxview.Multiline = true;
            answerboxview.Name = "answerboxview";
            answerboxview.Size = new Size(254, 118);
            answerboxview.TabIndex = 13;
            answerboxview.Text = "2 + 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 248);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 14;
            label6.Text = "answer box font:";
            // 
            // fontstylebox
            // 
            fontstylebox.FormattingEnabled = true;
            fontstylebox.ItemHeight = 15;
            fontstylebox.Items.AddRange(new object[] { "Arial", "Verdana", "Tahoma", "Bold", "Italic", "Normal", "Impact", "Segoi UI" });
            fontstylebox.Location = new Point(272, 276);
            fontstylebox.Name = "fontstylebox";
            fontstylebox.Size = new Size(218, 64);
            fontstylebox.TabIndex = 15;
            // 
            // symbolssize
            // 
            symbolssize.Location = new Point(272, 371);
            symbolssize.Name = "symbolssize";
            symbolssize.Size = new Size(218, 23);
            symbolssize.TabIndex = 16;
            // 
            // applyanswerboxsettings
            // 
            applyanswerboxsettings.Location = new Point(12, 443);
            applyanswerboxsettings.Name = "applyanswerboxsettings";
            applyanswerboxsettings.Size = new Size(478, 23);
            applyanswerboxsettings.TabIndex = 17;
            applyanswerboxsettings.Text = "apply answer box settings";
            applyanswerboxsettings.UseVisualStyleBackColor = true;
            applyanswerboxsettings.Click += Choose_Font_AnsBox;
            // 
            // chooseansbackcol
            // 
            chooseansbackcol.Location = new Point(149, 400);
            chooseansbackcol.Name = "chooseansbackcol";
            chooseansbackcol.Size = new Size(266, 23);
            chooseansbackcol.TabIndex = 18;
            chooseansbackcol.Text = "select";
            chooseansbackcol.UseVisualStyleBackColor = true;
            chooseansbackcol.Click += Choose_AnsBox_Col;
            // 
            // ansboxbackcol
            // 
            ansboxbackcol.AutoSize = true;
            ansboxbackcol.Location = new Point(426, 404);
            ansboxbackcol.Name = "ansboxbackcol";
            ansboxbackcol.Size = new Size(62, 15);
            ansboxbackcol.TabIndex = 19;
            ansboxbackcol.Text = "back color";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 404);
            label8.Name = "label8";
            label8.Size = new Size(128, 15);
            label8.TabIndex = 20;
            label8.Text = "answer box back color:";
            // 
            // fontdataView
            // 
            fontdataView.AutoSize = true;
            fontdataView.Location = new Point(272, 343);
            fontdataView.Name = "fontdataView";
            fontdataView.Size = new Size(58, 15);
            fontdataView.TabIndex = 21;
            fontdataView.Text = "text font: ";
            // 
            // error
            // 
            error.AutoSize = true;
            error.BackColor = Color.White;
            error.ForeColor = Color.Red;
            error.Location = new Point(228, 490);
            error.Name = "error";
            error.Size = new Size(0, 15);
            error.TabIndex = 22;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 538);
            Controls.Add(error);
            Controls.Add(fontdataView);
            Controls.Add(label8);
            Controls.Add(ansboxbackcol);
            Controls.Add(chooseansbackcol);
            Controls.Add(applyanswerboxsettings);
            Controls.Add(symbolssize);
            Controls.Add(fontstylebox);
            Controls.Add(label6);
            Controls.Add(answerboxview);
            Controls.Add(txtcol);
            Controls.Add(appbackcol);
            Controls.Add(actionbtncol);
            Controls.Add(numbtncol);
            Controls.Add(choosetextcol);
            Controls.Add(chooseappbackcol);
            Controls.Add(chooseactioncol);
            Controls.Add(choosenumcol);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            Name = "Form2";
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)symbolssize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button choosenumcol;
        private Button chooseactioncol;
        private Button chooseappbackcol;
        private Button choosetextcol;
        private Label numbtncol;
        private Label actionbtncol;
        private Label appbackcol;
        private Label txtcol;
        private TextBox answerboxview;
        private Label label6;
        private ListBox fontstylebox;
        private NumericUpDown symbolssize;
        private Button applyanswerboxsettings;
        private Button chooseansbackcol;
        private Label ansboxbackcol;
        private Label label8;
        private Label fontdataView;
        private Label error;
    }
}

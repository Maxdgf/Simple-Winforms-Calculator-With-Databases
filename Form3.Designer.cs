namespace SuperCalculator
{
    partial class Form3
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
            solvesView = new ListBox();
            label1 = new Label();
            buttonCopySelectedString = new Button();
            buttonDeleteAll = new Button();
            searchString = new TextBox();
            buttonSearch = new Button();
            resBox = new ListBox();
            resultBox = new Label();
            clearResults = new Button();
            SuspendLayout();
            // 
            // solvesView
            // 
            solvesView.FormattingEnabled = true;
            solvesView.ItemHeight = 15;
            solvesView.Location = new Point(12, 77);
            solvesView.Name = "solvesView";
            solvesView.Size = new Size(341, 304);
            solvesView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(289, 9);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 1;
            label1.Text = "Solutions";
            // 
            // buttonCopySelectedString
            // 
            buttonCopySelectedString.BackColor = Color.Yellow;
            buttonCopySelectedString.Location = new Point(12, 399);
            buttonCopySelectedString.Name = "buttonCopySelectedString";
            buttonCopySelectedString.Size = new Size(341, 39);
            buttonCopySelectedString.TabIndex = 2;
            buttonCopySelectedString.Text = "copy selected string";
            buttonCopySelectedString.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteAll
            // 
            buttonDeleteAll.BackColor = Color.Red;
            buttonDeleteAll.Location = new Point(359, 399);
            buttonDeleteAll.Name = "buttonDeleteAll";
            buttonDeleteAll.Size = new Size(347, 39);
            buttonDeleteAll.TabIndex = 3;
            buttonDeleteAll.Text = "delete all";
            buttonDeleteAll.UseVisualStyleBackColor = false;
            // 
            // searchString
            // 
            searchString.Location = new Point(12, 48);
            searchString.Name = "searchString";
            searchString.Size = new Size(600, 23);
            searchString.TabIndex = 4;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Cyan;
            buttonSearch.Location = new Point(618, 48);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(88, 23);
            buttonSearch.TabIndex = 5;
            buttonSearch.Text = "search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += searchEvent;
            // 
            // resBox
            // 
            resBox.FormattingEnabled = true;
            resBox.ItemHeight = 15;
            resBox.Location = new Point(359, 122);
            resBox.Name = "resBox";
            resBox.Size = new Size(347, 259);
            resBox.TabIndex = 6;
            // 
            // resultBox
            // 
            resultBox.AutoSize = true;
            resultBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            resultBox.Location = new Point(501, 94);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(74, 25);
            resultBox.TabIndex = 7;
            resultBox.Text = "Results";
            // 
            // clearResults
            // 
            clearResults.BackColor = Color.Red;
            clearResults.Location = new Point(581, 94);
            clearResults.Name = "clearResults";
            clearResults.Size = new Size(75, 23);
            clearResults.TabIndex = 8;
            clearResults.Text = "clear";
            clearResults.UseVisualStyleBackColor = false;
            clearResults.Click += ClearResultBox;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 450);
            Controls.Add(clearResults);
            Controls.Add(resultBox);
            Controls.Add(resBox);
            Controls.Add(buttonSearch);
            Controls.Add(searchString);
            Controls.Add(buttonDeleteAll);
            Controls.Add(buttonCopySelectedString);
            Controls.Add(label1);
            Controls.Add(solvesView);
            Name = "Form3";
            Text = "Solves";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox solvesView;
        private Label label1;
        private Button buttonCopySelectedString;
        private Button buttonDeleteAll;
        private TextBox searchString;
        private Button buttonSearch;
        private ListBox resBox;
        private Label resultBox;
        private Button clearResults;
    }
}

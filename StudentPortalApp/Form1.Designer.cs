namespace StudentPortalApp
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.yearOfStudyLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.IDTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AgeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.GenderTextBox = new System.Windows.Forms.MaskedTextBox();
            this.YearOfStudyTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ResultsTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AverageMarksTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ModuleList = new System.Windows.Forms.ComboBox();
            this.ProjectMarksList = new System.Windows.Forms.ComboBox();
            this.SemesterMarksList = new System.Windows.Forms.ComboBox();
            this.ExamMarksList = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.projectMarkLabel = new System.Windows.Forms.Label();
            this.semesterMarkLabel = new System.Windows.Forms.Label();
            this.examMarkLabel = new System.Windows.Forms.Label();
            this.averageMarkLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 449);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(321, 178);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.YearOfStudyTextBox);
            this.panel2.Controls.Add(this.GenderTextBox);
            this.panel2.Controls.Add(this.AgeTextBox);
            this.panel2.Controls.Add(this.IDTextBox);
            this.panel2.Controls.Add(this.nameTextBox);
            this.panel2.Controls.Add(this.yearOfStudyLabel);
            this.panel2.Controls.Add(this.GenderLabel);
            this.panel2.Controls.Add(this.ageLabel);
            this.panel2.Controls.Add(this.IdLabel);
            this.panel2.Controls.Add(this.nameLabel);
            this.panel2.Location = new System.Drawing.Point(3, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 191);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.resultLabel);
            this.panel3.Controls.Add(this.averageMarkLabel);
            this.panel3.Controls.Add(this.examMarkLabel);
            this.panel3.Controls.Add(this.semesterMarkLabel);
            this.panel3.Controls.Add(this.projectMarkLabel);
            this.panel3.Controls.Add(this.ExamMarksList);
            this.panel3.Controls.Add(this.SemesterMarksList);
            this.panel3.Controls.Add(this.ProjectMarksList);
            this.panel3.Controls.Add(this.ModuleList);
            this.panel3.Controls.Add(this.AverageMarksTextBox);
            this.panel3.Controls.Add(this.ResultsTextBox);
            this.panel3.Location = new System.Drawing.Point(330, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 375);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.exitButton);
            this.panel4.Controls.Add(this.clearButton);
            this.panel4.Controls.Add(this.deleteButton);
            this.panel4.Controls.Add(this.updateButton);
            this.panel4.Controls.Add(this.addButton);
            this.panel4.Location = new System.Drawing.Point(3, 384);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(631, 62);
            this.panel4.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(9, 11);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(9, 47);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(58, 13);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "ID Number";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(9, 90);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(26, 13);
            this.ageLabel.TabIndex = 2;
            this.ageLabel.Text = "Age";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(9, 127);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(42, 13);
            this.GenderLabel.TabIndex = 3;
            this.GenderLabel.Text = "Gender";
            // 
            // yearOfStudyLabel
            // 
            this.yearOfStudyLabel.AutoSize = true;
            this.yearOfStudyLabel.Location = new System.Drawing.Point(9, 165);
            this.yearOfStudyLabel.Name = "yearOfStudyLabel";
            this.yearOfStudyLabel.Size = new System.Drawing.Size(73, 13);
            this.yearOfStudyLabel.TabIndex = 4;
            this.yearOfStudyLabel.Text = "Year Of Study";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(178, 8);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(136, 20);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.nameTextBox_MaskInputRejected);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(178, 44);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(136, 20);
            this.IDTextBox.TabIndex = 6;
            this.IDTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.IDTextBox_MaskInputRejected);
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(178, 83);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(136, 20);
            this.AgeTextBox.TabIndex = 7;
            this.AgeTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // GenderTextBox
            // 
            this.GenderTextBox.Location = new System.Drawing.Point(178, 120);
            this.GenderTextBox.Name = "GenderTextBox";
            this.GenderTextBox.Size = new System.Drawing.Size(136, 20);
            this.GenderTextBox.TabIndex = 8;
            this.GenderTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.GenderTextBox_MaskInputRejected);
            // 
            // YearOfStudyTextBox
            // 
            this.YearOfStudyTextBox.Location = new System.Drawing.Point(178, 158);
            this.YearOfStudyTextBox.Name = "YearOfStudyTextBox";
            this.YearOfStudyTextBox.Size = new System.Drawing.Size(136, 20);
            this.YearOfStudyTextBox.TabIndex = 9;
            this.YearOfStudyTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.YearOfStudyTextBox_MaskInputRejected);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(177, 274);
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.Size = new System.Drawing.Size(112, 20);
            this.ResultsTextBox.TabIndex = 10;
            this.ResultsTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.ResultsTextBox_MaskInputRejected);
            // 
            // AverageMarksTextBox
            // 
            this.AverageMarksTextBox.Location = new System.Drawing.Point(177, 224);
            this.AverageMarksTextBox.Name = "AverageMarksTextBox";
            this.AverageMarksTextBox.Size = new System.Drawing.Size(112, 20);
            this.AverageMarksTextBox.TabIndex = 11;
            this.AverageMarksTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.AverageMarksTextBox_MaskInputRejected);
            // 
            // ModuleList
            // 
            this.ModuleList.FormattingEnabled = true;
            this.ModuleList.Location = new System.Drawing.Point(87, 9);
            this.ModuleList.Name = "ModuleList";
            this.ModuleList.Size = new System.Drawing.Size(121, 21);
            this.ModuleList.TabIndex = 12;
            this.ModuleList.SelectedIndexChanged += new System.EventHandler(this.ModuleList_SelectedIndexChanged);
            // 
            // ProjectMarksList
            // 
            this.ProjectMarksList.FormattingEnabled = true;
            this.ProjectMarksList.Location = new System.Drawing.Point(177, 72);
            this.ProjectMarksList.Name = "ProjectMarksList";
            this.ProjectMarksList.Size = new System.Drawing.Size(112, 21);
            this.ProjectMarksList.TabIndex = 13;
            this.ProjectMarksList.SelectedIndexChanged += new System.EventHandler(this.ProjectMarksList_SelectedIndexChanged);
            // 
            // SemesterMarksList
            // 
            this.SemesterMarksList.FormattingEnabled = true;
            this.SemesterMarksList.Location = new System.Drawing.Point(177, 126);
            this.SemesterMarksList.Name = "SemesterMarksList";
            this.SemesterMarksList.Size = new System.Drawing.Size(112, 21);
            this.SemesterMarksList.TabIndex = 14;
            this.SemesterMarksList.SelectedIndexChanged += new System.EventHandler(this.SemesterMarksList_SelectedIndexChanged);
            // 
            // ExamMarksList
            // 
            this.ExamMarksList.FormattingEnabled = true;
            this.ExamMarksList.Location = new System.Drawing.Point(177, 167);
            this.ExamMarksList.Name = "ExamMarksList";
            this.ExamMarksList.Size = new System.Drawing.Size(112, 21);
            this.ExamMarksList.TabIndex = 15;
            this.ExamMarksList.SelectedIndexChanged += new System.EventHandler(this.ExamMarksList_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(8, 21);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 32);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(128, 21);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 32);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(261, 21);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 32);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(390, 21);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 32);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(527, 21);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 32);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "STUDENT";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // projectMarkLabel
            // 
            this.projectMarkLabel.AutoSize = true;
            this.projectMarkLabel.Location = new System.Drawing.Point(3, 80);
            this.projectMarkLabel.Name = "projectMarkLabel";
            this.projectMarkLabel.Size = new System.Drawing.Size(67, 13);
            this.projectMarkLabel.TabIndex = 10;
            this.projectMarkLabel.Text = "Project Mark";
            // 
            // semesterMarkLabel
            // 
            this.semesterMarkLabel.AutoSize = true;
            this.semesterMarkLabel.Location = new System.Drawing.Point(3, 134);
            this.semesterMarkLabel.Name = "semesterMarkLabel";
            this.semesterMarkLabel.Size = new System.Drawing.Size(78, 13);
            this.semesterMarkLabel.TabIndex = 16;
            this.semesterMarkLabel.Text = "Semester Mark";
            // 
            // examMarkLabel
            // 
            this.examMarkLabel.AutoSize = true;
            this.examMarkLabel.Location = new System.Drawing.Point(3, 175);
            this.examMarkLabel.Name = "examMarkLabel";
            this.examMarkLabel.Size = new System.Drawing.Size(60, 13);
            this.examMarkLabel.TabIndex = 17;
            this.examMarkLabel.Text = "Exam Mark";
            // 
            // averageMarkLabel
            // 
            this.averageMarkLabel.AutoSize = true;
            this.averageMarkLabel.Location = new System.Drawing.Point(3, 235);
            this.averageMarkLabel.Name = "averageMarkLabel";
            this.averageMarkLabel.Size = new System.Drawing.Size(74, 13);
            this.averageMarkLabel.TabIndex = 18;
            this.averageMarkLabel.Text = "Average Mark";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(3, 281);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(42, 13);
            this.resultLabel.TabIndex = 19;
            this.resultLabel.Text = "Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label yearOfStudyLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox ExamMarksList;
        private System.Windows.Forms.ComboBox SemesterMarksList;
        private System.Windows.Forms.ComboBox ProjectMarksList;
        private System.Windows.Forms.ComboBox ModuleList;
        private System.Windows.Forms.MaskedTextBox AverageMarksTextBox;
        private System.Windows.Forms.MaskedTextBox ResultsTextBox;
        private System.Windows.Forms.MaskedTextBox YearOfStudyTextBox;
        private System.Windows.Forms.MaskedTextBox GenderTextBox;
        private System.Windows.Forms.MaskedTextBox AgeTextBox;
        private System.Windows.Forms.MaskedTextBox IDTextBox;
        private System.Windows.Forms.MaskedTextBox nameTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label averageMarkLabel;
        private System.Windows.Forms.Label examMarkLabel;
        private System.Windows.Forms.Label semesterMarkLabel;
        private System.Windows.Forms.Label projectMarkLabel;
        private System.Windows.Forms.Label label6;
    }
}



namespace Easy_Password_Validator_GUI
{
    partial class PasswordValidatorForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxNotes = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDetails = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBarScore = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonLowercaseN = new System.Windows.Forms.RadioButton();
            this.radioButtonLowercaseY = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonDigitsN = new System.Windows.Forms.RadioButton();
            this.radioButtonDigitsY = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownScore = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownNeighboring = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownRepeat = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownUnique = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownLength = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonUppercaseY = new System.Windows.Forms.RadioButton();
            this.radioButtonUppercaseN = new System.Windows.Forms.RadioButton();
            this.radioButtonPunctuationY = new System.Windows.Forms.RadioButton();
            this.radioButtonPunctuationN = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNeighboring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxNotes);
            this.groupBox1.Controls.Add(this.richTextBoxDetails);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.progressBarScore);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password Testing";
            // 
            // richTextBoxNotes
            // 
            this.richTextBoxNotes.Location = new System.Drawing.Point(86, 301);
            this.richTextBoxNotes.MaxLength = 10000;
            this.richTextBoxNotes.Name = "richTextBoxNotes";
            this.richTextBoxNotes.ReadOnly = true;
            this.richTextBoxNotes.Size = new System.Drawing.Size(295, 119);
            this.richTextBoxNotes.TabIndex = 6;
            this.richTextBoxNotes.Text = "";
            // 
            // richTextBoxDetails
            // 
            this.richTextBoxDetails.Location = new System.Drawing.Point(86, 96);
            this.richTextBoxDetails.MaxLength = 10000;
            this.richTextBoxDetails.Name = "richTextBoxDetails";
            this.richTextBoxDetails.ReadOnly = true;
            this.richTextBoxDetails.Size = new System.Drawing.Size(295, 199);
            this.richTextBoxDetails.TabIndex = 5;
            this.richTextBoxDetails.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Details";
            // 
            // progressBarScore
            // 
            this.progressBarScore.Location = new System.Drawing.Point(86, 67);
            this.progressBarScore.Maximum = 250;
            this.progressBarScore.Name = "progressBarScore";
            this.progressBarScore.Size = new System.Drawing.Size(295, 23);
            this.progressBarScore.Step = 1;
            this.progressBarScore.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(86, 35);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(295, 23);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Password";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.numericUpDownScore);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numericUpDownNeighboring);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.numericUpDownRepeat);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numericUpDownUnique);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numericUpDownLength);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(413, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButtonUppercaseN);
            this.panel3.Controls.Add(this.radioButtonUppercaseY);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(6, 272);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 31);
            this.panel3.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Require Uppercase";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radioButtonPunctuationN);
            this.panel4.Controls.Add(this.radioButtonPunctuationY);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(6, 309);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(363, 31);
            this.panel4.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Require Punctuation";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonLowercaseN);
            this.panel2.Controls.Add(this.radioButtonLowercaseY);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(6, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 31);
            this.panel2.TabIndex = 11;
            // 
            // radioButtonLowercaseN
            // 
            this.radioButtonLowercaseN.AutoSize = true;
            this.radioButtonLowercaseN.Location = new System.Drawing.Point(322, 7);
            this.radioButtonLowercaseN.Name = "radioButtonLowercaseN";
            this.radioButtonLowercaseN.Size = new System.Drawing.Size(41, 19);
            this.radioButtonLowercaseN.TabIndex = 2;
            this.radioButtonLowercaseN.TabStop = true;
            this.radioButtonLowercaseN.Text = "No";
            this.radioButtonLowercaseN.UseVisualStyleBackColor = true;
            this.radioButtonLowercaseN.CheckedChanged += new System.EventHandler(this.RadioButtonLowercaseN_CheckedChanged);
            // 
            // radioButtonLowercaseY
            // 
            this.radioButtonLowercaseY.AutoSize = true;
            this.radioButtonLowercaseY.Location = new System.Drawing.Point(165, 7);
            this.radioButtonLowercaseY.Name = "radioButtonLowercaseY";
            this.radioButtonLowercaseY.Size = new System.Drawing.Size(42, 19);
            this.radioButtonLowercaseY.TabIndex = 1;
            this.radioButtonLowercaseY.TabStop = true;
            this.radioButtonLowercaseY.Text = "Yes";
            this.radioButtonLowercaseY.UseVisualStyleBackColor = true;
            this.radioButtonLowercaseY.CheckedChanged += new System.EventHandler(this.RadioButtonLowercaseY_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Require Lowercase";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonDigitsN);
            this.panel1.Controls.Add(this.radioButtonDigitsY);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(6, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 31);
            this.panel1.TabIndex = 10;
            // 
            // radioButtonDigitsN
            // 
            this.radioButtonDigitsN.AutoSize = true;
            this.radioButtonDigitsN.Location = new System.Drawing.Point(322, 6);
            this.radioButtonDigitsN.Name = "radioButtonDigitsN";
            this.radioButtonDigitsN.Size = new System.Drawing.Size(41, 19);
            this.radioButtonDigitsN.TabIndex = 2;
            this.radioButtonDigitsN.TabStop = true;
            this.radioButtonDigitsN.Text = "No";
            this.radioButtonDigitsN.UseVisualStyleBackColor = true;
            this.radioButtonDigitsN.CheckedChanged += new System.EventHandler(this.RadioButtonDigitsN_CheckedChanged);
            // 
            // radioButtonDigitsY
            // 
            this.radioButtonDigitsY.AutoSize = true;
            this.radioButtonDigitsY.Location = new System.Drawing.Point(165, 6);
            this.radioButtonDigitsY.Name = "radioButtonDigitsY";
            this.radioButtonDigitsY.Size = new System.Drawing.Size(42, 19);
            this.radioButtonDigitsY.TabIndex = 1;
            this.radioButtonDigitsY.TabStop = true;
            this.radioButtonDigitsY.Text = "Yes";
            this.radioButtonDigitsY.UseVisualStyleBackColor = true;
            this.radioButtonDigitsY.CheckedChanged += new System.EventHandler(this.RadioButtonDigitsY_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Require Digits";
            // 
            // numericUpDownScore
            // 
            this.numericUpDownScore.Location = new System.Drawing.Point(171, 169);
            this.numericUpDownScore.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownScore.Name = "numericUpDownScore";
            this.numericUpDownScore.Size = new System.Drawing.Size(198, 23);
            this.numericUpDownScore.TabIndex = 9;
            this.numericUpDownScore.ValueChanged += new System.EventHandler(this.NumericUpDownScore_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Min Score";
            // 
            // numericUpDownNeighboring
            // 
            this.numericUpDownNeighboring.Location = new System.Drawing.Point(171, 134);
            this.numericUpDownNeighboring.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownNeighboring.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNeighboring.Name = "numericUpDownNeighboring";
            this.numericUpDownNeighboring.Size = new System.Drawing.Size(198, 23);
            this.numericUpDownNeighboring.TabIndex = 7;
            this.numericUpDownNeighboring.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNeighboring.ValueChanged += new System.EventHandler(this.NumericUpDownNeighboring_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Max Neighboring Characters";
            // 
            // numericUpDownRepeat
            // 
            this.numericUpDownRepeat.Location = new System.Drawing.Point(171, 101);
            this.numericUpDownRepeat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownRepeat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRepeat.Name = "numericUpDownRepeat";
            this.numericUpDownRepeat.Size = new System.Drawing.Size(198, 23);
            this.numericUpDownRepeat.TabIndex = 5;
            this.numericUpDownRepeat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRepeat.ValueChanged += new System.EventHandler(this.NumericUpDownRepeat_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Max Repeat Characters";
            // 
            // numericUpDownUnique
            // 
            this.numericUpDownUnique.Location = new System.Drawing.Point(171, 67);
            this.numericUpDownUnique.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownUnique.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownUnique.Name = "numericUpDownUnique";
            this.numericUpDownUnique.Size = new System.Drawing.Size(198, 23);
            this.numericUpDownUnique.TabIndex = 3;
            this.numericUpDownUnique.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownUnique.ValueChanged += new System.EventHandler(this.NumericUpDownUnique_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Min Unique Characters";
            // 
            // numericUpDownLength
            // 
            this.numericUpDownLength.Location = new System.Drawing.Point(171, 33);
            this.numericUpDownLength.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLength.Name = "numericUpDownLength";
            this.numericUpDownLength.Size = new System.Drawing.Size(198, 23);
            this.numericUpDownLength.TabIndex = 1;
            this.numericUpDownLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLength.ValueChanged += new System.EventHandler(this.NumericUpDownLength_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Min &Length";
            // 
            // radioButtonUppercaseY
            // 
            this.radioButtonUppercaseY.AutoSize = true;
            this.radioButtonUppercaseY.Location = new System.Drawing.Point(165, 7);
            this.radioButtonUppercaseY.Name = "radioButtonUppercaseY";
            this.radioButtonUppercaseY.Size = new System.Drawing.Size(42, 19);
            this.radioButtonUppercaseY.TabIndex = 1;
            this.radioButtonUppercaseY.TabStop = true;
            this.radioButtonUppercaseY.Text = "Yes";
            this.radioButtonUppercaseY.UseVisualStyleBackColor = true;
            this.radioButtonUppercaseY.CheckedChanged += new System.EventHandler(this.RadioButtonUppercaseY_CheckedChanged);
            // 
            // radioButtonUppercaseN
            // 
            this.radioButtonUppercaseN.AutoSize = true;
            this.radioButtonUppercaseN.Location = new System.Drawing.Point(322, 7);
            this.radioButtonUppercaseN.Name = "radioButtonUppercaseN";
            this.radioButtonUppercaseN.Size = new System.Drawing.Size(41, 19);
            this.radioButtonUppercaseN.TabIndex = 2;
            this.radioButtonUppercaseN.TabStop = true;
            this.radioButtonUppercaseN.Text = "No";
            this.radioButtonUppercaseN.UseVisualStyleBackColor = true;
            this.radioButtonUppercaseN.CheckedChanged += new System.EventHandler(this.RadioButtonUppercaseN_CheckedChanged);
            // 
            // radioButtonPunctuationY
            // 
            this.radioButtonPunctuationY.AutoSize = true;
            this.radioButtonPunctuationY.Location = new System.Drawing.Point(165, 6);
            this.radioButtonPunctuationY.Name = "radioButtonPunctuationY";
            this.radioButtonPunctuationY.Size = new System.Drawing.Size(42, 19);
            this.radioButtonPunctuationY.TabIndex = 1;
            this.radioButtonPunctuationY.TabStop = true;
            this.radioButtonPunctuationY.Text = "Yes";
            this.radioButtonPunctuationY.UseVisualStyleBackColor = true;
            this.radioButtonPunctuationY.CheckedChanged += new System.EventHandler(this.RadioButtonPunctuationY_CheckedChanged);
            // 
            // radioButtonPunctuationN
            // 
            this.radioButtonPunctuationN.AutoSize = true;
            this.radioButtonPunctuationN.Location = new System.Drawing.Point(322, 6);
            this.radioButtonPunctuationN.Name = "radioButtonPunctuationN";
            this.radioButtonPunctuationN.Size = new System.Drawing.Size(41, 19);
            this.radioButtonPunctuationN.TabIndex = 2;
            this.radioButtonPunctuationN.TabStop = true;
            this.radioButtonPunctuationN.Text = "No";
            this.radioButtonPunctuationN.UseVisualStyleBackColor = true;
            this.radioButtonPunctuationN.CheckedChanged += new System.EventHandler(this.RadioButtonPunctuationN_CheckedChanged);
            // 
            // PasswordValidatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordValidatorForm";
            this.Text = "Easy Password Validator GUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNeighboring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxNotes;
        private System.Windows.Forms.RichTextBox richTextBoxDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBarScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownUnique;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownRepeat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownNeighboring;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownScore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonLowercaseN;
        private System.Windows.Forms.RadioButton radioButtonLowercaseY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonDigitsN;
        private System.Windows.Forms.RadioButton radioButtonDigitsY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButtonUppercaseN;
        private System.Windows.Forms.RadioButton radioButtonUppercaseY;
        private System.Windows.Forms.RadioButton radioButtonPunctuationN;
        private System.Windows.Forms.RadioButton radioButtonPunctuationY;
    }
}


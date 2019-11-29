namespace SuperCalculator
{
    partial class CalculatorView
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataTextBox = new System.Windows.Forms.RichTextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.redo = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.currentTextBox = new System.Windows.Forms.Label();
            this.allTextBox = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.devide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.RichTextBox();
            this.temporaryData = new System.Windows.Forms.RichTextBox();
            this.data = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1069, 851);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataTextBox);
            this.tabPage1.Controls.Add(this.enterButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1058, 847);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(302, 69);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(349, 199);
            this.dataTextBox.TabIndex = 1;
            this.dataTextBox.Text = "";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(406, 374);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(94, 29);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "button1";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.redo);
            this.tabPage2.Controls.Add(this.undoButton);
            this.tabPage2.Controls.Add(this.currentTextBox);
            this.tabPage2.Controls.Add(this.allTextBox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.devide);
            this.tabPage2.Controls.Add(this.multiply);
            this.tabPage2.Controls.Add(this.minus);
            this.tabPage2.Controls.Add(this.plus);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.input);
            this.tabPage2.Controls.Add(this.temporaryData);
            this.tabPage2.Controls.Add(this.data);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1061, 822);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // redo
            // 
            this.redo.Location = new System.Drawing.Point(934, 806);
            this.redo.Name = "redo";
            this.redo.Size = new System.Drawing.Size(91, 25);
            this.redo.TabIndex = 15;
            this.redo.Text = "Применить";
            this.redo.UseVisualStyleBackColor = true;
            this.redo.Click += new System.EventHandler(this.redo_Click);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(934, 774);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(91, 26);
            this.undoButton.TabIndex = 14;
            this.undoButton.Text = "Отменить";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // currentTextBox
            // 
            this.currentTextBox.Location = new System.Drawing.Point(911, 839);
            this.currentTextBox.Name = "currentTextBox";
            this.currentTextBox.Size = new System.Drawing.Size(114, 25);
            this.currentTextBox.TabIndex = 13;
            // 
            // allTextBox
            // 
            this.allTextBox.Location = new System.Drawing.Point(727, 839);
            this.allTextBox.Name = "allTextBox";
            this.allTextBox.Size = new System.Drawing.Size(114, 25);
            this.allTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(848, 839);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Current";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(694, 839);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "All";
            // 
            // devide
            // 
            this.devide.Location = new System.Drawing.Point(9, 301);
            this.devide.Name = "devide";
            this.devide.Size = new System.Drawing.Size(81, 22);
            this.devide.TabIndex = 9;
            this.devide.Text = "/";
            this.devide.UseVisualStyleBackColor = true;
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(11, 271);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(82, 22);
            this.multiply.TabIndex = 8;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(9, 240);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(86, 25);
            this.minus.TabIndex = 7;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(9, 209);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(88, 25);
            this.plus.TabIndex = 6;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(128, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ввод";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(43, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Временные данные";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(107, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Данные";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(182, 154);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(875, 23);
            this.input.TabIndex = 2;
            this.input.Text = "";
            // 
            // temporaryData
            // 
            this.temporaryData.Location = new System.Drawing.Point(182, 125);
            this.temporaryData.Name = "temporaryData";
            this.temporaryData.Size = new System.Drawing.Size(875, 23);
            this.temporaryData.TabIndex = 1;
            this.temporaryData.Text = "";
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(182, 0);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(874, 117);
            this.data.TabIndex = 0;
            this.data.Text = "";
            // 
            // CalculatorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 851);
            this.Controls.Add(this.tabControl1);
            this.Name = "CalculatorView";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.RichTextBox dataTextBox;
        private System.Windows.Forms.RichTextBox data;
        private System.Windows.Forms.RichTextBox input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox temporaryData;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button devide;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label allTextBox;
        private System.Windows.Forms.Label currentTextBox;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button redo;
    }
}
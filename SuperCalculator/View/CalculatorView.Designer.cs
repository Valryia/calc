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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataTextBox = new System.Windows.Forms.RichTextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.deviationButton = new System.Windows.Forms.Button();
            this.medianButton = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.RichTextBox();
            this.data = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(933, 838);
            this.tabControl1.TabIndex = 0;
            this.tabPage1.Controls.Add(this.dataTextBox);
            this.tabPage1.Controls.Add(this.enterButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(925, 810);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ввод";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.dataTextBox.Location = new System.Drawing.Point(264, 65);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(306, 187);
            this.dataTextBox.TabIndex = 1;
            this.dataTextBox.Text = "";
            this.enterButton.Location = new System.Drawing.Point(376, 272);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(82, 27);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "ввести";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            this.tabPage2.Controls.Add(this.deviationButton);
            this.tabPage2.Controls.Add(this.medianButton);
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
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.input);
            this.tabPage2.Controls.Add(this.data);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(925, 810);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Калькулятор";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            this.deviationButton.Location = new System.Drawing.Point(98, 182);
            this.deviationButton.Name = "deviationButton";
            this.deviationButton.Size = new System.Drawing.Size(87, 23);
            this.deviationButton.TabIndex = 17;
            this.deviationButton.Text = "Отклонение";
            this.deviationButton.UseVisualStyleBackColor = true;
            this.deviationButton.Click += new System.EventHandler(this.deviationButton_Click);
            this.medianButton.Location = new System.Drawing.Point(103, 153);
            this.medianButton.Name = "medianButton";
            this.medianButton.Size = new System.Drawing.Size(75, 23);
            this.medianButton.TabIndex = 16;
            this.medianButton.Text = "Медиана";
            this.medianButton.UseVisualStyleBackColor = true;
            this.medianButton.Click += new System.EventHandler(this.medianButton_Click);
            this.redo.Location = new System.Drawing.Point(817, 756);
            this.redo.Name = "redo";
            this.redo.Size = new System.Drawing.Size(80, 23);
            this.redo.TabIndex = 15;
            this.redo.Text = "Применить";
            this.redo.UseVisualStyleBackColor = true;
            this.redo.Click += new System.EventHandler(this.redo_Click);
            this.undoButton.Location = new System.Drawing.Point(817, 726);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(80, 24);
            this.undoButton.TabIndex = 14;
            this.undoButton.Text = "Отменить";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            this.currentTextBox.Location = new System.Drawing.Point(797, 787);
            this.currentTextBox.Name = "currentTextBox";
            this.currentTextBox.Size = new System.Drawing.Size(100, 23);
            this.currentTextBox.TabIndex = 13;
            this.allTextBox.Location = new System.Drawing.Point(636, 787);
            this.allTextBox.Name = "allTextBox";
            this.allTextBox.Size = new System.Drawing.Size(100, 23);
            this.allTextBox.TabIndex = 12;
            this.label5.Location = new System.Drawing.Point(742, 787);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Current";
            this.label4.Location = new System.Drawing.Point(607, 787);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "All";
            this.devide.Location = new System.Drawing.Point(17, 239);
            this.devide.Name = "devide";
            this.devide.Size = new System.Drawing.Size(71, 21);
            this.devide.TabIndex = 9;
            this.devide.Text = "/";
            this.devide.UseVisualStyleBackColor = true;
            this.multiply.Location = new System.Drawing.Point(19, 211);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(72, 21);
            this.multiply.TabIndex = 8;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.minus.Location = new System.Drawing.Point(17, 182);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 7;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            this.plus.Location = new System.Drawing.Point(17, 153);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(77, 23);
            this.plus.TabIndex = 6;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            this.label3.Location = new System.Drawing.Point(108, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ввод";
            this.label1.Location = new System.Drawing.Point(94, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Данные";
            this.input.Location = new System.Drawing.Point(156, 117);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(766, 22);
            this.input.TabIndex = 2;
            this.input.Text = "";
            this.data.Location = new System.Drawing.Point(159, 0);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(765, 110);
            this.data.TabIndex = 0;
            this.data.Text = "";
            this.errorProvider1.ContainerControl = this;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 838);
            this.Controls.Add(this.tabControl1);
            this.Name = "CalculatorView";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button medianButton;
        private System.Windows.Forms.Button deviationButton;
    }
}
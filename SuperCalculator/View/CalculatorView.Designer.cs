﻿namespace SuperCalculator
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
            this.outputFileButton = new System.Windows.Forms.Button();
            this.inputFileButton = new System.Windows.Forms.Button();
            this.dataTextBox = new System.Windows.Forms.RichTextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(343, 541);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.outputFileButton);
            this.tabPage1.Controls.Add(this.inputFileButton);
            this.tabPage1.Controls.Add(this.dataTextBox);
            this.tabPage1.Controls.Add(this.enterButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(335, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ввод";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // outputFileButton
            // 
            this.outputFileButton.Location = new System.Drawing.Point(98, 360);
            this.outputFileButton.Name = "outputFileButton";
            this.outputFileButton.Size = new System.Drawing.Size(116, 59);
            this.outputFileButton.TabIndex = 3;
            this.outputFileButton.Text = "вывести в файл";
            this.outputFileButton.UseVisualStyleBackColor = true;
            this.outputFileButton.Click += new System.EventHandler(this.outputFileButton_Click);
            // 
            // inputFileButton
            // 
            this.inputFileButton.Location = new System.Drawing.Point(98, 284);
            this.inputFileButton.Name = "inputFileButton";
            this.inputFileButton.Size = new System.Drawing.Size(116, 52);
            this.inputFileButton.TabIndex = 2;
            this.inputFileButton.Text = "ввести из файла";
            this.inputFileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.inputFileButton.UseVisualStyleBackColor = true;
            this.inputFileButton.Click += new System.EventHandler(this.inputFileButton_Click);
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(6, 6);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(321, 192);
            this.dataTextBox.TabIndex = 1;
            this.dataTextBox.Text = "";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(98, 214);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(116, 55);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "ввести";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(335, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Калькулятор";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(19, 344);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 56);
            this.button6.TabIndex = 23;
            this.button6.Text = "!";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(119, 347);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 53);
            this.button5.TabIndex = 22;
            this.button5.Text = "log";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(217, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 54);
            this.button4.TabIndex = 21;
            this.button4.Text = "y√x";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 53);
            this.button3.TabIndex = 20;
            this.button3.Text = "√x";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 53);
            this.button2.TabIndex = 19;
            this.button2.Text = "x^2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 53);
            this.button1.TabIndex = 18;
            this.button1.Text = "x^y";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deviationButton
            // 
            this.deviationButton.Location = new System.Drawing.Point(217, 163);
            this.deviationButton.Name = "deviationButton";
            this.deviationButton.Size = new System.Drawing.Size(104, 56);
            this.deviationButton.TabIndex = 17;
            this.deviationButton.Text = "Отклонение";
            this.deviationButton.UseVisualStyleBackColor = true;
            this.deviationButton.Click += new System.EventHandler(this.deviationButton_Click);
            // 
            // medianButton
            // 
            this.medianButton.Location = new System.Drawing.Point(217, 225);
            this.medianButton.Name = "medianButton";
            this.medianButton.Size = new System.Drawing.Size(104, 56);
            this.medianButton.TabIndex = 16;
            this.medianButton.Text = "Медиана";
            this.medianButton.UseVisualStyleBackColor = true;
            this.medianButton.Click += new System.EventHandler(this.medianButton_Click);
            // 
            // redo
            // 
            this.redo.Location = new System.Drawing.Point(176, 405);
            this.redo.Name = "redo";
            this.redo.Size = new System.Drawing.Size(145, 63);
            this.redo.TabIndex = 15;
            this.redo.Text = "Применить";
            this.redo.UseVisualStyleBackColor = true;
            this.redo.Click += new System.EventHandler(this.redo_Click);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(21, 406);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(149, 62);
            this.undoButton.TabIndex = 14;
            this.undoButton.Text = "Отменить";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // currentTextBox
            // 
            this.currentTextBox.Location = new System.Drawing.Point(214, 473);
            this.currentTextBox.Name = "currentTextBox";
            this.currentTextBox.Size = new System.Drawing.Size(114, 25);
            this.currentTextBox.TabIndex = 13;
            // 
            // allTextBox
            // 
            this.allTextBox.Location = new System.Drawing.Point(39, 479);
            this.allTextBox.Name = "allTextBox";
            this.allTextBox.Size = new System.Drawing.Size(114, 25);
            this.allTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(159, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Current";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "All";
            // 
            // devide
            // 
            this.devide.Location = new System.Drawing.Point(118, 225);
            this.devide.Name = "devide";
            this.devide.Size = new System.Drawing.Size(93, 54);
            this.devide.TabIndex = 9;
            this.devide.Text = "/";
            this.devide.UseVisualStyleBackColor = true;
            this.devide.Click += new System.EventHandler(this.devide_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(118, 163);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(93, 56);
            this.multiply.TabIndex = 8;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(19, 225);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(93, 54);
            this.minus.TabIndex = 7;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(19, 163);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(93, 56);
            this.plus.TabIndex = 6;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ввод";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Данные";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(77, 128);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(244, 23);
            this.input.TabIndex = 2;
            this.input.Text = "";
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(78, 2);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(243, 117);
            this.data.TabIndex = 0;
            this.data.Text = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CalculatorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 541);
            this.Controls.Add(this.tabControl1);
            this.Name = "CalculatorView";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Button inputFileButton;
        private System.Windows.Forms.Button outputFileButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}
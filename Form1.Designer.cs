namespace Calculadora
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
            this.closeButton = new System.Windows.Forms.Panel();
            this.equalsButton = new System.Windows.Forms.Button();
            this.pointButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.negativeButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.stepBackButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.virtualDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.closeButton.Location = new System.Drawing.Point(250, 1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 30);
            this.closeButton.TabIndex = 0;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // equalsButton
            // 
            this.equalsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(68)))), ((int)(((byte)(108)))));
            this.equalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equalsButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equalsButton.ForeColor = System.Drawing.Color.White;
            this.equalsButton.Location = new System.Drawing.Point(250, 335);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(75, 51);
            this.equalsButton.TabIndex = 1;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = false;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // pointButton
            // 
            this.pointButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.pointButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pointButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pointButton.ForeColor = System.Drawing.Color.White;
            this.pointButton.Location = new System.Drawing.Point(169, 335);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(75, 51);
            this.pointButton.TabIndex = 2;
            this.pointButton.Text = ".";
            this.pointButton.UseVisualStyleBackColor = false;
            // 
            // zeroButton
            // 
            this.zeroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.zeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zeroButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zeroButton.ForeColor = System.Drawing.Color.White;
            this.zeroButton.Location = new System.Drawing.Point(88, 335);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(75, 51);
            this.zeroButton.TabIndex = 3;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // negativeButton
            // 
            this.negativeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.negativeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.negativeButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.negativeButton.ForeColor = System.Drawing.Color.White;
            this.negativeButton.Location = new System.Drawing.Point(7, 335);
            this.negativeButton.Name = "negativeButton";
            this.negativeButton.Size = new System.Drawing.Size(75, 51);
            this.negativeButton.TabIndex = 4;
            this.negativeButton.Text = "+/-";
            this.negativeButton.UseVisualStyleBackColor = false;
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.oneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oneButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oneButton.ForeColor = System.Drawing.Color.White;
            this.oneButton.Location = new System.Drawing.Point(7, 278);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(75, 51);
            this.oneButton.TabIndex = 5;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.twoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.twoButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.twoButton.ForeColor = System.Drawing.Color.White;
            this.twoButton.Location = new System.Drawing.Point(88, 278);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(75, 51);
            this.twoButton.TabIndex = 6;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.threeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.threeButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.threeButton.ForeColor = System.Drawing.Color.White;
            this.threeButton.Location = new System.Drawing.Point(169, 278);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(75, 51);
            this.threeButton.TabIndex = 7;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(250, 278);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 51);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.fourButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fourButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fourButton.ForeColor = System.Drawing.Color.White;
            this.fourButton.Location = new System.Drawing.Point(7, 221);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(75, 51);
            this.fourButton.TabIndex = 9;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.fiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fiveButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fiveButton.ForeColor = System.Drawing.Color.White;
            this.fiveButton.Location = new System.Drawing.Point(88, 221);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(75, 51);
            this.fiveButton.TabIndex = 10;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.sixButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sixButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sixButton.ForeColor = System.Drawing.Color.White;
            this.sixButton.Location = new System.Drawing.Point(169, 221);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(75, 51);
            this.sixButton.TabIndex = 11;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.subtractButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subtractButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtractButton.ForeColor = System.Drawing.Color.White;
            this.subtractButton.Location = new System.Drawing.Point(250, 221);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(75, 51);
            this.subtractButton.TabIndex = 12;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = false;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.sevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sevenButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sevenButton.ForeColor = System.Drawing.Color.White;
            this.sevenButton.Location = new System.Drawing.Point(7, 164);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(75, 51);
            this.sevenButton.TabIndex = 13;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.eightButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eightButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eightButton.ForeColor = System.Drawing.Color.White;
            this.eightButton.Location = new System.Drawing.Point(88, 164);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(75, 51);
            this.eightButton.TabIndex = 14;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.nineButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nineButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nineButton.ForeColor = System.Drawing.Color.White;
            this.nineButton.Location = new System.Drawing.Point(169, 164);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(75, 51);
            this.nineButton.TabIndex = 15;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.multiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiplyButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiplyButton.ForeColor = System.Drawing.Color.White;
            this.multiplyButton.Location = new System.Drawing.Point(250, 164);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(75, 51);
            this.multiplyButton.TabIndex = 16;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // stepBackButton
            // 
            this.stepBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.stepBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stepBackButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stepBackButton.ForeColor = System.Drawing.Color.White;
            this.stepBackButton.Location = new System.Drawing.Point(7, 107);
            this.stepBackButton.Name = "stepBackButton";
            this.stepBackButton.Size = new System.Drawing.Size(75, 51);
            this.stepBackButton.TabIndex = 17;
            this.stepBackButton.Text = "CE";
            this.stepBackButton.UseVisualStyleBackColor = false;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.resetButton.Location = new System.Drawing.Point(88, 107);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 51);
            this.resetButton.TabIndex = 18;
            this.resetButton.Text = "C";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // backspaceButton
            // 
            this.backspaceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.backspaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backspaceButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backspaceButton.ForeColor = System.Drawing.Color.White;
            this.backspaceButton.Location = new System.Drawing.Point(169, 107);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(75, 51);
            this.backspaceButton.TabIndex = 19;
            this.backspaceButton.Text = "<=";
            this.backspaceButton.UseVisualStyleBackColor = false;
            this.backspaceButton.Click += new System.EventHandler(this.backspaceButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.divideButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.divideButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divideButton.ForeColor = System.Drawing.Color.White;
            this.divideButton.Location = new System.Drawing.Point(250, 107);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(75, 51);
            this.divideButton.TabIndex = 20;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = false;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // virtualDisplay
            // 
            this.virtualDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.virtualDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.virtualDisplay.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.virtualDisplay.ForeColor = System.Drawing.Color.White;
            this.virtualDisplay.Location = new System.Drawing.Point(12, 51);
            this.virtualDisplay.Name = "virtualDisplay";
            this.virtualDisplay.PlaceholderText = "0";
            this.virtualDisplay.ReadOnly = true;
            this.virtualDisplay.Size = new System.Drawing.Size(304, 50);
            this.virtualDisplay.TabIndex = 21;
            this.virtualDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(328, 389);
            this.Controls.Add(this.virtualDisplay);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.backspaceButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stepBackButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.negativeButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.pointButton);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel closeButton;
        private Button equalsButton;
        private Button pointButton;
        private Button zeroButton;
        private Button negativeButton;
        private Button oneButton;
        private Button twoButton;
        private Button threeButton;
        private Button addButton;
        private Button fourButton;
        private Button fiveButton;
        private Button sixButton;
        private Button subtractButton;
        private Button sevenButton;
        private Button eightButton;
        private Button nineButton;
        private Button multiplyButton;
        private Button stepBackButton;
        private Button resetButton;
        private Button backspaceButton;
        private Button divideButton;
        private TextBox virtualDisplay;
    }
}
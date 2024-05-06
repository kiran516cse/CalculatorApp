namespace CalculatorApp
{
    partial class Calculator
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
            txtBoxDisplayData = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnEquals = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btnAddition = new Button();
            btnSubtraction = new Button();
            btnMultiplication = new Button();
            btnDivision = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtBoxDisplayData
            // 
            txtBoxDisplayData.BackColor = Color.White;
            txtBoxDisplayData.Font = new Font("Segoe UI", 18F);
            txtBoxDisplayData.Location = new Point(12, 12);
            txtBoxDisplayData.Name = "txtBoxDisplayData";
            txtBoxDisplayData.ReadOnly = true;
            txtBoxDisplayData.Size = new Size(260, 39);
            txtBoxDisplayData.TabIndex = 0;
            txtBoxDisplayData.Text = "0";
            txtBoxDisplayData.TextAlign = HorizontalAlignment.Right;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 12F);
            btn7.Location = new Point(12, 58);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 40);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += NumberButton_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 12F);
            btn8.Location = new Point(78, 58);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 40);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += NumberButton_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 12F);
            btn9.Location = new Point(144, 58);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 40);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += NumberButton_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 12F);
            btn6.Location = new Point(144, 104);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 40);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += NumberButton_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 12F);
            btn5.Location = new Point(78, 104);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 40);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += NumberButton_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 12F);
            btn4.Location = new Point(12, 104);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 40);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += NumberButton_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 12F);
            btn3.Location = new Point(144, 150);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 40);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += NumberButton_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 12F);
            btn2.Location = new Point(78, 150);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 40);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += NumberButton_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 12F);
            btn1.Location = new Point(12, 150);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 40);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += NumberButton_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.LightSkyBlue;
            btnEquals.Font = new Font("Segoe UI", 12F);
            btnEquals.Location = new Point(144, 196);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(60, 40);
            btnEquals.TabIndex = 12;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += EqualsButton_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI", 12F);
            btnDot.Location = new Point(78, 196);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(60, 40);
            btnDot.TabIndex = 11;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.AutoSizeChanged += NumberButton_Click;
            btnDot.Click += NumberButton_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 12F);
            btn0.Location = new Point(12, 196);
            btn0.Name = "btn0";
            btn0.Size = new Size(60, 40);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.AutoSizeChanged += NumberButton_Click;
            btn0.Click += NumberButton_Click;
            // 
            // btnAddition
            // 
            btnAddition.BackColor = SystemColors.InactiveCaption;
            btnAddition.Font = new Font("Segoe UI", 12F);
            btnAddition.Location = new Point(210, 196);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(60, 40);
            btnAddition.TabIndex = 16;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = false;
            btnAddition.Click += OperationButton_Click;
            // 
            // btnSubtraction
            // 
            btnSubtraction.BackColor = SystemColors.InactiveCaption;
            btnSubtraction.Font = new Font("Segoe UI", 12F);
            btnSubtraction.Location = new Point(210, 150);
            btnSubtraction.Name = "btnSubtraction";
            btnSubtraction.Size = new Size(60, 40);
            btnSubtraction.TabIndex = 15;
            btnSubtraction.Text = "-";
            btnSubtraction.UseVisualStyleBackColor = false;
            btnSubtraction.Click += OperationButton_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.BackColor = SystemColors.InactiveCaption;
            btnMultiplication.Font = new Font("Segoe UI", 12F);
            btnMultiplication.Location = new Point(210, 104);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(60, 40);
            btnMultiplication.TabIndex = 14;
            btnMultiplication.Text = "×";
            btnMultiplication.UseVisualStyleBackColor = false;
            btnMultiplication.Click += OperationButton_Click;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = SystemColors.InactiveCaption;
            btnDivision.Font = new Font("Segoe UI", 12F);
            btnDivision.Location = new Point(210, 58);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(60, 40);
            btnDivision.TabIndex = 13;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += OperationButton_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightGray;
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.Location = new Point(12, 240);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(260, 40);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += ClearButton_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 291);
            Controls.Add(btnClear);
            Controls.Add(btnAddition);
            Controls.Add(btnSubtraction);
            Controls.Add(btnMultiplication);
            Controls.Add(btnDivision);
            Controls.Add(btnEquals);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtBoxDisplayData);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxDisplayData;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnEquals;
        private Button btnDot;
        private Button btn0;
        private Button btnAddition;
        private Button btnSubtraction;
        private Button btnMultiplication;
        private Button btnDivision;
        private Button btnClear;
    }
}

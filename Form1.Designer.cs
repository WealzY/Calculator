namespace Calculator
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
            txtDisplay = new TextBox();
            label1 = new Label();
            cmbBase = new ComboBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            btnA = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            btnDivide = new Button();
            btnEquals = new Button();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnClear = new Button();
            btnMultiply = new Button();
            btnSing = new Button();
            btnDot = new Button();
            btnSqrt = new Button();
            btnSquare = new Button();
            btnPower = new Button();
            btnSin = new Button();
            btnCos = new Button();
            btnBackspace = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(393, 50);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 65);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 1;
            label1.Text = "Система счисления";
            // 
            // cmbBase
            // 
            cmbBase.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBase.FormattingEnabled = true;
            cmbBase.Items.AddRange(new object[] { "2", "10", "16" });
            cmbBase.Location = new Point(147, 83);
            cmbBase.Name = "cmbBase";
            cmbBase.Size = new Size(121, 23);
            cmbBase.TabIndex = 2;
            cmbBase.SelectedIndexChanged += cmbBase_SelectedIndexChanged;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn7.Location = new Point(15, 180);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 45);
            btn7.TabIndex = 3;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn8.Location = new Point(81, 180);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 45);
            btn8.TabIndex = 4;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn9.Location = new Point(147, 180);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 45);
            btn9.TabIndex = 5;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn4.Location = new Point(15, 231);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 45);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn5.Location = new Point(81, 231);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 45);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn6.Location = new Point(147, 231);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 45);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn1.Location = new Point(15, 282);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 45);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn2.Location = new Point(81, 282);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 45);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn3.Location = new Point(147, 282);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 45);
            btn3.TabIndex = 11;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn0.Location = new Point(81, 333);
            btn0.Name = "btn0";
            btn0.Size = new Size(60, 45);
            btn0.TabIndex = 12;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btnA
            // 
            btnA.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnA.Location = new Point(15, 112);
            btnA.Name = "btnA";
            btnA.Size = new Size(60, 45);
            btnA.TabIndex = 13;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(81, 112);
            button2.Name = "button2";
            button2.Size = new Size(60, 45);
            button2.TabIndex = 14;
            button2.Text = "B";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(147, 112);
            button3.Name = "button3";
            button3.Size = new Size(60, 45);
            button3.TabIndex = 15;
            button3.Text = "C";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.Location = new Point(213, 112);
            button4.Name = "button4";
            button4.Size = new Size(60, 45);
            button4.TabIndex = 16;
            button4.Text = "D";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button5.Location = new Point(279, 112);
            button5.Name = "button5";
            button5.Size = new Size(60, 45);
            button5.TabIndex = 17;
            button5.Text = "E";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button6.Location = new Point(345, 112);
            button6.Name = "button6";
            button6.Size = new Size(60, 45);
            button6.TabIndex = 18;
            button6.Text = "F";
            button6.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDivide.Location = new Point(279, 180);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(60, 45);
            btnDivide.TabIndex = 19;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEquals.Location = new Point(279, 282);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(60, 45);
            btnEquals.TabIndex = 24;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAdd.Location = new Point(345, 231);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(60, 45);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSubtract.Location = new Point(279, 231);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(60, 45);
            btnSubtract.TabIndex = 22;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnClear.Location = new Point(345, 282);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(60, 45);
            btnClear.TabIndex = 21;
            btnClear.Text = "AC";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnMultiply.Location = new Point(345, 180);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(60, 45);
            btnMultiply.TabIndex = 20;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnSing
            // 
            btnSing.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSing.Location = new Point(15, 333);
            btnSing.Name = "btnSing";
            btnSing.Size = new Size(60, 45);
            btnSing.TabIndex = 25;
            btnSing.Text = "+/-";
            btnSing.UseVisualStyleBackColor = true;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDot.Location = new Point(147, 333);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(60, 45);
            btnDot.TabIndex = 26;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            // 
            // btnSqrt
            // 
            btnSqrt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSqrt.Location = new Point(15, 400);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(60, 45);
            btnSqrt.TabIndex = 27;
            btnSqrt.Text = "sqrt";
            btnSqrt.UseVisualStyleBackColor = true;
            // 
            // btnSquare
            // 
            btnSquare.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSquare.Location = new Point(81, 400);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(60, 45);
            btnSquare.TabIndex = 28;
            btnSquare.Text = "x^2";
            btnSquare.UseVisualStyleBackColor = true;
            // 
            // btnPower
            // 
            btnPower.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnPower.Location = new Point(147, 400);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(60, 45);
            btnPower.TabIndex = 29;
            btnPower.Text = "x^y";
            btnPower.UseVisualStyleBackColor = true;
            // 
            // btnSin
            // 
            btnSin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSin.Location = new Point(213, 400);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(60, 45);
            btnSin.TabIndex = 30;
            btnSin.Text = "sin";
            btnSin.UseVisualStyleBackColor = true;
            // 
            // btnCos
            // 
            btnCos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCos.Location = new Point(279, 400);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(60, 45);
            btnCos.TabIndex = 31;
            btnCos.Text = "cos";
            btnCos.UseVisualStyleBackColor = true;
            // 
            // btnBackspace
            // 
            btnBackspace.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnBackspace.Location = new Point(314, 333);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(60, 32);
            btnBackspace.TabIndex = 32;
            btnBackspace.Text = "<-";
            btnBackspace.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 452);
            Controls.Add(btnBackspace);
            Controls.Add(btnCos);
            Controls.Add(btnSin);
            Controls.Add(btnPower);
            Controls.Add(btnSquare);
            Controls.Add(btnSqrt);
            Controls.Add(btnDot);
            Controls.Add(btnSing);
            Controls.Add(btnEquals);
            Controls.Add(btnAdd);
            Controls.Add(btnSubtract);
            Controls.Add(btnClear);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnA);
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
            Controls.Add(cmbBase);
            Controls.Add(label1);
            Controls.Add(txtDisplay);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Инженерный калькулятор";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Label label1;
        private ComboBox cmbBase;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn0;
        private Button btnA;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button btnDivide;
        private Button btnEquals;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnClear;
        private Button btnMultiply;
        private Button button1;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button btnBackspace;
        private Button btnSing;
        private Button btnDot;
        private Button btnSqrt;
        private Button btnSquare;
        private Button btnPower;
        private Button btnSin;
        private Button btnCos;
    }
}

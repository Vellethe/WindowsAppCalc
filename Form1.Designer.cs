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
            totalWindow = new TextBox();
            btnEqual = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMultiply = new Button();
            btnDivided = new Button();
            btnClear = new Button();
            btnPlusMinus = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btnProcent = new Button();
            btnDecimal = new Button();
            btnInverse = new Button();
            btn7 = new Button();
            btn0 = new Button();
            btn2 = new Button();
            btn2x = new Button();
            button17 = new Button();
            clearWindow = new Button();
            btn8 = new Button();
            btn5 = new Button();
            btnsquareroot = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn3 = new Button();
            ongoingCalcLabel = new Label();
            SuspendLayout();
            // 
            // totalWindow
            // 
            totalWindow.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalWindow.Location = new Point(11, 34);
            totalWindow.Multiline = true;
            totalWindow.Name = "totalWindow";
            totalWindow.Size = new Size(455, 75);
            totalWindow.TabIndex = 0;
            totalWindow.TextAlign = HorizontalAlignment.Right;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = SystemColors.ControlDark;
            btnEqual.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(357, 445);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(109, 60);
            btnEqual.TabIndex = 5;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.ControlDark;
            btnPlus.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(357, 379);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(109, 60);
            btnPlus.TabIndex = 6;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = SystemColors.ControlDark;
            btnMinus.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(357, 313);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(109, 60);
            btnMinus.TabIndex = 7;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = SystemColors.ControlDark;
            btnMultiply.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(357, 247);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(109, 60);
            btnMultiply.TabIndex = 8;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivided
            // 
            btnDivided.BackColor = SystemColors.ControlDark;
            btnDivided.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnDivided.Location = new Point(357, 181);
            btnDivided.Name = "btnDivided";
            btnDivided.Size = new Size(109, 60);
            btnDivided.TabIndex = 9;
            btnDivided.Text = "÷\r\n";
            btnDivided.UseVisualStyleBackColor = false;
            btnDivided.Click += btnDivided_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlDark;
            btnClear.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(357, 115);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 60);
            btnClear.TabIndex = 10;
            btnClear.Text = "⌫";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.BackColor = SystemColors.ControlDark;
            btnPlusMinus.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlusMinus.Location = new Point(12, 445);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(109, 60);
            btnPlusMinus.TabIndex = 11;
            btnPlusMinus.Text = "+/-";
            btnPlusMinus.UseVisualStyleBackColor = false;
            btnPlusMinus.Click += btnPlusMinus_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ControlDark;
            btn4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(12, 313);
            btn4.Name = "btn4";
            btn4.Size = new Size(109, 60);
            btn4.TabIndex = 12;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ControlDark;
            btn1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(12, 379);
            btn1.Name = "btn1";
            btn1.Size = new Size(109, 60);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btnProcent
            // 
            btnProcent.BackColor = SystemColors.ControlDark;
            btnProcent.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProcent.Location = new Point(12, 115);
            btnProcent.Name = "btnProcent";
            btnProcent.Size = new Size(109, 60);
            btnProcent.TabIndex = 14;
            btnProcent.Text = "%";
            btnProcent.UseVisualStyleBackColor = false;
            btnProcent.Click += btnProcent_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = SystemColors.ControlDark;
            btnDecimal.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDecimal.Location = new Point(242, 445);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(109, 60);
            btnDecimal.TabIndex = 15;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = false;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnInverse
            // 
            btnInverse.BackColor = SystemColors.ControlDark;
            btnInverse.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInverse.Location = new Point(12, 181);
            btnInverse.Name = "btnInverse";
            btnInverse.Size = new Size(109, 60);
            btnInverse.TabIndex = 16;
            btnInverse.Text = "1/x";
            btnInverse.UseVisualStyleBackColor = false;
            btnInverse.Click += btnInverse_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ControlDark;
            btn7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(12, 247);
            btn7.Name = "btn7";
            btn7.Size = new Size(109, 60);
            btn7.TabIndex = 17;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ControlDark;
            btn0.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(127, 445);
            btn0.Name = "btn0";
            btn0.Size = new Size(109, 60);
            btn0.TabIndex = 18;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ControlDark;
            btn2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(127, 379);
            btn2.Name = "btn2";
            btn2.Size = new Size(109, 60);
            btn2.TabIndex = 19;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn2x
            // 
            btn2x.BackColor = SystemColors.ControlDark;
            btn2x.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2x.Location = new Point(127, 181);
            btn2x.Name = "btn2x";
            btn2x.Size = new Size(109, 60);
            btn2x.TabIndex = 20;
            btn2x.Text = "x²";
            btn2x.UseVisualStyleBackColor = false;
            btn2x.Click += btn2x_Click;
            // 
            // button17
            // 
            button17.BackColor = SystemColors.ControlDark;
            button17.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button17.Location = new Point(242, 115);
            button17.Name = "button17";
            button17.Size = new Size(109, 60);
            button17.TabIndex = 21;
            button17.Text = "C";
            button17.UseVisualStyleBackColor = false;
            button17.Click += btnEraser_Click;
            // 
            // clearWindow
            // 
            clearWindow.BackColor = SystemColors.ControlDark;
            clearWindow.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearWindow.Location = new Point(127, 115);
            clearWindow.Name = "clearWindow";
            clearWindow.Size = new Size(109, 60);
            clearWindow.TabIndex = 22;
            clearWindow.Text = "CE";
            clearWindow.UseVisualStyleBackColor = false;
            clearWindow.Click += clearWindow_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ControlDark;
            btn8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(127, 247);
            btn8.Name = "btn8";
            btn8.Size = new Size(109, 60);
            btn8.TabIndex = 23;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ControlDark;
            btn5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(127, 313);
            btn5.Name = "btn5";
            btn5.Size = new Size(109, 60);
            btn5.TabIndex = 24;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btnsquareroot
            // 
            btnsquareroot.BackColor = SystemColors.ControlDark;
            btnsquareroot.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsquareroot.Location = new Point(242, 181);
            btnsquareroot.Name = "btnsquareroot";
            btnsquareroot.Size = new Size(109, 60);
            btnsquareroot.TabIndex = 25;
            btnsquareroot.Text = "2√x";
            btnsquareroot.UseVisualStyleBackColor = false;
            btnsquareroot.Click += btnsquareroot_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ControlDark;
            btn9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(242, 247);
            btn9.Name = "btn9";
            btn9.Size = new Size(109, 60);
            btn9.TabIndex = 26;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ControlDark;
            btn6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(242, 313);
            btn6.Name = "btn6";
            btn6.Size = new Size(109, 60);
            btn6.TabIndex = 27;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ControlDark;
            btn3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(242, 379);
            btn3.Name = "btn3";
            btn3.Size = new Size(109, 60);
            btn3.TabIndex = 28;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // ongoingCalcLabel
            // 
            ongoingCalcLabel.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ongoingCalcLabel.Location = new Point(361, 9);
            ongoingCalcLabel.Name = "ongoingCalcLabel";
            ongoingCalcLabel.RightToLeft = RightToLeft.Yes;
            ongoingCalcLabel.Size = new Size(105, 25);
            ongoingCalcLabel.TabIndex = 29;
            ongoingCalcLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 517);
            Controls.Add(ongoingCalcLabel);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btnsquareroot);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(clearWindow);
            Controls.Add(button17);
            Controls.Add(btn2x);
            Controls.Add(btn2);
            Controls.Add(btn0);
            Controls.Add(btn7);
            Controls.Add(btnInverse);
            Controls.Add(btnDecimal);
            Controls.Add(btnProcent);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btnPlusMinus);
            Controls.Add(btnClear);
            Controls.Add(btnDivided);
            Controls.Add(btnMultiply);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btnEqual);
            Controls.Add(totalWindow);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox totalWindow;
        private Button btnsquareroot;
        private Button btn9;
        private Button button17;
        private Button btn6;
        private Button btn3;
        private Button btnEqual;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnDivided;
        private Button btnClear;
        private Button btnPlusMinus;
        private Button btn4;
        private Button btn1;
        private Button btnProcent;
        private Button btnDecimal;
        private Button btnInverse;
        private Button btn7;
        private Button btn0;
        private Button btn2;
        private Button btn2x;
        private Button clearWindow;
        private Button btn8;
        private Button btn5;
        private Label ongoingCalcLabel;
    }
}

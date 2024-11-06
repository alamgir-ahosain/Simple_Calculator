namespace projectCalculator
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
            textBoxResult = new TextBox();
            btnClear = new Button();
            btnNine = new Button();
            btnEight = new Button();
            btnSeven = new Button();
            btnPlus = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnMinus = new Button();
            btnThree = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            btnMultiply = new Button();
            btnDivided = new Button();
            btnZerro = new Button();
            btnDot = new Button();
            btnEqual = new Button();
            btnClearEntry = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.ControlText;
            textBoxResult.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxResult.ForeColor = SystemColors.Window;
            textBoxResult.Location = new Point(134, 34);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(529, 53);
            textBoxResult.TabIndex = 0;
            textBoxResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnClear.Location = new Point(134, 393);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(252, 48);
            btnClear.TabIndex = 1;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnNine
            // 
            btnNine.BackColor = SystemColors.ButtonFace;
            btnNine.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnNine.Location = new Point(420, 117);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(107, 47);
            btnNine.TabIndex = 2;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = false;
            btnNine.Click += btnNine_Click;
            // 
            // btnEight
            // 
            btnEight.BackColor = SystemColors.ButtonFace;
            btnEight.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnEight.Location = new Point(279, 116);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(107, 48);
            btnEight.TabIndex = 3;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = false;
            btnEight.Click += button3_Click;
            // 
            // btnSeven
            // 
            btnSeven.BackColor = SystemColors.ButtonFace;
            btnSeven.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnSeven.Location = new Point(134, 116);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(107, 48);
            btnSeven.TabIndex = 4;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = false;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.ButtonFace;
            btnPlus.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnPlus.Location = new Point(556, 196);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(107, 44);
            btnPlus.TabIndex = 5;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnSix
            // 
            btnSix.BackColor = SystemColors.ButtonFace;
            btnSix.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnSix.Location = new Point(420, 196);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(107, 44);
            btnSix.TabIndex = 6;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = false;
            btnSix.Click += btnSix_Click;
            // 
            // btnFive
            // 
            btnFive.BackColor = SystemColors.ButtonFace;
            btnFive.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnFive.Location = new Point(279, 196);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(107, 44);
            btnFive.TabIndex = 7;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = false;
            btnFive.Click += btnFive_Click;
            // 
            // btnFour
            // 
            btnFour.BackColor = SystemColors.ButtonFace;
            btnFour.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnFour.Location = new Point(134, 196);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(107, 44);
            btnFour.TabIndex = 8;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = false;
            btnFour.Click += btnFour_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = SystemColors.ButtonFace;
            btnMinus.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnMinus.Location = new Point(556, 266);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(107, 43);
            btnMinus.TabIndex = 9;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnThree
            // 
            btnThree.BackColor = SystemColors.ButtonFace;
            btnThree.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnThree.Location = new Point(420, 266);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(107, 43);
            btnThree.TabIndex = 10;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = false;
            btnThree.Click += btnThree_Click;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = SystemColors.ButtonFace;
            btnTwo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnTwo.Location = new Point(279, 266);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(107, 43);
            btnTwo.TabIndex = 11;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = false;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnOne
            // 
            btnOne.BackColor = SystemColors.ButtonFace;
            btnOne.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnOne.Location = new Point(134, 266);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(107, 43);
            btnOne.TabIndex = 12;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += btnOne_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = SystemColors.ButtonFace;
            btnMultiply.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnMultiply.Location = new Point(556, 336);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(107, 42);
            btnMultiply.TabIndex = 13;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivided
            // 
            btnDivided.BackColor = SystemColors.ButtonFace;
            btnDivided.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnDivided.Location = new Point(403, 342);
            btnDivided.Name = "btnDivided";
            btnDivided.Size = new Size(124, 42);
            btnDivided.TabIndex = 14;
            btnDivided.Text = "/";
            btnDivided.UseVisualStyleBackColor = false;
            btnDivided.Click += btnDivided_Click;
            // 
            // btnZerro
            // 
            btnZerro.BackColor = SystemColors.ButtonFace;
            btnZerro.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnZerro.Location = new Point(279, 342);
            btnZerro.Name = "btnZerro";
            btnZerro.Size = new Size(107, 42);
            btnZerro.TabIndex = 15;
            btnZerro.Text = "0";
            btnZerro.UseVisualStyleBackColor = false;
            btnZerro.Click += btnZerro_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = SystemColors.ButtonFace;
            btnDot.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnDot.Location = new Point(134, 342);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(107, 42);
            btnDot.TabIndex = 16;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.PaleGreen;
            btnEqual.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnEqual.Location = new Point(403, 396);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(260, 42);
            btnEqual.TabIndex = 17;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnClearEntry
            // 
            btnClearEntry.BackColor = Color.Red;
            btnClearEntry.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnClearEntry.Location = new Point(556, 116);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(107, 42);
            btnClearEntry.TabIndex = 18;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = false;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlText;
            textBox1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(12, 49);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(89, 24);
            textBox1.TabIndex = 19;
            textBox1.Text = "alamgirrJK";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(816, 487);
            Controls.Add(textBox1);
            Controls.Add(btnClearEntry);
            Controls.Add(btnEqual);
            Controls.Add(btnDot);
            Controls.Add(btnZerro);
            Controls.Add(btnDivided);
            Controls.Add(btnMultiply);
            Controls.Add(btnOne);
            Controls.Add(btnTwo);
            Controls.Add(btnThree);
            Controls.Add(btnMinus);
            Controls.Add(btnFour);
            Controls.Add(btnFive);
            Controls.Add(btnSix);
            Controls.Add(btnPlus);
            Controls.Add(btnSeven);
            Controls.Add(btnEight);
            Controls.Add(btnNine);
            Controls.Add(btnClear);
            Controls.Add(textBoxResult);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxResult;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button btnEight;
        private Button btnSeven;
        private Button btnClear;
        private Button btnNine;
        private Button btnPlus;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnOne;
        private Button btnMinus;
        private Button btnThree;
        private Button btnTwo;
        private Button btnMultiply;
        private Button btnDivided;
        private Button btnZerro;
        private Button btnDot;
        private Button btnEqual;
        private Button btnClearEntry;
        private TextBox textBox1;
    }
}

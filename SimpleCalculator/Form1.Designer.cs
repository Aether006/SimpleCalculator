namespace SimpleCalculator
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
            Clear = new Button();
            NaturalLog = new Button();
            Sqrt = new Button();
            Add = new Button();
            Output = new TextBox();
            Seven = new Button();
            Eight = new Button();
            Nine = new Button();
            Divide = new Button();
            Multiply = new Button();
            Six = new Button();
            Five = new Button();
            Four = new Button();
            One = new Button();
            Two = new Button();
            Three = new Button();
            Subtract = new Button();
            Equals = new Button();
            Zero = new Button();
            Point = new Button();
            Pi = new Button();
            Power = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // Clear
            // 
            Clear.Location = new Point(16, 132);
            Clear.Name = "Clear";
            Clear.Size = new Size(65, 54);
            Clear.TabIndex = 0;
            Clear.Text = "AC";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // NaturalLog
            // 
            NaturalLog.Location = new Point(87, 132);
            NaturalLog.Name = "NaturalLog";
            NaturalLog.Size = new Size(65, 54);
            NaturalLog.TabIndex = 1;
            NaturalLog.Text = "ln";
            NaturalLog.UseVisualStyleBackColor = true;
            NaturalLog.Click += NaturalLog_Click;
            // 
            // Sqrt
            // 
            Sqrt.Location = new Point(158, 132);
            Sqrt.Name = "Sqrt";
            Sqrt.Size = new Size(65, 54);
            Sqrt.TabIndex = 2;
            Sqrt.Text = "Sqrt";
            Sqrt.UseVisualStyleBackColor = true;
            Sqrt.Click += Sqrt_Click;
            // 
            // Add
            // 
            Add.Location = new Point(229, 312);
            Add.Name = "Add";
            Add.Size = new Size(65, 54);
            Add.TabIndex = 3;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Output
            // 
            Output.BackColor = SystemColors.ControlLightLight;
            Output.Font = new Font("Symbol", 24F, FontStyle.Bold, GraphicsUnit.Point, 2);
            Output.Location = new Point(16, 44);
            Output.Name = "Output";
            Output.ReadOnly = true;
            Output.Size = new Size(278, 47);
            Output.TabIndex = 4;
            Output.Text = "0";
            Output.TextAlign = HorizontalAlignment.Right;
            Output.TextChanged += textBox1_TextChanged;
            // 
            // Seven
            // 
            Seven.Location = new Point(16, 192);
            Seven.Name = "Seven";
            Seven.Size = new Size(65, 54);
            Seven.TabIndex = 5;
            Seven.Text = "7";
            Seven.UseVisualStyleBackColor = true;
            Seven.Click += Seven_Click;
            // 
            // Eight
            // 
            Eight.Location = new Point(87, 192);
            Eight.Name = "Eight";
            Eight.Size = new Size(65, 54);
            Eight.TabIndex = 6;
            Eight.Text = "8";
            Eight.UseVisualStyleBackColor = true;
            Eight.Click += Eight_Click;
            // 
            // Nine
            // 
            Nine.Location = new Point(158, 192);
            Nine.Name = "Nine";
            Nine.Size = new Size(65, 54);
            Nine.TabIndex = 7;
            Nine.Text = "9";
            Nine.UseVisualStyleBackColor = true;
            Nine.Click += Nine_Click;
            // 
            // Divide
            // 
            Divide.Location = new Point(229, 132);
            Divide.Name = "Divide";
            Divide.Size = new Size(65, 54);
            Divide.TabIndex = 8;
            Divide.Text = "/";
            Divide.UseVisualStyleBackColor = true;
            Divide.Click += Divide_Click;
            // 
            // Multiply
            // 
            Multiply.Location = new Point(229, 192);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(65, 54);
            Multiply.TabIndex = 9;
            Multiply.Text = "*";
            Multiply.UseVisualStyleBackColor = true;
            Multiply.Click += Multiply_Click;
            // 
            // Six
            // 
            Six.Location = new Point(158, 252);
            Six.Name = "Six";
            Six.Size = new Size(65, 54);
            Six.TabIndex = 10;
            Six.Text = "6";
            Six.UseVisualStyleBackColor = true;
            Six.Click += Six_Click;
            // 
            // Five
            // 
            Five.Location = new Point(87, 252);
            Five.Name = "Five";
            Five.Size = new Size(65, 54);
            Five.TabIndex = 11;
            Five.Text = "5";
            Five.UseVisualStyleBackColor = true;
            Five.Click += Five_Click;
            // 
            // Four
            // 
            Four.Location = new Point(16, 252);
            Four.Name = "Four";
            Four.Size = new Size(65, 54);
            Four.TabIndex = 12;
            Four.Text = "4";
            Four.UseVisualStyleBackColor = true;
            Four.Click += Four_Click;
            // 
            // One
            // 
            One.Location = new Point(16, 312);
            One.Name = "One";
            One.Size = new Size(65, 54);
            One.TabIndex = 13;
            One.Text = "1";
            One.UseVisualStyleBackColor = true;
            One.Click += One_Click;
            // 
            // Two
            // 
            Two.Location = new Point(87, 312);
            Two.Name = "Two";
            Two.Size = new Size(65, 54);
            Two.TabIndex = 14;
            Two.Text = "2";
            Two.UseVisualStyleBackColor = true;
            Two.Click += Two_Click;
            // 
            // Three
            // 
            Three.Location = new Point(158, 312);
            Three.Name = "Three";
            Three.Size = new Size(65, 54);
            Three.TabIndex = 15;
            Three.Text = "3";
            Three.UseVisualStyleBackColor = true;
            Three.Click += Three_Click;
            // 
            // Subtract
            // 
            Subtract.Location = new Point(229, 252);
            Subtract.Name = "Subtract";
            Subtract.Size = new Size(65, 54);
            Subtract.TabIndex = 16;
            Subtract.Text = "-";
            Subtract.UseVisualStyleBackColor = true;
            Subtract.Click += Subtract_Click;
            // 
            // Equals
            // 
            Equals.Location = new Point(229, 372);
            Equals.Name = "Equals";
            Equals.Size = new Size(65, 114);
            Equals.TabIndex = 17;
            Equals.Text = "=";
            Equals.UseVisualStyleBackColor = true;
            Equals.Click += Equals_Click;
            // 
            // Zero
            // 
            Zero.Location = new Point(16, 372);
            Zero.Name = "Zero";
            Zero.Size = new Size(136, 54);
            Zero.TabIndex = 18;
            Zero.Text = "0";
            Zero.UseVisualStyleBackColor = true;
            Zero.Click += Zero_Click;
            // 
            // Point
            // 
            Point.Location = new Point(158, 372);
            Point.Name = "Point";
            Point.Size = new Size(65, 54);
            Point.TabIndex = 19;
            Point.Text = ".";
            Point.UseVisualStyleBackColor = true;
            Point.Click += Point_Click;
            // 
            // Pi
            // 
            Pi.Location = new Point(16, 432);
            Pi.Name = "Pi";
            Pi.Size = new Size(65, 54);
            Pi.TabIndex = 20;
            Pi.Text = "π";
            Pi.UseVisualStyleBackColor = true;
            Pi.Click += Pi_Click;
            // 
            // Power
            // 
            Power.Location = new Point(87, 432);
            Power.Name = "Power";
            Power.Size = new Size(65, 54);
            Power.TabIndex = 21;
            Power.Text = "^";
            Power.UseVisualStyleBackColor = true;
            Power.Click += Power_Click;
            // 
            // button5
            // 
            button5.Location = new Point(158, 432);
            button5.Name = "button5";
            button5.Size = new Size(65, 54);
            button5.TabIndex = 22;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(309, 502);
            Controls.Add(button5);
            Controls.Add(Power);
            Controls.Add(Pi);
            Controls.Add(Point);
            Controls.Add(Zero);
            Controls.Add(Equals);
            Controls.Add(Subtract);
            Controls.Add(Three);
            Controls.Add(Two);
            Controls.Add(One);
            Controls.Add(Four);
            Controls.Add(Five);
            Controls.Add(Six);
            Controls.Add(Multiply);
            Controls.Add(Divide);
            Controls.Add(Nine);
            Controls.Add(Eight);
            Controls.Add(Seven);
            Controls.Add(Output);
            Controls.Add(Add);
            Controls.Add(Sqrt);
            Controls.Add(NaturalLog);
            Controls.Add(Clear);
            MaximizeBox = false;
            MaximumSize = new Size(325, 541);
            MinimumSize = new Size(325, 541);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Pi;
        private Button NaturalLog;
        private Button Sqrt;
        private TextBox Output;
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
        private Button Zero;
        private Button Point;
        private Button One;
        private Button Two;
        private Button Three;
        private Button Clear;
        private Button Add;
        private Button Seven;
        private Button Eight;
        private Button Nine;
        private Button Divide;
        private Button Multiply;
        private Button Six;
        private Button Five;
        private Button Four;
        private Button Subtract;
        private Button Equals;
        private Button Power;
    }
}

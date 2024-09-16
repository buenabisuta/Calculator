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
            AllClearButton = new Button();
            label1 = new Label();
            resultTextBox = new RichTextBox();
            DivideButton = new Button();
            EightDigitButton = new Button();
            SevenDigitButton = new Button();
            OneDigitButton = new Button();
            CrossButton = new Button();
            NineDigitButton = new Button();
            TwoDigitButton = new Button();
            SixDigitButton = new Button();
            FiveDigitButton = new Button();
            FourDigitButton = new Button();
            ThreeDigitButton = new Button();
            PlusButton = new Button();
            ZeroDigitButton = new Button();
            DotDigitButton = new Button();
            EqualButton = new Button();
            MinusButton = new Button();
            SuspendLayout();
            // 
            // AllClearButton
            // 
            AllClearButton.Location = new Point(39, 129);
            AllClearButton.Name = "AllClearButton";
            AllClearButton.Size = new Size(83, 54);
            AllClearButton.TabIndex = 0;
            AllClearButton.Text = "AC";
            AllClearButton.UseVisualStyleBackColor = true;
            AllClearButton.Click += AllClearButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 57);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(39, 34);
            resultTextBox.Multiline = false;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(423, 61);
            resultTextBox.TabIndex = 3;
            resultTextBox.Text = "";
            // 
            // DivideButton
            // 
            DivideButton.Location = new Point(379, 129);
            DivideButton.Name = "DivideButton";
            DivideButton.Size = new Size(83, 54);
            DivideButton.TabIndex = 4;
            DivideButton.Text = "÷";
            DivideButton.UseVisualStyleBackColor = true;
            DivideButton.Click += DivideButton_Click;
            // 
            // EightDigitButton
            // 
            EightDigitButton.Location = new Point(150, 215);
            EightDigitButton.Name = "EightDigitButton";
            EightDigitButton.Size = new Size(83, 54);
            EightDigitButton.TabIndex = 5;
            EightDigitButton.Text = "8";
            EightDigitButton.UseVisualStyleBackColor = true;
            EightDigitButton.Click += EightDigitButton_Click;
            // 
            // SevenDigitButton
            // 
            SevenDigitButton.Location = new Point(39, 215);
            SevenDigitButton.Name = "SevenDigitButton";
            SevenDigitButton.Size = new Size(83, 54);
            SevenDigitButton.TabIndex = 6;
            SevenDigitButton.Text = "7";
            SevenDigitButton.UseVisualStyleBackColor = true;
            SevenDigitButton.Click += SevenDigitButton_Click;
            // 
            // OneDigitButton
            // 
            OneDigitButton.Location = new Point(39, 389);
            OneDigitButton.Name = "OneDigitButton";
            OneDigitButton.Size = new Size(83, 54);
            OneDigitButton.TabIndex = 7;
            OneDigitButton.Text = "1";
            OneDigitButton.UseVisualStyleBackColor = true;
            OneDigitButton.Click += OneDigitButton_Click;
            // 
            // CrossButton
            // 
            CrossButton.Location = new Point(379, 215);
            CrossButton.Name = "CrossButton";
            CrossButton.Size = new Size(83, 54);
            CrossButton.TabIndex = 8;
            CrossButton.Text = "×";
            CrossButton.UseVisualStyleBackColor = true;
            CrossButton.Click += CrossButton_Click;
            // 
            // NineDigitButton
            // 
            NineDigitButton.Location = new Point(260, 215);
            NineDigitButton.Name = "NineDigitButton";
            NineDigitButton.Size = new Size(83, 54);
            NineDigitButton.TabIndex = 9;
            NineDigitButton.Text = "9";
            NineDigitButton.UseVisualStyleBackColor = true;
            NineDigitButton.Click += NineDigitButton_Click;
            // 
            // TwoDigitButton
            // 
            TwoDigitButton.Location = new Point(150, 389);
            TwoDigitButton.Name = "TwoDigitButton";
            TwoDigitButton.Size = new Size(83, 54);
            TwoDigitButton.TabIndex = 10;
            TwoDigitButton.Text = "2";
            TwoDigitButton.UseVisualStyleBackColor = true;
            TwoDigitButton.Click += TwoDigitButton_Click;
            // 
            // SixDigitButton
            // 
            SixDigitButton.Location = new Point(260, 297);
            SixDigitButton.Name = "SixDigitButton";
            SixDigitButton.Size = new Size(83, 54);
            SixDigitButton.TabIndex = 11;
            SixDigitButton.Text = "6";
            SixDigitButton.UseVisualStyleBackColor = true;
            SixDigitButton.Click += SixDigitButton_Click;
            // 
            // FiveDigitButton
            // 
            FiveDigitButton.Location = new Point(150, 297);
            FiveDigitButton.Name = "FiveDigitButton";
            FiveDigitButton.Size = new Size(83, 54);
            FiveDigitButton.TabIndex = 12;
            FiveDigitButton.Text = "5";
            FiveDigitButton.UseVisualStyleBackColor = true;
            FiveDigitButton.Click += FiveDigitButton_Click;
            // 
            // FourDigitButton
            // 
            FourDigitButton.Location = new Point(39, 297);
            FourDigitButton.Name = "FourDigitButton";
            FourDigitButton.Size = new Size(83, 54);
            FourDigitButton.TabIndex = 13;
            FourDigitButton.Text = "4";
            FourDigitButton.UseVisualStyleBackColor = true;
            FourDigitButton.Click += FourDigitButton_Click;
            // 
            // ThreeDigitButton
            // 
            ThreeDigitButton.Location = new Point(260, 389);
            ThreeDigitButton.Name = "ThreeDigitButton";
            ThreeDigitButton.Size = new Size(83, 54);
            ThreeDigitButton.TabIndex = 14;
            ThreeDigitButton.Text = "3";
            ThreeDigitButton.UseVisualStyleBackColor = true;
            ThreeDigitButton.Click += ThreeDigitButton_Click;
            // 
            // PlusButton
            // 
            PlusButton.Location = new Point(379, 389);
            PlusButton.Name = "PlusButton";
            PlusButton.Size = new Size(83, 54);
            PlusButton.TabIndex = 15;
            PlusButton.Text = "＋";
            PlusButton.UseVisualStyleBackColor = true;
            PlusButton.Click += PlusButton_Click;
            // 
            // ZeroDigitButton
            // 
            ZeroDigitButton.Location = new Point(39, 474);
            ZeroDigitButton.Name = "ZeroDigitButton";
            ZeroDigitButton.Size = new Size(194, 54);
            ZeroDigitButton.TabIndex = 16;
            ZeroDigitButton.Text = "0";
            ZeroDigitButton.UseVisualStyleBackColor = true;
            ZeroDigitButton.Click += ZeroDigitButton_Click;
            // 
            // DotDigitButton
            // 
            DotDigitButton.Location = new Point(260, 474);
            DotDigitButton.Name = "DotDigitButton";
            DotDigitButton.Size = new Size(83, 54);
            DotDigitButton.TabIndex = 17;
            DotDigitButton.Text = ".";
            DotDigitButton.UseVisualStyleBackColor = true;
            DotDigitButton.Click += DotDigitButton_Click;
            // 
            // EqualButton
            // 
            EqualButton.Location = new Point(379, 474);
            EqualButton.Name = "EqualButton";
            EqualButton.Size = new Size(83, 54);
            EqualButton.TabIndex = 18;
            EqualButton.Text = "=";
            EqualButton.UseVisualStyleBackColor = true;
            EqualButton.Click += EqualButton_Click;
            // 
            // MinusButton
            // 
            MinusButton.Location = new Point(379, 297);
            MinusButton.Name = "MinusButton";
            MinusButton.Size = new Size(83, 54);
            MinusButton.TabIndex = 19;
            MinusButton.Text = "ー";
            MinusButton.UseVisualStyleBackColor = true;
            MinusButton.Click += MinusButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 558);
            Controls.Add(MinusButton);
            Controls.Add(EqualButton);
            Controls.Add(DotDigitButton);
            Controls.Add(ZeroDigitButton);
            Controls.Add(PlusButton);
            Controls.Add(ThreeDigitButton);
            Controls.Add(FourDigitButton);
            Controls.Add(FiveDigitButton);
            Controls.Add(SixDigitButton);
            Controls.Add(TwoDigitButton);
            Controls.Add(NineDigitButton);
            Controls.Add(CrossButton);
            Controls.Add(OneDigitButton);
            Controls.Add(SevenDigitButton);
            Controls.Add(EightDigitButton);
            Controls.Add(DivideButton);
            Controls.Add(resultTextBox);
            Controls.Add(label1);
            Controls.Add(AllClearButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AllClearButton;
        private Label label1;
        private RichTextBox resultTextBox;
        private Button DivideButton;
        private Button EightDigitButton;
        private Button SevenDigitButton;
        private Button OneDigitButton;
        private Button CrossButton;
        private Button NineDigitButton;
        private Button TwoDigitButton;
        private Button SixDigitButton;
        private Button FiveDigitButton;
        private Button FourDigitButton;
        private Button ThreeDigitButton;
        private Button PlusButton;
        private Button ZeroDigitButton;
        private Button DotDigitButton;
        private Button EqualButton;
        private Button MinusButton;
    }
}

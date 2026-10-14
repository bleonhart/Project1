namespace Project1
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
            panel1 = new Panel();
            title = new Label();
            inputBox = new TextBox();
            groupBox1 = new GroupBox();
            octalButton = new RadioButton();
            hexButton = new RadioButton();
            binaryButton = new RadioButton();
            decimalButton = new RadioButton();
            outputBox = new TextBox();
            convertButton = new Button();
            groupBox2 = new GroupBox();
            inputOctalButton = new RadioButton();
            inputHexButton = new RadioButton();
            inputBinaryButton = new RadioButton();
            inputDecimalButton = new RadioButton();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(title);
            panel1.Location = new Point(-6, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 119);
            panel1.TabIndex = 0;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Monotxt_IV25", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(18, 40);
            title.Name = "title";
            title.Size = new Size(776, 46);
            title.TabIndex = 0;
            title.Text = "Number Conversion-ator 9000";
            // 
            // inputBox
            // 
            inputBox.Location = new Point(335, 140);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(122, 23);
            inputBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(octalButton);
            groupBox1.Controls.Add(hexButton);
            groupBox1.Controls.Add(binaryButton);
            groupBox1.Controls.Add(decimalButton);
            groupBox1.Location = new Point(218, 275);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(502, 76);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // octalButton
            // 
            octalButton.AutoSize = true;
            octalButton.Location = new Point(273, 22);
            octalButton.Name = "octalButton";
            octalButton.Size = new Size(53, 19);
            octalButton.TabIndex = 3;
            octalButton.TabStop = true;
            octalButton.Text = "Octal";
            octalButton.UseVisualStyleBackColor = true;
            // 
            // hexButton
            // 
            hexButton.AutoSize = true;
            hexButton.Location = new Point(174, 22);
            hexButton.Name = "hexButton";
            hexButton.Size = new Size(93, 19);
            hexButton.TabIndex = 2;
            hexButton.TabStop = true;
            hexButton.Text = "Hexadecimal";
            hexButton.UseVisualStyleBackColor = true;
            // 
            // binaryButton
            // 
            binaryButton.AutoSize = true;
            binaryButton.Location = new Point(106, 22);
            binaryButton.Name = "binaryButton";
            binaryButton.Size = new Size(58, 19);
            binaryButton.TabIndex = 1;
            binaryButton.TabStop = true;
            binaryButton.Text = "Binary";
            binaryButton.UseVisualStyleBackColor = true;
            // 
            // decimalButton
            // 
            decimalButton.AutoSize = true;
            decimalButton.Location = new Point(32, 22);
            decimalButton.Name = "decimalButton";
            decimalButton.Size = new Size(68, 19);
            decimalButton.TabIndex = 0;
            decimalButton.TabStop = true;
            decimalButton.Text = "Decimal";
            decimalButton.UseVisualStyleBackColor = true;
            // 
            // outputBox
            // 
            outputBox.Location = new Point(324, 357);
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(143, 23);
            outputBox.TabIndex = 3;
            // 
            // convertButton
            // 
            convertButton.Location = new Point(355, 398);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(75, 23);
            convertButton.TabIndex = 4;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(inputOctalButton);
            groupBox2.Controls.Add(inputHexButton);
            groupBox2.Controls.Add(inputBinaryButton);
            groupBox2.Controls.Add(inputDecimalButton);
            groupBox2.Location = new Point(218, 184);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(502, 76);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // inputOctalButton
            // 
            inputOctalButton.AutoSize = true;
            inputOctalButton.Location = new Point(273, 22);
            inputOctalButton.Name = "inputOctalButton";
            inputOctalButton.Size = new Size(53, 19);
            inputOctalButton.TabIndex = 3;
            inputOctalButton.TabStop = true;
            inputOctalButton.Text = "Octal";
            inputOctalButton.UseVisualStyleBackColor = true;
            // 
            // inputHexButton
            // 
            inputHexButton.AutoSize = true;
            inputHexButton.Location = new Point(174, 22);
            inputHexButton.Name = "inputHexButton";
            inputHexButton.Size = new Size(93, 19);
            inputHexButton.TabIndex = 2;
            inputHexButton.TabStop = true;
            inputHexButton.Text = "Hexadecimal";
            inputHexButton.UseVisualStyleBackColor = true;
            // 
            // inputBinaryButton
            // 
            inputBinaryButton.AutoSize = true;
            inputBinaryButton.Location = new Point(106, 22);
            inputBinaryButton.Name = "inputBinaryButton";
            inputBinaryButton.Size = new Size(58, 19);
            inputBinaryButton.TabIndex = 1;
            inputBinaryButton.TabStop = true;
            inputBinaryButton.Text = "Binary";
            inputBinaryButton.UseVisualStyleBackColor = true;
            // 
            // inputDecimalButton
            // 
            inputDecimalButton.AutoSize = true;
            inputDecimalButton.Location = new Point(32, 22);
            inputDecimalButton.Name = "inputDecimalButton";
            inputDecimalButton.Size = new Size(68, 19);
            inputDecimalButton.TabIndex = 0;
            inputDecimalButton.TabStop = true;
            inputDecimalButton.Text = "Decimal";
            inputDecimalButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(convertButton);
            Controls.Add(outputBox);
            Controls.Add(groupBox1);
            Controls.Add(inputBox);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label title;
        private TextBox inputBox;
        private GroupBox groupBox1;
        private RadioButton octalButton;
        private RadioButton hexButton;
        private RadioButton binaryButton;
        private RadioButton decimalButton;
        private TextBox outputBox;
        private Button convertButton;
        private GroupBox groupBox2;
        private RadioButton inputOctalButton;
        private RadioButton inputHexButton;
        private RadioButton inputBinaryButton;
        private RadioButton inputDecimalButton;
    }
}

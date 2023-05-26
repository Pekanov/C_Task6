namespace C_Task6
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
            FindMethodsButton = new Button();
            textBox1 = new TextBox();
            ClassesComboBox = new ComboBox();
            GetMethodButton = new Button();
            MethodsComboBox = new ComboBox();
            SuspendLayout();
            // 
            // FindMethodsButton
            // 
            FindMethodsButton.Location = new Point(307, 2);
            FindMethodsButton.Name = "FindMethodsButton";
            FindMethodsButton.Size = new Size(112, 34);
            FindMethodsButton.TabIndex = 0;
            FindMethodsButton.Text = "button1";
            FindMethodsButton.UseVisualStyleBackColor = true;
            FindMethodsButton.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1160, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(556, 363);
            textBox1.TabIndex = 1;
            // 
            // ClassesComboBox
            // 
            ClassesComboBox.FormattingEnabled = true;
            ClassesComboBox.Location = new Point(0, 2);
            ClassesComboBox.Name = "ClassesComboBox";
            ClassesComboBox.Size = new Size(301, 33);
            ClassesComboBox.TabIndex = 2;
            // 
            // GetMethodButton
            // 
            GetMethodButton.Location = new Point(875, 3);
            GetMethodButton.Name = "GetMethodButton";
            GetMethodButton.Size = new Size(112, 34);
            GetMethodButton.TabIndex = 3;
            GetMethodButton.Text = "button1";
            GetMethodButton.UseVisualStyleBackColor = true;
            GetMethodButton.Click += GetMethodButton_Click;
            // 
            // MethodsComboBox
            // 
            MethodsComboBox.FormattingEnabled = true;
            MethodsComboBox.Location = new Point(425, 3);
            MethodsComboBox.Name = "MethodsComboBox";
            MethodsComboBox.Size = new Size(444, 33);
            MethodsComboBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1715, 1026);
            Controls.Add(MethodsComboBox);
            Controls.Add(GetMethodButton);
            Controls.Add(ClassesComboBox);
            Controls.Add(textBox1);
            Controls.Add(FindMethodsButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FindMethodsButton;
        private TextBox textBox1;
        private ComboBox ClassesComboBox;
        private Button GetMethodButton;
        private ComboBox MethodsComboBox;
    }
}
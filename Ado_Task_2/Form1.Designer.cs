namespace Ado_Task_2
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
            searcbtn = new Button();
            txtBox = new TextBox();
            MarkaButton = new RadioButton();
            ModelButton = new RadioButton();
            CarBox = new ListBox();
            SuspendLayout();
            // 
            // searcbtn
            // 
            searcbtn.Location = new Point(238, 40);
            searcbtn.Name = "searcbtn";
            searcbtn.Size = new Size(91, 23);
            searcbtn.TabIndex = 0;
            searcbtn.Text = "Search";
            searcbtn.UseVisualStyleBackColor = true;
            searcbtn.Click += searcbtn_Click;
            // 
            // txtBox
            // 
            txtBox.Location = new Point(12, 40);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(215, 23);
            txtBox.TabIndex = 1;
            // 
            // MarkaButton
            // 
            MarkaButton.AutoSize = true;
            MarkaButton.Location = new Point(12, 79);
            MarkaButton.Name = "MarkaButton";
            MarkaButton.Size = new Size(58, 19);
            MarkaButton.TabIndex = 2;
            MarkaButton.TabStop = true;
            MarkaButton.Text = "Marka";
            MarkaButton.UseVisualStyleBackColor = true;
            // 
            // ModelButton
            // 
            ModelButton.AutoSize = true;
            ModelButton.Location = new Point(133, 79);
            ModelButton.Name = "ModelButton";
            ModelButton.Size = new Size(59, 19);
            ModelButton.TabIndex = 3;
            ModelButton.TabStop = true;
            ModelButton.Text = "Model";
            ModelButton.UseVisualStyleBackColor = true;
            // 
            // CarBox
            // 
            CarBox.FormattingEnabled = true;
            CarBox.ItemHeight = 15;
            CarBox.Location = new Point(12, 104);
            CarBox.Name = "CarBox";
            CarBox.Size = new Size(215, 154);
            CarBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 279);
            Controls.Add(CarBox);
            Controls.Add(ModelButton);
            Controls.Add(MarkaButton);
            Controls.Add(txtBox);
            Controls.Add(searcbtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searcbtn;
        private TextBox txtBox;
        private RadioButton MarkaButton;
        private RadioButton ModelButton;
        private ListBox CarBox;
    }
}

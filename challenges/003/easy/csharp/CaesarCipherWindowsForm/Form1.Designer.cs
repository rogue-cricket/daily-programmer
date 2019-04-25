namespace CaesarCipherWindowsForm
{
    partial class CaesarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.encodedTextBox = new System.Windows.Forms.TextBox();
            this.cipherButton = new System.Windows.Forms.Button();
            this.shiftBox = new System.Windows.Forms.TextBox();
            this.cipherChoiceLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(9, 11);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(55, 13);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Input Text";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(492, 11);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(74, 13);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "Enocded Text";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 27);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(290, 352);
            this.inputTextBox.TabIndex = 3;
            // 
            // encodedTextBox
            // 
            this.encodedTextBox.Location = new System.Drawing.Point(495, 27);
            this.encodedTextBox.Multiline = true;
            this.encodedTextBox.Name = "encodedTextBox";
            this.encodedTextBox.Size = new System.Drawing.Size(290, 352);
            this.encodedTextBox.TabIndex = 4;
            // 
            // cipherButton
            // 
            this.cipherButton.Location = new System.Drawing.Point(351, 176);
            this.cipherButton.Name = "cipherButton";
            this.cipherButton.Size = new System.Drawing.Size(100, 53);
            this.cipherButton.TabIndex = 5;
            this.cipherButton.Text = "Encrypt";
            this.cipherButton.UseVisualStyleBackColor = true;
            this.cipherButton.Click += new System.EventHandler(this.CipherButton_Click);
            // 
            // shiftBox
            // 
            this.shiftBox.Location = new System.Drawing.Point(351, 125);
            this.shiftBox.Name = "shiftBox";
            this.shiftBox.Size = new System.Drawing.Size(100, 20);
            this.shiftBox.TabIndex = 6;
            // 
            // cipherChoiceLabel
            // 
            this.cipherChoiceLabel.AutoSize = true;
            this.cipherChoiceLabel.Location = new System.Drawing.Point(378, 109);
            this.cipherChoiceLabel.Name = "cipherChoiceLabel";
            this.cipherChoiceLabel.Size = new System.Drawing.Size(43, 13);
            this.cipherChoiceLabel.TabIndex = 7;
            this.cipherChoiceLabel.Text = "Shift By";
            // 
            // CaesarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.cipherChoiceLabel);
            this.Controls.Add(this.shiftBox);
            this.Controls.Add(this.cipherButton);
            this.Controls.Add(this.encodedTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CaesarForm";
            this.Text = "Simple Cipher";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox encodedTextBox;
        private System.Windows.Forms.Button cipherButton;
        private System.Windows.Forms.TextBox shiftBox;
        private System.Windows.Forms.Label cipherChoiceLabel;
    }
}


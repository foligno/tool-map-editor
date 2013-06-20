namespace Universal_Map_Editor
{
    partial class MapFileOptionsForm
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
            this.useSeparatorBox = new System.Windows.Forms.CheckBox();
            this.useNewlineBox = new System.Windows.Forms.CheckBox();
            this.separatorCharacterBox = new System.Windows.Forms.TextBox();
            this.newlineCharacterBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.saveMapSettingsButton = new System.Windows.Forms.Button();
            this.cancelMapSettingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // useSeparatorBox
            // 
            this.useSeparatorBox.AutoSize = true;
            this.useSeparatorBox.Location = new System.Drawing.Point(12, 12);
            this.useSeparatorBox.Name = "useSeparatorBox";
            this.useSeparatorBox.Size = new System.Drawing.Size(143, 17);
            this.useSeparatorBox.TabIndex = 0;
            this.useSeparatorBox.Text = "Use Separator Character";
            this.useSeparatorBox.UseVisualStyleBackColor = true;
            // 
            // useNewlineBox
            // 
            this.useNewlineBox.AutoSize = true;
            this.useNewlineBox.Location = new System.Drawing.Point(12, 40);
            this.useNewlineBox.Name = "useNewlineBox";
            this.useNewlineBox.Size = new System.Drawing.Size(135, 17);
            this.useNewlineBox.TabIndex = 1;
            this.useNewlineBox.Text = "Use Newline Character";
            this.useNewlineBox.UseVisualStyleBackColor = true;
            // 
            // separatorCharacterBox
            // 
            this.separatorCharacterBox.Location = new System.Drawing.Point(244, 9);
            this.separatorCharacterBox.Name = "separatorCharacterBox";
            this.separatorCharacterBox.Size = new System.Drawing.Size(46, 20);
            this.separatorCharacterBox.TabIndex = 2;
            // 
            // newlineCharacterBox
            // 
            this.newlineCharacterBox.Location = new System.Drawing.Point(244, 37);
            this.newlineCharacterBox.Name = "newlineCharacterBox";
            this.newlineCharacterBox.Size = new System.Drawing.Size(46, 20);
            this.newlineCharacterBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Separator:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Newline:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            ".jpg",
            ".png",
            ".bmp"});
            this.comboBox1.Location = new System.Drawing.Point(206, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(84, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            ".txt",
            ".map"});
            this.comboBox2.Location = new System.Drawing.Point(206, 97);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(84, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // saveMapSettingsButton
            // 
            this.saveMapSettingsButton.Location = new System.Drawing.Point(17, 286);
            this.saveMapSettingsButton.Name = "saveMapSettingsButton";
            this.saveMapSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.saveMapSettingsButton.TabIndex = 10;
            this.saveMapSettingsButton.Text = "Save";
            this.saveMapSettingsButton.UseVisualStyleBackColor = true;
            // 
            // cancelMapSettingsButton
            // 
            this.cancelMapSettingsButton.Location = new System.Drawing.Point(206, 286);
            this.cancelMapSettingsButton.Name = "cancelMapSettingsButton";
            this.cancelMapSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.cancelMapSettingsButton.TabIndex = 11;
            this.cancelMapSettingsButton.Text = "Cancel";
            this.cancelMapSettingsButton.UseVisualStyleBackColor = true;
            // 
            // MapFileOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 321);
            this.Controls.Add(this.cancelMapSettingsButton);
            this.Controls.Add(this.saveMapSettingsButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newlineCharacterBox);
            this.Controls.Add(this.separatorCharacterBox);
            this.Controls.Add(this.useNewlineBox);
            this.Controls.Add(this.useSeparatorBox);
            this.Name = "MapFileOptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map File Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox useSeparatorBox;
        private System.Windows.Forms.CheckBox useNewlineBox;
        private System.Windows.Forms.TextBox separatorCharacterBox;
        private System.Windows.Forms.TextBox newlineCharacterBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveMapSettingsButton;
        private System.Windows.Forms.Button cancelMapSettingsButton;
    }
}
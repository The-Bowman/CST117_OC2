namespace ProgrammingProject2
{
    partial class steakOrderForm
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
            this.mediumRareRadioButton = new System.Windows.Forms.RadioButton();
            this.slightlyUnderMRRadioButton = new System.Windows.Forms.RadioButton();
            this.mushroomCheckbox = new System.Windows.Forms.CheckBox();
            this.shrimpCheckbox = new System.Windows.Forms.CheckBox();
            this.cutsListBox = new System.Windows.Forms.ListBox();
            this.okButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.promptLabel = new System.Windows.Forms.Label();
            this.temperatureGroupBox = new System.Windows.Forms.GroupBox();
            this.toppersGroupBox = new System.Windows.Forms.GroupBox();
            this.orderLabel = new System.Windows.Forms.Label();
            this.temperatureGroupBox.SuspendLayout();
            this.toppersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mediumRareRadioButton
            // 
            this.mediumRareRadioButton.AutoSize = true;
            this.mediumRareRadioButton.Location = new System.Drawing.Point(6, 28);
            this.mediumRareRadioButton.Name = "mediumRareRadioButton";
            this.mediumRareRadioButton.Size = new System.Drawing.Size(88, 17);
            this.mediumRareRadioButton.TabIndex = 0;
            this.mediumRareRadioButton.TabStop = true;
            this.mediumRareRadioButton.Text = "Medium Rare";
            this.mediumRareRadioButton.UseVisualStyleBackColor = true;
            // 
            // slightlyUnderMRRadioButton
            // 
            this.slightlyUnderMRRadioButton.AutoSize = true;
            this.slightlyUnderMRRadioButton.Location = new System.Drawing.Point(6, 51);
            this.slightlyUnderMRRadioButton.Name = "slightlyUnderMRRadioButton";
            this.slightlyUnderMRRadioButton.Size = new System.Drawing.Size(156, 17);
            this.slightlyUnderMRRadioButton.TabIndex = 1;
            this.slightlyUnderMRRadioButton.TabStop = true;
            this.slightlyUnderMRRadioButton.Text = "Slightly Under Medium Rare";
            this.slightlyUnderMRRadioButton.UseVisualStyleBackColor = true;
            // 
            // mushroomCheckbox
            // 
            this.mushroomCheckbox.AutoSize = true;
            this.mushroomCheckbox.Location = new System.Drawing.Point(6, 19);
            this.mushroomCheckbox.Name = "mushroomCheckbox";
            this.mushroomCheckbox.Size = new System.Drawing.Size(80, 17);
            this.mushroomCheckbox.TabIndex = 2;
            this.mushroomCheckbox.Text = "Mushrooms";
            this.mushroomCheckbox.UseVisualStyleBackColor = true;
            // 
            // shrimpCheckbox
            // 
            this.shrimpCheckbox.AutoSize = true;
            this.shrimpCheckbox.Location = new System.Drawing.Point(6, 42);
            this.shrimpCheckbox.Name = "shrimpCheckbox";
            this.shrimpCheckbox.Size = new System.Drawing.Size(58, 17);
            this.shrimpCheckbox.TabIndex = 3;
            this.shrimpCheckbox.Text = "Shrimp";
            this.shrimpCheckbox.UseVisualStyleBackColor = true;
            // 
            // cutsListBox
            // 
            this.cutsListBox.FormattingEnabled = true;
            this.cutsListBox.Items.AddRange(new object[] {
            "Ribeye",
            "New York Strip",
            "Sirloin",
            "Filet Mignon",
            "Porterhouse"});
            this.cutsListBox.Location = new System.Drawing.Point(59, 68);
            this.cutsListBox.Name = "cutsListBox";
            this.cutsListBox.Size = new System.Drawing.Size(120, 95);
            this.cutsListBox.TabIndex = 4;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(291, 324);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(498, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "&Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(288, 68);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(285, 13);
            this.promptLabel.TabIndex = 8;
            this.promptLabel.Text = "Select a steak, temperature, and the topper of your choice!";
            // 
            // temperatureGroupBox
            // 
            this.temperatureGroupBox.Controls.Add(this.mediumRareRadioButton);
            this.temperatureGroupBox.Controls.Add(this.slightlyUnderMRRadioButton);
            this.temperatureGroupBox.Location = new System.Drawing.Point(59, 169);
            this.temperatureGroupBox.Name = "temperatureGroupBox";
            this.temperatureGroupBox.Size = new System.Drawing.Size(200, 100);
            this.temperatureGroupBox.TabIndex = 9;
            this.temperatureGroupBox.TabStop = false;
            this.temperatureGroupBox.Text = "Temperature";
            // 
            // toppersGroupBox
            // 
            this.toppersGroupBox.Controls.Add(this.mushroomCheckbox);
            this.toppersGroupBox.Controls.Add(this.shrimpCheckbox);
            this.toppersGroupBox.Location = new System.Drawing.Point(59, 275);
            this.toppersGroupBox.Name = "toppersGroupBox";
            this.toppersGroupBox.Size = new System.Drawing.Size(200, 100);
            this.toppersGroupBox.TabIndex = 2;
            this.toppersGroupBox.TabStop = false;
            this.toppersGroupBox.Text = "Toppers";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(291, 135);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(0, 13);
            this.orderLabel.TabIndex = 10;
            // 
            // steakOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.toppersGroupBox);
            this.Controls.Add(this.temperatureGroupBox);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cutsListBox);
            this.Name = "steakOrderForm";
            this.Text = "Steak Order Form";
            this.temperatureGroupBox.ResumeLayout(false);
            this.temperatureGroupBox.PerformLayout();
            this.toppersGroupBox.ResumeLayout(false);
            this.toppersGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton mediumRareRadioButton;
        private System.Windows.Forms.RadioButton slightlyUnderMRRadioButton;
        private System.Windows.Forms.CheckBox mushroomCheckbox;
        private System.Windows.Forms.CheckBox shrimpCheckbox;
        private System.Windows.Forms.ListBox cutsListBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.GroupBox temperatureGroupBox;
        private System.Windows.Forms.GroupBox toppersGroupBox;
        private System.Windows.Forms.Label orderLabel;
    }
}


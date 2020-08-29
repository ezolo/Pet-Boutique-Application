namespace Lab3
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ownerPhoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ownerNameTextBox = new System.Windows.Forms.TextBox();
            this.ownerPhoneLabel = new System.Windows.Forms.Label();
            this.ownerNameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.petTypeTextBox = new System.Windows.Forms.TextBox();
            this.otherLabel = new System.Windows.Forms.Label();
            this.otherButton = new System.Windows.Forms.RadioButton();
            this.dogButton = new System.Windows.Forms.RadioButton();
            this.catButton = new System.Windows.Forms.RadioButton();
            this.typeLabel = new System.Windows.Forms.Label();
            this.dobTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dobLabel = new System.Windows.Forms.Label();
            this.petNameTextBox = new System.Windows.Forms.TextBox();
            this.petNameLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.feeOutputLabel = new System.Windows.Forms.Label();
            this.feeLabel = new System.Windows.Forms.Label();
            this.furTrimmingLabel = new System.Windows.Forms.Label();
            this.shampooLabel = new System.Windows.Forms.Label();
            this.nailClippingLabel = new System.Windows.Forms.Label();
            this.fleaRemovalLabel = new System.Windows.Forms.Label();
            this.furTrimmingCheckBox = new System.Windows.Forms.CheckBox();
            this.shampooCheckBox = new System.Windows.Forms.CheckBox();
            this.nailClippingCheckBox = new System.Windows.Forms.CheckBox();
            this.fleaCheckBox = new System.Windows.Forms.CheckBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ownerPhoneTextBox);
            this.groupBox1.Controls.Add(this.ownerNameTextBox);
            this.groupBox1.Controls.Add(this.ownerPhoneLabel);
            this.groupBox1.Controls.Add(this.ownerNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pet Owner";
            // 
            // ownerPhoneTextBox
            // 
            this.ownerPhoneTextBox.Location = new System.Drawing.Point(184, 108);
            this.ownerPhoneTextBox.Mask = "(999) 000-0000";
            this.ownerPhoneTextBox.Name = "ownerPhoneTextBox";
            this.ownerPhoneTextBox.Size = new System.Drawing.Size(124, 26);
            this.ownerPhoneTextBox.TabIndex = 3;
            // 
            // ownerNameTextBox
            // 
            this.ownerNameTextBox.Location = new System.Drawing.Point(184, 53);
            this.ownerNameTextBox.Name = "ownerNameTextBox";
            this.ownerNameTextBox.Size = new System.Drawing.Size(152, 26);
            this.ownerNameTextBox.TabIndex = 2;
            // 
            // ownerPhoneLabel
            // 
            this.ownerPhoneLabel.AutoSize = true;
            this.ownerPhoneLabel.Location = new System.Drawing.Point(53, 108);
            this.ownerPhoneLabel.Name = "ownerPhoneLabel";
            this.ownerPhoneLabel.Size = new System.Drawing.Size(109, 20);
            this.ownerPhoneLabel.TabIndex = 1;
            this.ownerPhoneLabel.Text = "Owner Phone:";
            // 
            // ownerNameLabel
            // 
            this.ownerNameLabel.AutoSize = true;
            this.ownerNameLabel.Location = new System.Drawing.Point(53, 56);
            this.ownerNameLabel.Name = "ownerNameLabel";
            this.ownerNameLabel.Size = new System.Drawing.Size(105, 20);
            this.ownerNameLabel.TabIndex = 0;
            this.ownerNameLabel.Text = "Owner Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.petTypeTextBox);
            this.groupBox2.Controls.Add(this.otherLabel);
            this.groupBox2.Controls.Add(this.otherButton);
            this.groupBox2.Controls.Add(this.dogButton);
            this.groupBox2.Controls.Add(this.catButton);
            this.groupBox2.Controls.Add(this.typeLabel);
            this.groupBox2.Controls.Add(this.dobTextBox);
            this.groupBox2.Controls.Add(this.dobLabel);
            this.groupBox2.Controls.Add(this.petNameTextBox);
            this.groupBox2.Controls.Add(this.petNameLabel);
            this.groupBox2.Location = new System.Drawing.Point(31, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pet";
            // 
            // petTypeTextBox
            // 
            this.petTypeTextBox.Enabled = false;
            this.petTypeTextBox.Location = new System.Drawing.Point(531, 147);
            this.petTypeTextBox.Name = "petTypeTextBox";
            this.petTypeTextBox.Size = new System.Drawing.Size(100, 26);
            this.petTypeTextBox.TabIndex = 10;
            // 
            // otherLabel
            // 
            this.otherLabel.AutoSize = true;
            this.otherLabel.Enabled = false;
            this.otherLabel.Location = new System.Drawing.Point(421, 151);
            this.otherLabel.Name = "otherLabel";
            this.otherLabel.Size = new System.Drawing.Size(110, 20);
            this.otherLabel.TabIndex = 9;
            this.otherLabel.Text = "T&ype (if other):";
            // 
            // otherButton
            // 
            this.otherButton.AutoSize = true;
            this.otherButton.Location = new System.Drawing.Point(351, 148);
            this.otherButton.Name = "otherButton";
            this.otherButton.Size = new System.Drawing.Size(74, 24);
            this.otherButton.TabIndex = 8;
            this.otherButton.TabStop = true;
            this.otherButton.Text = "Other";
            this.otherButton.UseVisualStyleBackColor = true;
            this.otherButton.CheckedChanged += new System.EventHandler(this.otherButton_CheckedChanged);
            // 
            // dogButton
            // 
            this.dogButton.AutoSize = true;
            this.dogButton.Location = new System.Drawing.Point(266, 148);
            this.dogButton.Name = "dogButton";
            this.dogButton.Size = new System.Drawing.Size(64, 24);
            this.dogButton.TabIndex = 7;
            this.dogButton.TabStop = true;
            this.dogButton.Text = "Dog";
            this.dogButton.UseVisualStyleBackColor = true;
            // 
            // catButton
            // 
            this.catButton.AutoSize = true;
            this.catButton.Location = new System.Drawing.Point(184, 148);
            this.catButton.Name = "catButton";
            this.catButton.Size = new System.Drawing.Size(59, 24);
            this.catButton.TabIndex = 6;
            this.catButton.TabStop = true;
            this.catButton.Text = "Cat";
            this.catButton.UseVisualStyleBackColor = true;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(57, 148);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(75, 20);
            this.typeLabel.TabIndex = 5;
            this.typeLabel.Text = "Pet Type:";
            // 
            // dobTextBox
            // 
            this.dobTextBox.Location = new System.Drawing.Point(184, 95);
            this.dobTextBox.Mask = "00/00/0000";
            this.dobTextBox.Name = "dobTextBox";
            this.dobTextBox.Size = new System.Drawing.Size(96, 26);
            this.dobTextBox.TabIndex = 4;
            this.dobTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(53, 101);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(131, 20);
            this.dobLabel.TabIndex = 3;
            this.dobLabel.Text = "Pet Date of Birth:";
            // 
            // petNameTextBox
            // 
            this.petNameTextBox.Location = new System.Drawing.Point(184, 43);
            this.petNameTextBox.Name = "petNameTextBox";
            this.petNameTextBox.Size = new System.Drawing.Size(152, 26);
            this.petNameTextBox.TabIndex = 1;
            // 
            // petNameLabel
            // 
            this.petNameLabel.AutoSize = true;
            this.petNameLabel.Location = new System.Drawing.Point(53, 50);
            this.petNameLabel.Name = "petNameLabel";
            this.petNameLabel.Size = new System.Drawing.Size(83, 20);
            this.petNameLabel.TabIndex = 0;
            this.petNameLabel.Text = "Pet Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.feeOutputLabel);
            this.groupBox3.Controls.Add(this.feeLabel);
            this.groupBox3.Controls.Add(this.furTrimmingLabel);
            this.groupBox3.Controls.Add(this.shampooLabel);
            this.groupBox3.Controls.Add(this.nailClippingLabel);
            this.groupBox3.Controls.Add(this.fleaRemovalLabel);
            this.groupBox3.Controls.Add(this.furTrimmingCheckBox);
            this.groupBox3.Controls.Add(this.shampooCheckBox);
            this.groupBox3.Controls.Add(this.nailClippingCheckBox);
            this.groupBox3.Controls.Add(this.fleaCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(31, 433);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(640, 189);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Services";
            // 
            // feeOutputLabel
            // 
            this.feeOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.feeOutputLabel.Location = new System.Drawing.Point(321, 136);
            this.feeOutputLabel.Name = "feeOutputLabel";
            this.feeOutputLabel.Size = new System.Drawing.Size(59, 30);
            this.feeOutputLabel.TabIndex = 9;
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Location = new System.Drawing.Point(231, 142);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(80, 20);
            this.feeLabel.TabIndex = 8;
            this.feeLabel.Text = "Total Fee:";
            // 
            // furTrimmingLabel
            // 
            this.furTrimmingLabel.AutoSize = true;
            this.furTrimmingLabel.Location = new System.Drawing.Point(484, 99);
            this.furTrimmingLabel.Name = "furTrimmingLabel";
            this.furTrimmingLabel.Size = new System.Drawing.Size(63, 20);
            this.furTrimmingLabel.TabIndex = 7;
            this.furTrimmingLabel.Text = "VALUE";
            // 
            // shampooLabel
            // 
            this.shampooLabel.AutoSize = true;
            this.shampooLabel.Location = new System.Drawing.Point(484, 49);
            this.shampooLabel.Name = "shampooLabel";
            this.shampooLabel.Size = new System.Drawing.Size(63, 20);
            this.shampooLabel.TabIndex = 6;
            this.shampooLabel.Text = "VALUE";
            // 
            // nailClippingLabel
            // 
            this.nailClippingLabel.AutoSize = true;
            this.nailClippingLabel.Location = new System.Drawing.Point(231, 99);
            this.nailClippingLabel.Name = "nailClippingLabel";
            this.nailClippingLabel.Size = new System.Drawing.Size(63, 20);
            this.nailClippingLabel.TabIndex = 5;
            this.nailClippingLabel.Text = "VALUE";
            // 
            // fleaRemovalLabel
            // 
            this.fleaRemovalLabel.AutoSize = true;
            this.fleaRemovalLabel.Location = new System.Drawing.Point(231, 49);
            this.fleaRemovalLabel.Name = "fleaRemovalLabel";
            this.fleaRemovalLabel.Size = new System.Drawing.Size(63, 20);
            this.fleaRemovalLabel.TabIndex = 4;
            this.fleaRemovalLabel.Text = "VALUE";
            // 
            // furTrimmingCheckBox
            // 
            this.furTrimmingCheckBox.AutoSize = true;
            this.furTrimmingCheckBox.Location = new System.Drawing.Point(351, 95);
            this.furTrimmingCheckBox.Name = "furTrimmingCheckBox";
            this.furTrimmingCheckBox.Size = new System.Drawing.Size(127, 24);
            this.furTrimmingCheckBox.TabIndex = 3;
            this.furTrimmingCheckBox.Text = "Fur Trimming";
            this.furTrimmingCheckBox.UseVisualStyleBackColor = true;
            // 
            // shampooCheckBox
            // 
            this.shampooCheckBox.AutoSize = true;
            this.shampooCheckBox.Location = new System.Drawing.Point(351, 49);
            this.shampooCheckBox.Name = "shampooCheckBox";
            this.shampooCheckBox.Size = new System.Drawing.Size(104, 24);
            this.shampooCheckBox.TabIndex = 2;
            this.shampooCheckBox.Text = "Shampoo";
            this.shampooCheckBox.UseVisualStyleBackColor = true;
            // 
            // nailClippingCheckBox
            // 
            this.nailClippingCheckBox.AutoSize = true;
            this.nailClippingCheckBox.Location = new System.Drawing.Point(72, 95);
            this.nailClippingCheckBox.Name = "nailClippingCheckBox";
            this.nailClippingCheckBox.Size = new System.Drawing.Size(121, 24);
            this.nailClippingCheckBox.TabIndex = 1;
            this.nailClippingCheckBox.Text = "Nail Clipping";
            this.nailClippingCheckBox.UseVisualStyleBackColor = true;
            // 
            // fleaCheckBox
            // 
            this.fleaCheckBox.AutoSize = true;
            this.fleaCheckBox.Location = new System.Drawing.Point(72, 49);
            this.fleaCheckBox.Name = "fleaCheckBox";
            this.fleaCheckBox.Size = new System.Drawing.Size(132, 24);
            this.fleaCheckBox.TabIndex = 0;
            this.fleaCheckBox.Text = "Flea Removal";
            this.fleaCheckBox.UseVisualStyleBackColor = true;
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(68, 646);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(121, 36);
            this.totalButton.TabIndex = 3;
            this.totalButton.Text = "T&otal";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(297, 646);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(121, 36);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(510, 646);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(121, 36);
            this.quitButton.TabIndex = 5;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 694);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Pet Boutique- Service Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox ownerPhoneTextBox;
        private System.Windows.Forms.TextBox ownerNameTextBox;
        private System.Windows.Forms.Label ownerPhoneLabel;
        private System.Windows.Forms.Label ownerNameLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox petTypeTextBox;
        private System.Windows.Forms.Label otherLabel;
        private System.Windows.Forms.RadioButton otherButton;
        private System.Windows.Forms.RadioButton dogButton;
        private System.Windows.Forms.RadioButton catButton;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.MaskedTextBox dobTextBox;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.TextBox petNameTextBox;
        private System.Windows.Forms.Label petNameLabel;
        private System.Windows.Forms.Label furTrimmingLabel;
        private System.Windows.Forms.Label shampooLabel;
        private System.Windows.Forms.Label nailClippingLabel;
        private System.Windows.Forms.Label fleaRemovalLabel;
        private System.Windows.Forms.CheckBox furTrimmingCheckBox;
        private System.Windows.Forms.CheckBox shampooCheckBox;
        private System.Windows.Forms.CheckBox nailClippingCheckBox;
        private System.Windows.Forms.CheckBox fleaCheckBox;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label feeOutputLabel;
        private System.Windows.Forms.Label feeLabel;
    }
}


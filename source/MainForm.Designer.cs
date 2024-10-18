namespace MeowLL
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listenPortInput = new System.Windows.Forms.NumericUpDown();
            this.listenPortLabel = new System.Windows.Forms.Label();
            this.listenIpInput = new System.Windows.Forms.ComboBox();
            this.listenIpLabel = new System.Windows.Forms.Label();
            this.phoneIpInput = new System.Windows.Forms.TextBox();
            this.phoneIpLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sendPortInput = new System.Windows.Forms.NumericUpDown();
            this.sendPortLabel = new System.Windows.Forms.Label();
            this.sendIpInput = new System.Windows.Forms.TextBox();
            this.sendIpLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lookForwardButton = new System.Windows.Forms.Button();
            this.trackHeadCheckbox = new System.Windows.Forms.CheckBox();
            this.trackFacialCheckbox = new System.Windows.Forms.CheckBox();
            this.startButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelEyeSens = new System.Windows.Forms.Label();
            this.inputEyeSens = new System.Windows.Forms.NumericUpDown();
            this.inputHeadSens = new System.Windows.Forms.NumericUpDown();
            this.labelHeadSens = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listenPortInput)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendPortInput)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputEyeSens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHeadSens)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.listenPortInput);
            this.groupBox1.Controls.Add(this.listenPortLabel);
            this.groupBox1.Controls.Add(this.listenIpInput);
            this.groupBox1.Controls.Add(this.listenIpLabel);
            this.groupBox1.Controls.Add(this.phoneIpInput);
            this.groupBox1.Controls.Add(this.phoneIpLabel);
            this.groupBox1.Location = new System.Drawing.Point(5, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection - MeowFace";
            // 
            // listenPortInput
            // 
            this.listenPortInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listenPortInput.Location = new System.Drawing.Point(72, 67);
            this.listenPortInput.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.listenPortInput.Name = "listenPortInput";
            this.listenPortInput.Size = new System.Drawing.Size(108, 20);
            this.listenPortInput.TabIndex = 5;
            this.listenPortInput.Value = new decimal(new int[] {
            49983,
            0,
            0,
            0});
            this.listenPortInput.ValueChanged += new System.EventHandler(this.listenPortInput_ValueChanged);
            // 
            // listenPortLabel
            // 
            this.listenPortLabel.AutoSize = true;
            this.listenPortLabel.Location = new System.Drawing.Point(3, 69);
            this.listenPortLabel.Name = "listenPortLabel";
            this.listenPortLabel.Size = new System.Drawing.Size(60, 13);
            this.listenPortLabel.TabIndex = 4;
            this.listenPortLabel.Text = "Listen Port:";
            // 
            // listenIpInput
            // 
            this.listenIpInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listenIpInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listenIpInput.FormattingEnabled = true;
            this.listenIpInput.Location = new System.Drawing.Point(72, 42);
            this.listenIpInput.Name = "listenIpInput";
            this.listenIpInput.Size = new System.Drawing.Size(269, 21);
            this.listenIpInput.TabIndex = 3;
            this.listenIpInput.SelectedValueChanged += new System.EventHandler(this.listenIpInput_SelectedValueChanged);
            // 
            // listenIpLabel
            // 
            this.listenIpLabel.AutoSize = true;
            this.listenIpLabel.Location = new System.Drawing.Point(12, 45);
            this.listenIpLabel.Name = "listenIpLabel";
            this.listenIpLabel.Size = new System.Drawing.Size(51, 13);
            this.listenIpLabel.TabIndex = 2;
            this.listenIpLabel.Text = "Listen IP:";
            // 
            // phoneIpInput
            // 
            this.phoneIpInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneIpInput.Location = new System.Drawing.Point(72, 16);
            this.phoneIpInput.Name = "phoneIpInput";
            this.phoneIpInput.Size = new System.Drawing.Size(269, 20);
            this.phoneIpInput.TabIndex = 1;
            this.phoneIpInput.Text = "127.0.0.1";
            this.toolTip1.SetToolTip(this.phoneIpInput, "Optional, Will make MeowFace automatically connect to this computer");
            this.phoneIpInput.TextChanged += new System.EventHandler(this.phoneIpInput_TextChanged);
            // 
            // phoneIpLabel
            // 
            this.phoneIpLabel.AutoSize = true;
            this.phoneIpLabel.Location = new System.Drawing.Point(9, 19);
            this.phoneIpLabel.Name = "phoneIpLabel";
            this.phoneIpLabel.Size = new System.Drawing.Size(54, 13);
            this.phoneIpLabel.TabIndex = 0;
            this.phoneIpLabel.Text = "Phone IP:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.sendPortInput);
            this.groupBox2.Controls.Add(this.sendPortLabel);
            this.groupBox2.Controls.Add(this.sendIpInput);
            this.groupBox2.Controls.Add(this.sendIpLabel);
            this.groupBox2.Location = new System.Drawing.Point(5, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 77);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection - Live Link";
            // 
            // sendPortInput
            // 
            this.sendPortInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendPortInput.Location = new System.Drawing.Point(72, 42);
            this.sendPortInput.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.sendPortInput.Name = "sendPortInput";
            this.sendPortInput.Size = new System.Drawing.Size(108, 20);
            this.sendPortInput.TabIndex = 3;
            this.sendPortInput.Value = new decimal(new int[] {
            11111,
            0,
            0,
            0});
            this.sendPortInput.ValueChanged += new System.EventHandler(this.sendPortInput_ValueChanged);
            // 
            // sendPortLabel
            // 
            this.sendPortLabel.AutoSize = true;
            this.sendPortLabel.Location = new System.Drawing.Point(34, 44);
            this.sendPortLabel.Name = "sendPortLabel";
            this.sendPortLabel.Size = new System.Drawing.Size(29, 13);
            this.sendPortLabel.TabIndex = 2;
            this.sendPortLabel.Text = "Port:";
            // 
            // sendIpInput
            // 
            this.sendIpInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendIpInput.Location = new System.Drawing.Point(72, 16);
            this.sendIpInput.Name = "sendIpInput";
            this.sendIpInput.Size = new System.Drawing.Size(269, 20);
            this.sendIpInput.TabIndex = 1;
            this.sendIpInput.Text = "127.0.0.1";
            this.sendIpInput.TextChanged += new System.EventHandler(this.sendIpInput_TextChanged);
            // 
            // sendIpLabel
            // 
            this.sendIpLabel.AutoSize = true;
            this.sendIpLabel.Location = new System.Drawing.Point(15, 19);
            this.sendIpLabel.Name = "sendIpLabel";
            this.sendIpLabel.Size = new System.Drawing.Size(48, 13);
            this.sendIpLabel.TabIndex = 0;
            this.sendIpLabel.Text = "Send IP:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.inputHeadSens);
            this.groupBox3.Controls.Add(this.labelHeadSens);
            this.groupBox3.Controls.Add(this.inputEyeSens);
            this.groupBox3.Controls.Add(this.labelEyeSens);
            this.groupBox3.Controls.Add(this.lookForwardButton);
            this.groupBox3.Controls.Add(this.trackHeadCheckbox);
            this.groupBox3.Controls.Add(this.trackFacialCheckbox);
            this.groupBox3.Location = new System.Drawing.Point(5, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 121);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // lookForwardButton
            // 
            this.lookForwardButton.Enabled = false;
            this.lookForwardButton.Location = new System.Drawing.Point(229, 33);
            this.lookForwardButton.Name = "lookForwardButton";
            this.lookForwardButton.Size = new System.Drawing.Size(103, 23);
            this.lookForwardButton.TabIndex = 9;
            this.lookForwardButton.Text = "Look forward";
            this.toolTip1.SetToolTip(this.lookForwardButton, "Reset the rotations in MeowFace");
            this.lookForwardButton.UseVisualStyleBackColor = true;
            this.lookForwardButton.Click += new System.EventHandler(this.lookForwardButton_Click);
            // 
            // trackHeadCheckbox
            // 
            this.trackHeadCheckbox.AutoSize = true;
            this.trackHeadCheckbox.Checked = true;
            this.trackHeadCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trackHeadCheckbox.Location = new System.Drawing.Point(7, 39);
            this.trackHeadCheckbox.Name = "trackHeadCheckbox";
            this.trackHeadCheckbox.Size = new System.Drawing.Size(126, 17);
            this.trackHeadCheckbox.TabIndex = 1;
            this.trackHeadCheckbox.Text = "Track Head Rotation";
            this.trackHeadCheckbox.UseVisualStyleBackColor = true;
            this.trackHeadCheckbox.CheckedChanged += new System.EventHandler(this.trackHeadCheckbox_CheckedChanged);
            // 
            // trackFacialCheckbox
            // 
            this.trackFacialCheckbox.AutoSize = true;
            this.trackFacialCheckbox.Checked = true;
            this.trackFacialCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trackFacialCheckbox.Location = new System.Drawing.Point(7, 19);
            this.trackFacialCheckbox.Name = "trackFacialCheckbox";
            this.trackFacialCheckbox.Size = new System.Drawing.Size(144, 17);
            this.trackFacialCheckbox.TabIndex = 0;
            this.trackFacialCheckbox.Text = "Track Facial Expressions";
            this.trackFacialCheckbox.UseVisualStyleBackColor = true;
            this.trackFacialCheckbox.CheckedChanged += new System.EventHandler(this.trackFacialCheckbox_CheckedChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(5, 313);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(349, 23);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(264, 342);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(90, 23);
            this.aboutButton.TabIndex = 7;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // labelEyeSens
            // 
            this.labelEyeSens.AutoSize = true;
            this.labelEyeSens.Location = new System.Drawing.Point(12, 70);
            this.labelEyeSens.Name = "labelEyeSens";
            this.labelEyeSens.Size = new System.Drawing.Size(78, 13);
            this.labelEyeSens.TabIndex = 10;
            this.labelEyeSens.Text = "Eye Sensitivity:";
            // 
            // inputEyeSens
            // 
            this.inputEyeSens.DecimalPlaces = 2;
            this.inputEyeSens.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.inputEyeSens.Location = new System.Drawing.Point(96, 68);
            this.inputEyeSens.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            this.inputEyeSens.Name = "inputEyeSens";
            this.inputEyeSens.Size = new System.Drawing.Size(92, 20);
            this.inputEyeSens.TabIndex = 11;
            this.inputEyeSens.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.inputEyeSens.ValueChanged += new System.EventHandler(this.inputEyeSens_ValueChanged);
            // 
            // inputHeadSens
            // 
            this.inputHeadSens.DecimalPlaces = 2;
            this.inputHeadSens.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.inputHeadSens.Location = new System.Drawing.Point(96, 92);
            this.inputHeadSens.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            this.inputHeadSens.Name = "inputHeadSens";
            this.inputHeadSens.Size = new System.Drawing.Size(92, 20);
            this.inputHeadSens.TabIndex = 13;
            this.inputHeadSens.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.inputHeadSens.ValueChanged += new System.EventHandler(this.inputHeadSens_ValueChanged);
            // 
            // labelHeadSens
            // 
            this.labelHeadSens.AutoSize = true;
            this.labelHeadSens.Location = new System.Drawing.Point(4, 94);
            this.labelHeadSens.Name = "labelHeadSens";
            this.labelHeadSens.Size = new System.Drawing.Size(86, 13);
            this.labelHeadSens.TabIndex = 12;
            this.labelHeadSens.Text = "Head Sensitivity:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 368);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeowLL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listenPortInput)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendPortInput)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputEyeSens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHeadSens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label phoneIpLabel;
        private System.Windows.Forms.TextBox phoneIpInput;
        private System.Windows.Forms.ComboBox listenIpInput;
        private System.Windows.Forms.Label listenIpLabel;
        private System.Windows.Forms.NumericUpDown listenPortInput;
        private System.Windows.Forms.Label listenPortLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown sendPortInput;
        private System.Windows.Forms.Label sendPortLabel;
        private System.Windows.Forms.TextBox sendIpInput;
        private System.Windows.Forms.Label sendIpLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox trackHeadCheckbox;
        private System.Windows.Forms.CheckBox trackFacialCheckbox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button lookForwardButton;
        private System.Windows.Forms.Label labelEyeSens;
        private System.Windows.Forms.NumericUpDown inputEyeSens;
        private System.Windows.Forms.NumericUpDown inputHeadSens;
        private System.Windows.Forms.Label labelHeadSens;
    }
}


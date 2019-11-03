namespace BSC_BenchtopStepperMotor
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
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonChannelOneConnect = new System.Windows.Forms.Button();
            this.buttonChannelOneDisconnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonChannelOneDisable = new System.Windows.Forms.Button();
            this.buttonChannelOneEnable = new System.Windows.Forms.Button();
            this.buttonChannelOneMoveToTen = new System.Windows.Forms.Button();
            this.buttonChannelOneMoveToZero = new System.Windows.Forms.Button();
            this.buttonChannelOneHome = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(93, 12);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 2;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(12, 12);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonChannelOneConnect
            // 
            this.buttonChannelOneConnect.Location = new System.Drawing.Point(15, 19);
            this.buttonChannelOneConnect.Name = "buttonChannelOneConnect";
            this.buttonChannelOneConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonChannelOneConnect.TabIndex = 1;
            this.buttonChannelOneConnect.Text = "Connect";
            this.buttonChannelOneConnect.UseVisualStyleBackColor = true;
            this.buttonChannelOneConnect.Click += new System.EventHandler(this.buttonChannelOneConnect_Click);
            // 
            // buttonChannelOneDisconnect
            // 
            this.buttonChannelOneDisconnect.Location = new System.Drawing.Point(96, 19);
            this.buttonChannelOneDisconnect.Name = "buttonChannelOneDisconnect";
            this.buttonChannelOneDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonChannelOneDisconnect.TabIndex = 3;
            this.buttonChannelOneDisconnect.Text = "Disconnect";
            this.buttonChannelOneDisconnect.UseVisualStyleBackColor = true;
            this.buttonChannelOneDisconnect.Click += new System.EventHandler(this.buttonChannelOneDisconnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.buttonChannelOneDisable);
            this.groupBox1.Controls.Add(this.buttonChannelOneEnable);
            this.groupBox1.Controls.Add(this.buttonChannelOneMoveToTen);
            this.groupBox1.Controls.Add(this.buttonChannelOneMoveToZero);
            this.groupBox1.Controls.Add(this.buttonChannelOneHome);
            this.groupBox1.Controls.Add(this.buttonChannelOneConnect);
            this.groupBox1.Controls.Add(this.buttonChannelOneDisconnect);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 165);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Channel 1";
            // 
            // buttonChannelOneDisable
            // 
            this.buttonChannelOneDisable.Location = new System.Drawing.Point(96, 48);
            this.buttonChannelOneDisable.Name = "buttonChannelOneDisable";
            this.buttonChannelOneDisable.Size = new System.Drawing.Size(75, 23);
            this.buttonChannelOneDisable.TabIndex = 8;
            this.buttonChannelOneDisable.Text = "Disable";
            this.buttonChannelOneDisable.UseVisualStyleBackColor = true;
            this.buttonChannelOneDisable.Click += new System.EventHandler(this.buttonChannelOneDisable_Click);
            // 
            // buttonChannelOneEnable
            // 
            this.buttonChannelOneEnable.Location = new System.Drawing.Point(15, 48);
            this.buttonChannelOneEnable.Name = "buttonChannelOneEnable";
            this.buttonChannelOneEnable.Size = new System.Drawing.Size(75, 23);
            this.buttonChannelOneEnable.TabIndex = 7;
            this.buttonChannelOneEnable.Text = "Enable";
            this.buttonChannelOneEnable.UseVisualStyleBackColor = true;
            this.buttonChannelOneEnable.Click += new System.EventHandler(this.buttonChannelOneEnable_Click);
            // 
            // buttonChannelOneMoveToTen
            // 
            this.buttonChannelOneMoveToTen.Location = new System.Drawing.Point(96, 106);
            this.buttonChannelOneMoveToTen.Name = "buttonChannelOneMoveToTen";
            this.buttonChannelOneMoveToTen.Size = new System.Drawing.Size(75, 42);
            this.buttonChannelOneMoveToTen.TabIndex = 6;
            this.buttonChannelOneMoveToTen.Text = "Move to 10mm";
            this.buttonChannelOneMoveToTen.UseVisualStyleBackColor = true;
            this.buttonChannelOneMoveToTen.Click += new System.EventHandler(this.buttonChannelOneMoveToTen_Click);
            // 
            // buttonChannelOneMoveToZero
            // 
            this.buttonChannelOneMoveToZero.Location = new System.Drawing.Point(15, 106);
            this.buttonChannelOneMoveToZero.Name = "buttonChannelOneMoveToZero";
            this.buttonChannelOneMoveToZero.Size = new System.Drawing.Size(75, 42);
            this.buttonChannelOneMoveToZero.TabIndex = 5;
            this.buttonChannelOneMoveToZero.Text = "Move to 0mm";
            this.buttonChannelOneMoveToZero.UseVisualStyleBackColor = true;
            this.buttonChannelOneMoveToZero.Click += new System.EventHandler(this.buttonChannelOneMoveToZero_Click);
            // 
            // buttonChannelOneHome
            // 
            this.buttonChannelOneHome.Location = new System.Drawing.Point(15, 77);
            this.buttonChannelOneHome.Name = "buttonChannelOneHome";
            this.buttonChannelOneHome.Size = new System.Drawing.Size(75, 23);
            this.buttonChannelOneHome.TabIndex = 4;
            this.buttonChannelOneHome.Text = "Home";
            this.buttonChannelOneHome.UseVisualStyleBackColor = true;
            this.buttonChannelOneHome.Click += new System.EventHandler(this.buttonChannelOneHome_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Location = new System.Drawing.Point(209, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 165);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Channel 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Disable";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonChannelTwoDisable_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Enable";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonChannelTwoEnable_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(96, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 42);
            this.button3.TabIndex = 13;
            this.button3.Text = "Move to 10mm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonChannelTwoMoveToTen_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 42);
            this.button4.TabIndex = 12;
            this.button4.Text = "Move to 0mm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonChannelTwoMoveToZero_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 77);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Home";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonChannelTwoHome_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(15, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Connect";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonChannelTwoConnect_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(96, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Disconnect";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonChannelTwoDisconnect_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 224);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Benchtop Stepper Motor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonChannelOneConnect;
        private System.Windows.Forms.Button buttonChannelOneDisconnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonChannelOneHome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonChannelOneMoveToZero;
        private System.Windows.Forms.Button buttonChannelOneMoveToTen;
        private System.Windows.Forms.Button buttonChannelOneEnable;
        private System.Windows.Forms.Button buttonChannelOneDisable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
    }
}


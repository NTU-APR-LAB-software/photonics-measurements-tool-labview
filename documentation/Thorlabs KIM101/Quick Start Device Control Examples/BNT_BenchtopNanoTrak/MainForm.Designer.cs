namespace BNT_BenchtopNanoTrak
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
            this.buttonGetReading = new System.Windows.Forms.Button();
            this.labelGetReadingResponse = new System.Windows.Forms.Label();
            this.buttonGetMode = new System.Windows.Forms.Button();
            this.labelCurrentMode = new System.Windows.Forms.Label();
            this.buttonSetLatchedMode = new System.Windows.Forms.Button();
            this.buttonTrackingMode = new System.Windows.Forms.Button();
            this.buttonSetHome = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
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
            // buttonGetReading
            // 
            this.buttonGetReading.Location = new System.Drawing.Point(12, 51);
            this.buttonGetReading.Name = "buttonGetReading";
            this.buttonGetReading.Size = new System.Drawing.Size(75, 23);
            this.buttonGetReading.TabIndex = 3;
            this.buttonGetReading.Text = "Get Reading";
            this.buttonGetReading.UseVisualStyleBackColor = true;
            this.buttonGetReading.Click += new System.EventHandler(this.buttonGetReading_Click);
            // 
            // labelGetReadingResponse
            // 
            this.labelGetReadingResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGetReadingResponse.Location = new System.Drawing.Point(93, 41);
            this.labelGetReadingResponse.Name = "labelGetReadingResponse";
            this.labelGetReadingResponse.Size = new System.Drawing.Size(156, 42);
            this.labelGetReadingResponse.TabIndex = 10;
            this.labelGetReadingResponse.Text = "-";
            this.labelGetReadingResponse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonGetMode
            // 
            this.buttonGetMode.Location = new System.Drawing.Point(12, 91);
            this.buttonGetMode.Name = "buttonGetMode";
            this.buttonGetMode.Size = new System.Drawing.Size(75, 23);
            this.buttonGetMode.TabIndex = 4;
            this.buttonGetMode.Text = "Get Mode";
            this.buttonGetMode.UseVisualStyleBackColor = true;
            this.buttonGetMode.Click += new System.EventHandler(this.buttonGetMode_Click);
            // 
            // labelCurrentMode
            // 
            this.labelCurrentMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentMode.Location = new System.Drawing.Point(93, 91);
            this.labelCurrentMode.Name = "labelCurrentMode";
            this.labelCurrentMode.Size = new System.Drawing.Size(156, 23);
            this.labelCurrentMode.TabIndex = 12;
            this.labelCurrentMode.Text = "-";
            this.labelCurrentMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSetLatchedMode
            // 
            this.buttonSetLatchedMode.Location = new System.Drawing.Point(12, 120);
            this.buttonSetLatchedMode.Name = "buttonSetLatchedMode";
            this.buttonSetLatchedMode.Size = new System.Drawing.Size(115, 23);
            this.buttonSetLatchedMode.TabIndex = 5;
            this.buttonSetLatchedMode.Text = "Set Mode - Latched";
            this.buttonSetLatchedMode.UseVisualStyleBackColor = true;
            this.buttonSetLatchedMode.Click += new System.EventHandler(this.buttonSetModeToLatched_Click);
            // 
            // buttonTrackingMode
            // 
            this.buttonTrackingMode.Location = new System.Drawing.Point(134, 120);
            this.buttonTrackingMode.Name = "buttonTrackingMode";
            this.buttonTrackingMode.Size = new System.Drawing.Size(115, 23);
            this.buttonTrackingMode.TabIndex = 6;
            this.buttonTrackingMode.Text = "Set Mode - Tracking";
            this.buttonTrackingMode.UseVisualStyleBackColor = true;
            this.buttonTrackingMode.Click += new System.EventHandler(this.buttonSetModeToTracking_Click);
            // 
            // buttonSetHome
            // 
            this.buttonSetHome.Location = new System.Drawing.Point(93, 149);
            this.buttonSetHome.Name = "buttonSetHome";
            this.buttonSetHome.Size = new System.Drawing.Size(75, 23);
            this.buttonSetHome.TabIndex = 8;
            this.buttonSetHome.Text = "Set Home";
            this.buttonSetHome.UseVisualStyleBackColor = true;
            this.buttonSetHome.Click += new System.EventHandler(this.buttonSetHomeCirclePosition);
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(12, 149);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(75, 23);
            this.buttonHome.TabIndex = 7;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 184);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonSetHome);
            this.Controls.Add(this.buttonTrackingMode);
            this.Controls.Add(this.buttonSetLatchedMode);
            this.Controls.Add(this.labelCurrentMode);
            this.Controls.Add(this.buttonGetMode);
            this.Controls.Add(this.labelGetReadingResponse);
            this.Controls.Add(this.buttonGetReading);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Benchtop NanoTrak";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonGetReading;
        private System.Windows.Forms.Label labelGetReadingResponse;
        private System.Windows.Forms.Button buttonGetMode;
        private System.Windows.Forms.Label labelCurrentMode;
        private System.Windows.Forms.Button buttonSetLatchedMode;
        private System.Windows.Forms.Button buttonTrackingMode;
        private System.Windows.Forms.Button buttonSetHome;
        private System.Windows.Forms.Button buttonHome;
    }
}


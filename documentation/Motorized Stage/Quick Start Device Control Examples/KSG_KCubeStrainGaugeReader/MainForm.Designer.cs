namespace KSG_KCubeStrainGaugeReader
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
            this.labelGetReadingResponse = new System.Windows.Forms.Label();
            this.buttonGetReading = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonSetModeToPosition = new System.Windows.Forms.Button();
            this.buttonSetModeToForce = new System.Windows.Forms.Button();
            this.buttonSetModeToVoltage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGetReadingResponse
            // 
            this.labelGetReadingResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGetReadingResponse.Location = new System.Drawing.Point(93, 41);
            this.labelGetReadingResponse.Name = "labelGetReadingResponse";
            this.labelGetReadingResponse.Size = new System.Drawing.Size(156, 42);
            this.labelGetReadingResponse.TabIndex = 15;
            this.labelGetReadingResponse.Text = "-";
            this.labelGetReadingResponse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // buttonSetModeToPosition
            // 
            this.buttonSetModeToPosition.Location = new System.Drawing.Point(93, 91);
            this.buttonSetModeToPosition.Name = "buttonSetModeToPosition";
            this.buttonSetModeToPosition.Size = new System.Drawing.Size(75, 42);
            this.buttonSetModeToPosition.TabIndex = 5;
            this.buttonSetModeToPosition.Text = "Set Mode to Position";
            this.buttonSetModeToPosition.UseVisualStyleBackColor = true;
            this.buttonSetModeToPosition.Click += new System.EventHandler(this.buttonSetModeToPosition_Click);
            // 
            // buttonSetModeToForce
            // 
            this.buttonSetModeToForce.Location = new System.Drawing.Point(174, 91);
            this.buttonSetModeToForce.Name = "buttonSetModeToForce";
            this.buttonSetModeToForce.Size = new System.Drawing.Size(75, 42);
            this.buttonSetModeToForce.TabIndex = 6;
            this.buttonSetModeToForce.Text = "Set Mode to Force";
            this.buttonSetModeToForce.UseVisualStyleBackColor = true;
            this.buttonSetModeToForce.Click += new System.EventHandler(this.buttonSetModeToForce_Click);
            // 
            // buttonSetModeToVoltage
            // 
            this.buttonSetModeToVoltage.Location = new System.Drawing.Point(12, 91);
            this.buttonSetModeToVoltage.Name = "buttonSetModeToVoltage";
            this.buttonSetModeToVoltage.Size = new System.Drawing.Size(75, 42);
            this.buttonSetModeToVoltage.TabIndex = 4;
            this.buttonSetModeToVoltage.Text = "Set Mode to Voltage";
            this.buttonSetModeToVoltage.UseVisualStyleBackColor = true;
            this.buttonSetModeToVoltage.Click += new System.EventHandler(this.buttonSetModeToVoltage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 144);
            this.Controls.Add(this.buttonSetModeToVoltage);
            this.Controls.Add(this.buttonSetModeToForce);
            this.Controls.Add(this.buttonSetModeToPosition);
            this.Controls.Add(this.labelGetReadingResponse);
            this.Controls.Add(this.buttonGetReading);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "K-Cube Strain Gauge Reader";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelGetReadingResponse;
        private System.Windows.Forms.Button buttonGetReading;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonSetModeToPosition;
        private System.Windows.Forms.Button buttonSetModeToForce;
        private System.Windows.Forms.Button buttonSetModeToVoltage;
    }
}


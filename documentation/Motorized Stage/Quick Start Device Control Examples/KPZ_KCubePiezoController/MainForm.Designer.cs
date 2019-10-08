namespace KPZ_KCubePiezoController
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
            this.buttonSetHVOUTToTen = new System.Windows.Forms.Button();
            this.buttonSetHVOUTToZero = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonGetHVOUT = new System.Windows.Forms.Button();
            this.labelGetHVOUTResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSetHVOUTToTen
            // 
            this.buttonSetHVOUTToTen.Location = new System.Drawing.Point(93, 89);
            this.buttonSetHVOUTToTen.Name = "buttonSetHVOUTToTen";
            this.buttonSetHVOUTToTen.Size = new System.Drawing.Size(75, 42);
            this.buttonSetHVOUTToTen.TabIndex = 5;
            this.buttonSetHVOUTToTen.Text = "Set HV OUT to 10V";
            this.buttonSetHVOUTToTen.UseVisualStyleBackColor = true;
            this.buttonSetHVOUTToTen.Click += new System.EventHandler(this.buttonSetHVOUTToTen_Click);
            // 
            // buttonSetHVOUTToZero
            // 
            this.buttonSetHVOUTToZero.Location = new System.Drawing.Point(13, 89);
            this.buttonSetHVOUTToZero.Name = "buttonSetHVOUTToZero";
            this.buttonSetHVOUTToZero.Size = new System.Drawing.Size(75, 42);
            this.buttonSetHVOUTToZero.TabIndex = 4;
            this.buttonSetHVOUTToZero.Text = "Set HV OUT to 0V";
            this.buttonSetHVOUTToZero.UseVisualStyleBackColor = true;
            this.buttonSetHVOUTToZero.Click += new System.EventHandler(this.buttonSetHVOUTToZero_Click);
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
            // buttonGetHVOUT
            // 
            this.buttonGetHVOUT.Location = new System.Drawing.Point(12, 41);
            this.buttonGetHVOUT.Name = "buttonGetHVOUT";
            this.buttonGetHVOUT.Size = new System.Drawing.Size(75, 42);
            this.buttonGetHVOUT.TabIndex = 3;
            this.buttonGetHVOUT.Text = "Get HV OUT";
            this.buttonGetHVOUT.UseVisualStyleBackColor = true;
            this.buttonGetHVOUT.Click += new System.EventHandler(this.buttonGetHVOUT_Click);
            // 
            // labelGetHVOUTResult
            // 
            this.labelGetHVOUTResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGetHVOUTResult.Location = new System.Drawing.Point(93, 41);
            this.labelGetHVOUTResult.Name = "labelGetHVOUTResult";
            this.labelGetHVOUTResult.Size = new System.Drawing.Size(156, 42);
            this.labelGetHVOUTResult.TabIndex = 20;
            this.labelGetHVOUTResult.Text = "-";
            this.labelGetHVOUTResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 141);
            this.Controls.Add(this.labelGetHVOUTResult);
            this.Controls.Add(this.buttonGetHVOUT);
            this.Controls.Add(this.buttonSetHVOUTToTen);
            this.Controls.Add(this.buttonSetHVOUTToZero);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "K-Cube Piezo Controller";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSetHVOUTToTen;
        private System.Windows.Forms.Button buttonSetHVOUTToZero;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonGetHVOUT;
        private System.Windows.Forms.Label labelGetHVOUTResult;
    }
}


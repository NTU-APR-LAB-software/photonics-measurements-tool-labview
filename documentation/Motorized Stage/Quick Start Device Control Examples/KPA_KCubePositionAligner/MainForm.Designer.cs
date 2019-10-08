namespace KPA_KCubePositionAligner
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
            this.buttonGetPosition = new System.Windows.Forms.Button();
            this.labelGetPositionResponse = new System.Windows.Forms.Label();
            this.buttonSetOutputs = new System.Windows.Forms.Button();
            this.buttonSetOutputsToZeros = new System.Windows.Forms.Button();
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
            // buttonGetPosition
            // 
            this.buttonGetPosition.Location = new System.Drawing.Point(12, 51);
            this.buttonGetPosition.Name = "buttonGetPosition";
            this.buttonGetPosition.Size = new System.Drawing.Size(75, 23);
            this.buttonGetPosition.TabIndex = 3;
            this.buttonGetPosition.Text = "Get Position";
            this.buttonGetPosition.UseVisualStyleBackColor = true;
            this.buttonGetPosition.Click += new System.EventHandler(this.buttonGetPosition_Click);
            // 
            // labelGetPositionResponse
            // 
            this.labelGetPositionResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGetPositionResponse.Location = new System.Drawing.Point(93, 41);
            this.labelGetPositionResponse.Name = "labelGetPositionResponse";
            this.labelGetPositionResponse.Size = new System.Drawing.Size(156, 42);
            this.labelGetPositionResponse.TabIndex = 9;
            this.labelGetPositionResponse.Text = "-";
            this.labelGetPositionResponse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSetOutputs
            // 
            this.buttonSetOutputs.Location = new System.Drawing.Point(133, 91);
            this.buttonSetOutputs.Name = "buttonSetOutputs";
            this.buttonSetOutputs.Size = new System.Drawing.Size(116, 23);
            this.buttonSetOutputs.TabIndex = 5;
            this.buttonSetOutputs.Text = "Set X=5, Y=-3.5";
            this.buttonSetOutputs.UseVisualStyleBackColor = true;
            this.buttonSetOutputs.Click += new System.EventHandler(this.buttonSetOutputs_Click);
            // 
            // buttonSetOutputsToZeros
            // 
            this.buttonSetOutputsToZeros.Location = new System.Drawing.Point(12, 91);
            this.buttonSetOutputsToZeros.Name = "buttonSetOutputsToZeros";
            this.buttonSetOutputsToZeros.Size = new System.Drawing.Size(116, 23);
            this.buttonSetOutputsToZeros.TabIndex = 4;
            this.buttonSetOutputsToZeros.Text = "Set X=0, Y=0";
            this.buttonSetOutputsToZeros.UseVisualStyleBackColor = true;
            this.buttonSetOutputsToZeros.Click += new System.EventHandler(this.buttonSetOutputsToZeros_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 126);
            this.Controls.Add(this.buttonSetOutputsToZeros);
            this.Controls.Add(this.buttonSetOutputs);
            this.Controls.Add(this.labelGetPositionResponse);
            this.Controls.Add(this.buttonGetPosition);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "K-Cube Position Aligner";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonGetPosition;
        private System.Windows.Forms.Label labelGetPositionResponse;
        private System.Windows.Forms.Button buttonSetOutputs;
        private System.Windows.Forms.Button buttonSetOutputsToZeros;
    }
}


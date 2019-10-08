namespace LTS_LongTravelStage
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonMoveToFifty = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(174, 12);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(75, 23);
            this.buttonHome.TabIndex = 3;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(12, 41);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(75, 42);
            this.buttonMove.TabIndex = 4;
            this.buttonMove.Text = "Move to 0mm";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMoveToZero_Click);
            // 
            // buttonMoveToFifty
            // 
            this.buttonMoveToFifty.Location = new System.Drawing.Point(93, 41);
            this.buttonMoveToFifty.Name = "buttonMoveToFifty";
            this.buttonMoveToFifty.Size = new System.Drawing.Size(75, 42);
            this.buttonMoveToFifty.TabIndex = 5;
            this.buttonMoveToFifty.Text = "Move to 50mm";
            this.buttonMoveToFifty.UseVisualStyleBackColor = true;
            this.buttonMoveToFifty.Click += new System.EventHandler(this.buttonMoveToFifty_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(174, 41);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 42);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 95);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonMoveToFifty);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Long Travel Stage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonMoveToFifty;
        private System.Windows.Forms.Button buttonStop;
    }
}


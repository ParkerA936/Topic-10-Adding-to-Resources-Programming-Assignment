namespace Topic_10___Adding_to_Resources_Programming_Assignment
{
    partial class Topic10
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
            this.btnCPU = new System.Windows.Forms.Button();
            this.btnRAM = new System.Windows.Forms.Button();
            this.btnSSD = new System.Windows.Forms.Button();
            this.btnPSU = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.imgPicture = new System.Windows.Forms.PictureBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imgPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCPU
            // 
            this.btnCPU.Location = new System.Drawing.Point(29, 18);
            this.btnCPU.Name = "btnCPU";
            this.btnCPU.Size = new System.Drawing.Size(93, 59);
            this.btnCPU.TabIndex = 0;
            this.btnCPU.Text = "CPU";
            this.btnCPU.UseVisualStyleBackColor = true;
            this.btnCPU.Click += new System.EventHandler(this.btnCPU_Click);
            // 
            // btnRAM
            // 
            this.btnRAM.Location = new System.Drawing.Point(29, 83);
            this.btnRAM.Name = "btnRAM";
            this.btnRAM.Size = new System.Drawing.Size(93, 59);
            this.btnRAM.TabIndex = 1;
            this.btnRAM.Text = "RAM";
            this.btnRAM.UseVisualStyleBackColor = true;
            this.btnRAM.Click += new System.EventHandler(this.btnRAM_Click);
            // 
            // btnSSD
            // 
            this.btnSSD.Location = new System.Drawing.Point(29, 148);
            this.btnSSD.Name = "btnSSD";
            this.btnSSD.Size = new System.Drawing.Size(93, 59);
            this.btnSSD.TabIndex = 2;
            this.btnSSD.Text = "SSD";
            this.btnSSD.UseVisualStyleBackColor = true;
            this.btnSSD.Click += new System.EventHandler(this.btnSSD_Click);
            // 
            // btnPSU
            // 
            this.btnPSU.Location = new System.Drawing.Point(29, 213);
            this.btnPSU.Name = "btnPSU";
            this.btnPSU.Size = new System.Drawing.Size(93, 59);
            this.btnPSU.TabIndex = 3;
            this.btnPSU.Text = "PSU";
            this.btnPSU.UseVisualStyleBackColor = true;
            this.btnPSU.Click += new System.EventHandler(this.btnPSU_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(29, 278);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(93, 59);
            this.btnOutput.TabIndex = 4;
            this.btnOutput.Text = "Output Devices";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(29, 343);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(93, 59);
            this.btnInput.TabIndex = 5;
            this.btnInput.Text = "Input Devices";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(195, 247);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(546, 83);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Visible = false;
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Mistral", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.Red;
            this.btnQuit.Location = new System.Drawing.Point(648, 333);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(110, 83);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Visible = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // imgPicture
            // 
            this.imgPicture.Image = global::Topic_10___Adding_to_Resources_Programming_Assignment.Properties.Resources.SSD;
            this.imgPicture.Location = new System.Drawing.Point(216, 29);
            this.imgPicture.Name = "imgPicture";
            this.imgPicture.Size = new System.Drawing.Size(503, 215);
            this.imgPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPicture.TabIndex = 6;
            this.imgPicture.TabStop = false;
            this.imgPicture.Visible = false;
            // 
            // Topic10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.imgPicture);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnPSU);
            this.Controls.Add(this.btnSSD);
            this.Controls.Add(this.btnRAM);
            this.Controls.Add(this.btnCPU);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Topic10";
            this.Text = "Topic 10";
            ((System.ComponentModel.ISupportInitialize)(this.imgPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCPU;
        private System.Windows.Forms.Button btnRAM;
        private System.Windows.Forms.Button btnSSD;
        private System.Windows.Forms.Button btnPSU;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.PictureBox imgPicture;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}


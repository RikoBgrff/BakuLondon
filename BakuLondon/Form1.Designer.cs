namespace BakuLondon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bakuBtn = new System.Windows.Forms.Button();
            this.londonBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bakuBtn
            // 
            this.bakuBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.bakuBtn.Location = new System.Drawing.Point(65, 291);
            this.bakuBtn.Name = "bakuBtn";
            this.bakuBtn.Size = new System.Drawing.Size(93, 47);
            this.bakuBtn.TabIndex = 0;
            this.bakuBtn.Text = "Baku";
            this.bakuBtn.UseVisualStyleBackColor = true;
            this.bakuBtn.Click += new System.EventHandler(this.BakuBtn_Click);
            // 
            // londonBtn
            // 
            this.londonBtn.Location = new System.Drawing.Point(420, 291);
            this.londonBtn.Name = "londonBtn";
            this.londonBtn.Size = new System.Drawing.Size(93, 47);
            this.londonBtn.TabIndex = 1;
            this.londonBtn.Text = "London";
            this.londonBtn.UseVisualStyleBackColor = true;
            this.londonBtn.Click += new System.EventHandler(this.londonBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BakuLondon.Properties.Resources.baku2;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.londonBtn);
            this.Controls.Add(this.bakuBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BakuLondon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bakuBtn;
        private System.Windows.Forms.Button londonBtn;
    }
}


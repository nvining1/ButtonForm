namespace ButtonForm
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
            this.btnVermont = new System.Windows.Forms.Button();
            this.btnNewHampshire = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVermont
            // 
            this.btnVermont.Location = new System.Drawing.Point(109, 137);
            this.btnVermont.Name = "btnVermont";
            this.btnVermont.Size = new System.Drawing.Size(75, 23);
            this.btnVermont.TabIndex = 0;
            this.btnVermont.Text = "Vermont";
            this.btnVermont.UseVisualStyleBackColor = true;
            this.btnVermont.Click += new System.EventHandler(this.btnVermont_Click);
            // 
            // btnNewHampshire
            // 
            this.btnNewHampshire.Location = new System.Drawing.Point(109, 200);
            this.btnNewHampshire.Name = "btnNewHampshire";
            this.btnNewHampshire.Size = new System.Drawing.Size(161, 23);
            this.btnNewHampshire.TabIndex = 1;
            this.btnNewHampshire.Text = "New Hampshire";
            this.btnNewHampshire.UseVisualStyleBackColor = true;
            this.btnNewHampshire.Click += new System.EventHandler(this.btnNewHampshire_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(109, 59);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 22);
            this.txtCity.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.btnNewHampshire);
            this.Controls.Add(this.btnVermont);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVermont;
        private System.Windows.Forms.Button btnNewHampshire;
        private System.Windows.Forms.TextBox txtCity;
    }
}


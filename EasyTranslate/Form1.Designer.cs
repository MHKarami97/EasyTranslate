namespace EasyTranslate
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
            this.button1 = new System.Windows.Forms.Button();
            this.locationString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.AddToTextClick = new System.Windows.Forms.Button();
            this.changesText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get String";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGetStringClick);
            // 
            // locationString
            // 
            this.locationString.Location = new System.Drawing.Point(411, 41);
            this.locationString.Name = "locationString";
            this.locationString.Size = new System.Drawing.Size(661, 44);
            this.locationString.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your text file location";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Coral;
            this.error.Location = new System.Drawing.Point(328, 117);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(434, 37);
            this.error.TabIndex = 3;
            this.error.Text = "Please enter your file location";
            this.error.Visible = false;
            // 
            // AddToTextClick
            // 
            this.AddToTextClick.Location = new System.Drawing.Point(357, 443);
            this.AddToTextClick.Name = "AddToTextClick";
            this.AddToTextClick.Size = new System.Drawing.Size(337, 102);
            this.AddToTextClick.TabIndex = 4;
            this.AddToTextClick.Text = "Add to Text";
            this.AddToTextClick.UseVisualStyleBackColor = true;
            this.AddToTextClick.Click += new System.EventHandler(this.AddToText_Click);
            // 
            // changesText
            // 
            this.changesText.Location = new System.Drawing.Point(411, 352);
            this.changesText.Name = "changesText";
            this.changesText.Size = new System.Drawing.Size(661, 44);
            this.changesText.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chnages text Location";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1131, 619);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changesText);
            this.Controls.Add(this.AddToTextClick);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locationString);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Easy Trranslate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox locationString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button AddToTextClick;
        private System.Windows.Forms.TextBox changesText;
        private System.Windows.Forms.Label label2;
    }
}


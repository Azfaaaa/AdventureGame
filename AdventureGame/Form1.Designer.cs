namespace AdventureGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.Imagebox = new System.Windows.Forms.PictureBox();
            this.textboxLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Imagebox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // Imagebox
            // 
            this.Imagebox.Location = new System.Drawing.Point(12, 12);
            this.Imagebox.Name = "Imagebox";
            this.Imagebox.Size = new System.Drawing.Size(661, 346);
            this.Imagebox.TabIndex = 1;
            this.Imagebox.TabStop = false;
            // 
            // textboxLabel
            // 
            this.textboxLabel.ForeColor = System.Drawing.Color.White;
            this.textboxLabel.Location = new System.Drawing.Point(12, 365);
            this.textboxLabel.Name = "textboxLabel";
            this.textboxLabel.Size = new System.Drawing.Size(450, 145);
            this.textboxLabel.TabIndex = 2;
            this.textboxLabel.Text = ".";
            // 
            // questionLabel
            // 
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(468, 365);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(205, 145);
            this.questionLabel.TabIndex = 3;
            this.questionLabel.Text = ".";
            // 
            // option1Button
            // 
            this.option1Button.Location = new System.Drawing.Point(680, 12);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(172, 173);
            this.option1Button.TabIndex = 4;
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option2Button
            // 
            this.option2Button.Location = new System.Drawing.Point(679, 191);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(172, 173);
            this.option2Button.TabIndex = 5;
            this.option2Button.UseVisualStyleBackColor = true;
            // 
            // option3Button
            // 
            this.option3Button.Location = new System.Drawing.Point(680, 370);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(172, 173);
            this.option3Button.TabIndex = 6;
            this.option3Button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(864, 553);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.textboxLabel);
            this.Controls.Add(this.Imagebox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Imagebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Imagebox;
        private System.Windows.Forms.Label textboxLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option3Button;
    }
}


namespace Adventure_Game
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
            this.option2Label = new System.Windows.Forms.Label();
            this.option1Label = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.option3Label = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.option3Button = new System.Windows.Forms.PictureBox();
            this.option2Button = new System.Windows.Forms.PictureBox();
            this.option1Button = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option3Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option2Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option1Button)).BeginInit();
            this.SuspendLayout();
            // 
            // option2Label
            // 
            this.option2Label.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.ForeColor = System.Drawing.Color.White;
            this.option2Label.Location = new System.Drawing.Point(115, 471);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(574, 28);
            this.option2Label.TabIndex = 14;
            this.option2Label.Text = "option2Label";
            // 
            // option1Label
            // 
            this.option1Label.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.ForeColor = System.Drawing.Color.White;
            this.option1Label.Location = new System.Drawing.Point(115, 415);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(578, 28);
            this.option1Label.TabIndex = 13;
            this.option1Label.Text = "option1Label";
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Courier New", 7F);
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(40, 18);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(654, 137);
            this.outputLabel.TabIndex = 15;
            this.outputLabel.Text = "outputLabel";
            // 
            // option3Label
            // 
            this.option3Label.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Label.ForeColor = System.Drawing.Color.White;
            this.option3Label.Location = new System.Drawing.Point(115, 524);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(578, 28);
            this.option3Label.TabIndex = 16;
            this.option3Label.Text = "option3Label";
            // 
            // imageBox
            // 
            this.imageBox.BackColor = System.Drawing.Color.Transparent;
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageBox.Image = global::Adventure_Game.Properties.Resources.house;
            this.imageBox.Location = new System.Drawing.Point(12, 157);
            this.imageBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(713, 242);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 18;
            this.imageBox.TabStop = false;
            // 
            // option3Button
            // 
            this.option3Button.Image = global::Adventure_Game.Properties.Resources.black_checkmark;
            this.option3Button.Location = new System.Drawing.Point(29, 512);
            this.option3Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(80, 48);
            this.option3Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.option3Button.TabIndex = 17;
            this.option3Button.TabStop = false;
            // 
            // option2Button
            // 
            this.option2Button.Image = global::Adventure_Game.Properties.Resources.black_checkmark;
            this.option2Button.Location = new System.Drawing.Point(29, 460);
            this.option2Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(80, 48);
            this.option2Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.option2Button.TabIndex = 12;
            this.option2Button.TabStop = false;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option1Button
            // 
            this.option1Button.Image = global::Adventure_Game.Properties.Resources.black_checkmark;
            this.option1Button.Location = new System.Drawing.Point(29, 403);
            this.option1Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(80, 53);
            this.option1Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.option1Button.TabIndex = 11;
            this.option1Button.TabStop = false;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(737, 571);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.option3Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.option2Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.option1Button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.PictureBox option2Button;
        private System.Windows.Forms.PictureBox option1Button;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label option3Label;
        private System.Windows.Forms.PictureBox option3Button;
        private System.Windows.Forms.PictureBox imageBox;
    }
}


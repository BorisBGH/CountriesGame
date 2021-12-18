
namespace Countries
{
    partial class WelcomeForm
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
            this.askForName_label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.start_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // askForName_label
            // 
            this.askForName_label.AutoSize = true;
            this.askForName_label.Location = new System.Drawing.Point(56, 34);
            this.askForName_label.Name = "askForName_label";
            this.askForName_label.Size = new System.Drawing.Size(108, 15);
            this.askForName_label.TabIndex = 0;
            this.askForName_label.Text = "Введите Ваше имя";
            this.askForName_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(42, 79);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(152, 23);
            this.name_textBox.TabIndex = 1;
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(70, 143);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(82, 33);
            this.start_button.TabIndex = 2;
            this.start_button.Text = "Начать игру";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 227);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.askForName_label);
            this.Name = "WelcomeForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label askForName_label;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Button start_button;
    }
}

namespace Countries
{
    partial class Finish
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
            this.label_result = new System.Windows.Forms.Label();
            this.label_gameOver = new System.Windows.Forms.Label();
            this.button_playAgain = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(38, 79);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(38, 15);
            this.label_result.TabIndex = 0;
            this.label_result.Text = "label1";
            this.label_result.Click += new System.EventHandler(this.label_result_Click);
            // 
            // label_gameOver
            // 
            this.label_gameOver.AutoSize = true;
            this.label_gameOver.Location = new System.Drawing.Point(38, 40);
            this.label_gameOver.Name = "label_gameOver";
            this.label_gameOver.Size = new System.Drawing.Size(38, 15);
            this.label_gameOver.TabIndex = 1;
            this.label_gameOver.Text = "label1";
            // 
            // button_playAgain
            // 
            this.button_playAgain.Location = new System.Drawing.Point(84, 172);
            this.button_playAgain.Name = "button_playAgain";
            this.button_playAgain.Size = new System.Drawing.Size(78, 40);
            this.button_playAgain.TabIndex = 2;
            this.button_playAgain.Text = "Играть снова";
            this.button_playAgain.UseVisualStyleBackColor = true;
            this.button_playAgain.Click += new System.EventHandler(this.button_playAgain_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(196, 172);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(78, 40);
            this.button_exit.TabIndex = 3;
            this.button_exit.Text = "Выход";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Finish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 254);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_playAgain);
            this.Controls.Add(this.label_gameOver);
            this.Controls.Add(this.label_result);
            this.Name = "Finish";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Finish_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_result;
        public System.Windows.Forms.Label label_gameOver;
        private System.Windows.Forms.Button button_playAgain;
        private System.Windows.Forms.Button button_exit;
    }
}
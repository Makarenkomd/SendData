namespace SendData
{
    partial class FormGame
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
            this.buttonInc = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonInc
            // 
            this.buttonInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInc.Location = new System.Drawing.Point(69, 170);
            this.buttonInc.Name = "buttonInc";
            this.buttonInc.Size = new System.Drawing.Size(198, 59);
            this.buttonInc.TabIndex = 0;
            this.buttonInc.Text = "+1";
            this.buttonInc.UseVisualStyleBackColor = true;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.Location = new System.Drawing.Point(152, 77);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(29, 31);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "0";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 293);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.buttonInc);
            this.Name = "FormGame";
            this.Text = "FormGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInc;
        private System.Windows.Forms.Label labelScore;
    }
}
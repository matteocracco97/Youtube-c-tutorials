namespace AnimatedButton
{
    partial class TestForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lateralAnimatedButton1 = new AnimatedButton.LateralAnimatedButton();
            this.lateralAnimatedButton2 = new AnimatedButton.LateralAnimatedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lateralAnimatedButton1
            // 
            this.lateralAnimatedButton1.AnimationInterval = 1;
            this.lateralAnimatedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lateralAnimatedButton1.BackgroundSpeed = 40;
            this.lateralAnimatedButton1.BackHoverColor = System.Drawing.Color.Purple;
            this.lateralAnimatedButton1.CustomButtonText = "HOVER HERE";
            this.lateralAnimatedButton1.FlatAppearance.BorderSize = 0;
            this.lateralAnimatedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lateralAnimatedButton1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lateralAnimatedButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lateralAnimatedButton1.Location = new System.Drawing.Point(12, 47);
            this.lateralAnimatedButton1.Name = "lateralAnimatedButton1";
            this.lateralAnimatedButton1.Size = new System.Drawing.Size(265, 60);
            this.lateralAnimatedButton1.SmoothCorrectionFactor = 1.5D;
            this.lateralAnimatedButton1.TabIndex = 0;
            this.lateralAnimatedButton1.TextHoverColor = System.Drawing.Color.White;
            this.lateralAnimatedButton1.UseSmoothSpeedIncrement = true;
            this.lateralAnimatedButton1.UseVisualStyleBackColor = false;
            // 
            // lateralAnimatedButton2
            // 
            this.lateralAnimatedButton2.AnimationInterval = 1;
            this.lateralAnimatedButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lateralAnimatedButton2.BackgroundSpeed = 20;
            this.lateralAnimatedButton2.BackHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.lateralAnimatedButton2.CustomButtonText = "HOVER HERE 2";
            this.lateralAnimatedButton2.FlatAppearance.BorderSize = 0;
            this.lateralAnimatedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lateralAnimatedButton2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lateralAnimatedButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.lateralAnimatedButton2.Location = new System.Drawing.Point(283, 47);
            this.lateralAnimatedButton2.Name = "lateralAnimatedButton2";
            this.lateralAnimatedButton2.Size = new System.Drawing.Size(265, 60);
            this.lateralAnimatedButton2.SmoothCorrectionFactor = 1.5D;
            this.lateralAnimatedButton2.TabIndex = 1;
            this.lateralAnimatedButton2.TextHoverColor = System.Drawing.Color.White;
            this.lateralAnimatedButton2.UseSmoothSpeedIncrement = false;
            this.lateralAnimatedButton2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Smooth animation on";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(278, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Smooth animation off";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lateralAnimatedButton2);
            this.Controls.Add(this.lateralAnimatedButton1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LateralAnimatedButton lateralAnimatedButton1;
        private LateralAnimatedButton lateralAnimatedButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


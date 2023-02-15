namespace Prime_numbers
{
    partial class PrimeNumbers
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButonNprime = new System.Windows.Forms.Button();
            this.Numarul = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButonNprime
            // 
            this.ButonNprime.BackColor = System.Drawing.Color.Cyan;
            this.ButonNprime.Location = new System.Drawing.Point(259, 264);
            this.ButonNprime.Name = "ButonNprime";
            this.ButonNprime.Size = new System.Drawing.Size(236, 114);
            this.ButonNprime.TabIndex = 0;
            this.ButonNprime.Text = "Ok";
            this.ButonNprime.UseVisualStyleBackColor = false;
            this.ButonNprime.Click += new System.EventHandler(this.ButonNprime_Click);
            // 
            // Numarul
            // 
            this.Numarul.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Numarul.Location = new System.Drawing.Point(237, 92);
            this.Numarul.Name = "Numarul";
            this.Numarul.Size = new System.Drawing.Size(289, 70);
            this.Numarul.TabIndex = 1;
            this.Numarul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PrimeNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Numarul);
            this.Controls.Add(this.ButonNprime);
            this.Name = "PrimeNumbers";
            this.Text = "PrimeNumbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButonNprime;
        private TextBox Numarul;
    }
}
namespace TaskApp
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
            this.btnPlayFizzBuzz = new System.Windows.Forms.Button();
            this.txtFizzBuzz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "FizzBuzz";
            // 
            // btnPlayFizzBuzz
            // 
            this.btnPlayFizzBuzz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayFizzBuzz.Location = new System.Drawing.Point(164, 39);
            this.btnPlayFizzBuzz.Name = "btnPlayFizzBuzz";
            this.btnPlayFizzBuzz.Size = new System.Drawing.Size(75, 30);
            this.btnPlayFizzBuzz.TabIndex = 2;
            this.btnPlayFizzBuzz.Text = "Play";
            this.btnPlayFizzBuzz.UseVisualStyleBackColor = true;
            this.btnPlayFizzBuzz.Click += new System.EventHandler(this.btnPlayFizzBuzz_Click);
            // 
            // txtFizzBuzz
            // 
            this.txtFizzBuzz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFizzBuzz.Location = new System.Drawing.Point(18, 108);
            this.txtFizzBuzz.Multiline = true;
            this.txtFizzBuzz.Name = "txtFizzBuzz";
            this.txtFizzBuzz.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFizzBuzz.Size = new System.Drawing.Size(221, 303);
            this.txtFizzBuzz.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFizzBuzz);
            this.Controls.Add(this.btnPlayFizzBuzz);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlayFizzBuzz;
        private System.Windows.Forms.TextBox txtFizzBuzz;
    }
}


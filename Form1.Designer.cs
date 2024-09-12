namespace _001Inleiding
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
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.btnZonderKlassen = new System.Windows.Forms.Button();
            this.btnLeeg = new System.Windows.Forms.Button();
            this.btnKruisje = new System.Windows.Forms.Button();
            this.btnKruisjeClass = new System.Windows.Forms.Button();
            this.btnMeerdereKruisjes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.Location = new System.Drawing.Point(13, 13);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(466, 425);
            this.pnlCanvas.TabIndex = 0;
            // 
            // btnZonderKlassen
            // 
            this.btnZonderKlassen.Location = new System.Drawing.Point(533, 42);
            this.btnZonderKlassen.Name = "btnZonderKlassen";
            this.btnZonderKlassen.Size = new System.Drawing.Size(129, 23);
            this.btnZonderKlassen.TabIndex = 1;
            this.btnZonderKlassen.Text = "Zonder klassen";
            this.btnZonderKlassen.UseVisualStyleBackColor = true;
            this.btnZonderKlassen.Click += new System.EventHandler(this.btnZonderKlassen_Click);
            // 
            // btnLeeg
            // 
            this.btnLeeg.BackColor = System.Drawing.Color.Red;
            this.btnLeeg.Location = new System.Drawing.Point(709, 42);
            this.btnLeeg.Name = "btnLeeg";
            this.btnLeeg.Size = new System.Drawing.Size(23, 23);
            this.btnLeeg.TabIndex = 1;
            this.btnLeeg.UseVisualStyleBackColor = false;
            // 
            // btnKruisje
            // 
            this.btnKruisje.Location = new System.Drawing.Point(542, 93);
            this.btnKruisje.Name = "btnKruisje";
            this.btnKruisje.Size = new System.Drawing.Size(120, 23);
            this.btnKruisje.TabIndex = 2;
            this.btnKruisje.Text = "Kruisje";
            this.btnKruisje.UseVisualStyleBackColor = true;
            this.btnKruisje.Click += new System.EventHandler(this.btnKruisje_Click);
            // 
            // btnKruisjeClass
            // 
            this.btnKruisjeClass.Location = new System.Drawing.Point(542, 113);
            this.btnKruisjeClass.Name = "btnKruisjeClass";
            this.btnKruisjeClass.Size = new System.Drawing.Size(120, 23);
            this.btnKruisjeClass.TabIndex = 2;
            this.btnKruisjeClass.Text = "Kruisje met klasse";
            this.btnKruisjeClass.UseVisualStyleBackColor = true;
            this.btnKruisjeClass.Click += new System.EventHandler(this.btnKruisjeClass_Click);
            // 
            // btnMeerdereKruisjes
            // 
            this.btnMeerdereKruisjes.Location = new System.Drawing.Point(542, 132);
            this.btnMeerdereKruisjes.Name = "btnMeerdereKruisjes";
            this.btnMeerdereKruisjes.Size = new System.Drawing.Size(120, 23);
            this.btnMeerdereKruisjes.TabIndex = 2;
            this.btnMeerdereKruisjes.Text = "Meerdere kruisjes";
            this.btnMeerdereKruisjes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMeerdereKruisjes);
            this.Controls.Add(this.btnKruisjeClass);
            this.Controls.Add(this.btnKruisje);
            this.Controls.Add(this.btnLeeg);
            this.Controls.Add(this.btnZonderKlassen);
            this.Controls.Add(this.pnlCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.Button btnZonderKlassen;
        private System.Windows.Forms.Button btnLeeg;
        private System.Windows.Forms.Button btnKruisje;
        private System.Windows.Forms.Button btnKruisjeClass;
        private System.Windows.Forms.Button btnMeerdereKruisjes;
    }
}


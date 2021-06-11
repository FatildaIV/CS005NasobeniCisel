namespace CS005NasobeniCisel
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.cislo1Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cislo1TextBox = new System.Windows.Forms.TextBox();
            this.cislo2TextBox = new System.Windows.Forms.TextBox();
            this.cislo3TextBox = new System.Windows.Forms.TextBox();
            this.vynasobitButton = new System.Windows.Forms.Button();
            this.vysledekLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cislo1Label
            // 
            this.cislo1Label.AutoSize = true;
            this.cislo1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cislo1Label.Location = new System.Drawing.Point(56, 18);
            this.cislo1Label.Name = "cislo1Label";
            this.cislo1Label.Size = new System.Drawing.Size(79, 26);
            this.cislo1Label.TabIndex = 0;
            this.cislo1Label.Text = "Číslo 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(55, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Číslo 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(55, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Číslo 3";
            // 
            // cislo1TextBox
            // 
            this.cislo1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.cislo1TextBox.Location = new System.Drawing.Point(155, 14);
            this.cislo1TextBox.Name = "cislo1TextBox";
            this.cislo1TextBox.Size = new System.Drawing.Size(86, 32);
            this.cislo1TextBox.TabIndex = 3;
            // 
            // cislo2TextBox
            // 
            this.cislo2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.cislo2TextBox.Location = new System.Drawing.Point(155, 53);
            this.cislo2TextBox.Name = "cislo2TextBox";
            this.cislo2TextBox.Size = new System.Drawing.Size(86, 32);
            this.cislo2TextBox.TabIndex = 4;
            // 
            // cislo3TextBox
            // 
            this.cislo3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.cislo3TextBox.Location = new System.Drawing.Point(155, 91);
            this.cislo3TextBox.Name = "cislo3TextBox";
            this.cislo3TextBox.Size = new System.Drawing.Size(86, 32);
            this.cislo3TextBox.TabIndex = 5;
            // 
            // vynasobitButton
            // 
            this.vynasobitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vynasobitButton.Location = new System.Drawing.Point(62, 149);
            this.vynasobitButton.Name = "vynasobitButton";
            this.vynasobitButton.Size = new System.Drawing.Size(178, 34);
            this.vynasobitButton.TabIndex = 6;
            this.vynasobitButton.Text = "Vynásobit";
            this.vynasobitButton.UseVisualStyleBackColor = true;
            this.vynasobitButton.Click += new System.EventHandler(this.vynasobitButton_Click);
            // 
            // vysledekLabel
            // 
            this.vysledekLabel.AutoSize = true;
            this.vysledekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vysledekLabel.Location = new System.Drawing.Point(118, 195);
            this.vysledekLabel.Name = "vysledekLabel";
            this.vysledekLabel.Size = new System.Drawing.Size(42, 25);
            this.vysledekLabel.TabIndex = 7;
            this.vysledekLabel.Text = "= ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 231);
            this.Controls.Add(this.vysledekLabel);
            this.Controls.Add(this.vynasobitButton);
            this.Controls.Add(this.cislo3TextBox);
            this.Controls.Add(this.cislo2TextBox);
            this.Controls.Add(this.cislo1TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cislo1Label);
            this.Name = "Form1";
            this.Text = "Násobení 3 čísel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cislo1Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cislo1TextBox;
        private System.Windows.Forms.TextBox cislo2TextBox;
        private System.Windows.Forms.TextBox cislo3TextBox;
        private System.Windows.Forms.Label vysledekLabel;
        private System.Windows.Forms.Button vynasobitButton;
    }
}


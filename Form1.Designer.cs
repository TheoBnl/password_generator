namespace password_generator
{
    partial class Form
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_ihm = new System.Windows.Forms.Panel();
            this.button_copyPassword = new System.Windows.Forms.Button();
            this.textBox_PasswordDisplay = new System.Windows.Forms.TextBox();
            this.label_nbChar = new System.Windows.Forms.Label();
            this.trackBar_nbChar = new System.Windows.Forms.TrackBar();
            this.panel_ihm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_nbChar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ihm
            // 
            this.panel_ihm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel_ihm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ihm.Controls.Add(this.button_copyPassword);
            this.panel_ihm.Controls.Add(this.textBox_PasswordDisplay);
            this.panel_ihm.Controls.Add(this.label_nbChar);
            this.panel_ihm.Controls.Add(this.trackBar_nbChar);
            this.panel_ihm.Location = new System.Drawing.Point(13, 15);
            this.panel_ihm.Name = "panel_ihm";
            this.panel_ihm.Size = new System.Drawing.Size(916, 286);
            this.panel_ihm.TabIndex = 0;
            // 
            // button_copyPassword
            // 
            this.button_copyPassword.BackgroundImage = global::password_generator.Properties.Resources.copy;
            this.button_copyPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_copyPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_copyPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button_copyPassword.Location = new System.Drawing.Point(784, 119);
            this.button_copyPassword.Name = "button_copyPassword";
            this.button_copyPassword.Size = new System.Drawing.Size(46, 46);
            this.button_copyPassword.TabIndex = 1;
            this.button_copyPassword.UseVisualStyleBackColor = true;
            this.button_copyPassword.Click += new System.EventHandler(this.button_copyPassword_Click);
            // 
            // textBox_PasswordDisplay
            // 
            this.textBox_PasswordDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBox_PasswordDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PasswordDisplay.ForeColor = System.Drawing.Color.White;
            this.textBox_PasswordDisplay.Location = new System.Drawing.Point(136, 119);
            this.textBox_PasswordDisplay.Multiline = true;
            this.textBox_PasswordDisplay.Name = "textBox_PasswordDisplay";
            this.textBox_PasswordDisplay.ReadOnly = true;
            this.textBox_PasswordDisplay.Size = new System.Drawing.Size(642, 46);
            this.textBox_PasswordDisplay.TabIndex = 2;
            this.textBox_PasswordDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_nbChar
            // 
            this.label_nbChar.AutoSize = true;
            this.label_nbChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_nbChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nbChar.ForeColor = System.Drawing.Color.White;
            this.label_nbChar.Location = new System.Drawing.Point(90, 123);
            this.label_nbChar.Name = "label_nbChar";
            this.label_nbChar.Size = new System.Drawing.Size(108, 31);
            this.label_nbChar.TabIndex = 1;
            this.label_nbChar.Text = "NbChar";
            // 
            // trackBar_nbChar
            // 
            this.trackBar_nbChar.CausesValidation = false;
            this.trackBar_nbChar.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar_nbChar.LargeChange = 1;
            this.trackBar_nbChar.Location = new System.Drawing.Point(136, 203);
            this.trackBar_nbChar.Name = "trackBar_nbChar";
            this.trackBar_nbChar.Size = new System.Drawing.Size(642, 45);
            this.trackBar_nbChar.TabIndex = 1;
            this.trackBar_nbChar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_nbChar.Scroll += new System.EventHandler(this.trackBar_nbChar_Scroll);
            this.trackBar_nbChar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar_nbChar_MouseDown);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(942, 317);
            this.Controls.Add(this.panel_ihm);
            this.Name = "Form";
            this.Text = "password generator";
            this.Load += new System.EventHandler(this.Form_Load);
            this.panel_ihm.ResumeLayout(false);
            this.panel_ihm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_nbChar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ihm;
        private System.Windows.Forms.TrackBar trackBar_nbChar;
        private System.Windows.Forms.Label label_nbChar;
        private System.Windows.Forms.TextBox textBox_PasswordDisplay;
        private System.Windows.Forms.Button button_copyPassword;
    }
}


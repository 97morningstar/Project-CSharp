namespace Proyecto
{
    partial class DeseaUsarSuPoder
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
            this.imgJugador = new System.Windows.Forms.PictureBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblDeseaUsar = new System.Windows.Forms.Label();
            this.lblPoder = new System.Windows.Forms.Label();
            this.btnSi = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgJugador)).BeginInit();
            this.SuspendLayout();
            // 
            // imgJugador
            // 
            this.imgJugador.BackColor = System.Drawing.Color.Transparent;
            this.imgJugador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgJugador.Location = new System.Drawing.Point(12, 12);
            this.imgJugador.Name = "imgJugador";
            this.imgJugador.Size = new System.Drawing.Size(150, 228);
            this.imgJugador.TabIndex = 0;
            this.imgJugador.TabStop = false;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.BackColor = System.Drawing.Color.Transparent;
            this.lblTurno.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTurno.Location = new System.Drawing.Point(168, 21);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(214, 44);
            this.lblTurno.TabIndex = 1;
            this.lblTurno.Text = "Es el turno de: ";
            // 
            // lblDeseaUsar
            // 
            this.lblDeseaUsar.AutoSize = true;
            this.lblDeseaUsar.BackColor = System.Drawing.Color.Transparent;
            this.lblDeseaUsar.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeseaUsar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDeseaUsar.Location = new System.Drawing.Point(168, 151);
            this.lblDeseaUsar.Name = "lblDeseaUsar";
            this.lblDeseaUsar.Size = new System.Drawing.Size(305, 44);
            this.lblDeseaUsar.TabIndex = 2;
            this.lblDeseaUsar.Text = "¿Desea usar su poder?";
            // 
            // lblPoder
            // 
            this.lblPoder.AutoSize = true;
            this.lblPoder.BackColor = System.Drawing.Color.Transparent;
            this.lblPoder.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPoder.Location = new System.Drawing.Point(168, 55);
            this.lblPoder.Name = "lblPoder";
            this.lblPoder.Size = new System.Drawing.Size(108, 44);
            this.lblPoder.TabIndex = 3;
            this.lblPoder.Text = "Poder: ";
            // 
            // btnSi
            // 
            this.btnSi.BackColor = System.Drawing.Color.Lime;
            this.btnSi.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSi.Font = new System.Drawing.Font("Viner Hand ITC", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSi.ForeColor = System.Drawing.Color.Yellow;
            this.btnSi.Location = new System.Drawing.Point(187, 186);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(88, 53);
            this.btnSi.TabIndex = 4;
            this.btnSi.Text = "Sí";
            this.btnSi.UseVisualStyleBackColor = false;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Red;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Font = new System.Drawing.Font("Viner Hand ITC", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.Magenta;
            this.btnNo.Location = new System.Drawing.Point(285, 186);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(223, 53);
            this.btnNo.TabIndex = 5;
            this.btnNo.Text = "Todavía no";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeseaUsarSuPoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.Colors_II_by_panic_tape;
            this.ClientSize = new System.Drawing.Size(697, 261);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnSi);
            this.Controls.Add(this.lblPoder);
            this.Controls.Add(this.lblDeseaUsar);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.imgJugador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeseaUsarSuPoder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeseaUsarSuPoder";
            this.Load += new System.EventHandler(this.DeseaUsarSuPoder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgJugador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       public System.Windows.Forms.PictureBox imgJugador;
       public System.Windows.Forms.Label lblTurno;
        public System.Windows.Forms.Label lblDeseaUsar;
        public System.Windows.Forms.Label lblPoder;
        public System.Windows.Forms.Button btnSi;
       public System.Windows.Forms.Button btnNo;
    }
}
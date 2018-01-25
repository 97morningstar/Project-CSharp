namespace Proyecto
{
    partial class IntroducirJugadores
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdiobtnJugadores4 = new System.Windows.Forms.RadioButton();
            this.rdiobtnJugadores3 = new System.Windows.Forms.RadioButton();
            this.rdiobtnJugador2 = new System.Windows.Forms.RadioButton();
            this.lblJug1 = new System.Windows.Forms.Label();
            this.imgTRex = new System.Windows.Forms.PictureBox();
            this.imgSirena = new System.Windows.Forms.PictureBox();
            this.imgCaballo = new System.Windows.Forms.PictureBox();
            this.imgFenix = new System.Windows.Forms.PictureBox();
            this.lblPersonaje = new System.Windows.Forms.Label();
            this.lblJug2 = new System.Windows.Forms.Label();
            this.lblJug3 = new System.Windows.Forms.Label();
            this.lblJug4 = new System.Windows.Forms.Label();
            this.txtJug1 = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtJug2 = new System.Windows.Forms.TextBox();
            this.txtJug3 = new System.Windows.Forms.TextBox();
            this.txtJug4 = new System.Windows.Forms.TextBox();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTRex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSirena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCaballo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFenix)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdiobtnJugadores4);
            this.groupBox1.Controls.Add(this.rdiobtnJugadores3);
            this.groupBox1.Controls.Add(this.rdiobtnJugador2);
            this.groupBox1.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elija la cantidad de jugadores";
            // 
            // rdiobtnJugadores4
            // 
            this.rdiobtnJugadores4.AutoSize = true;
            this.rdiobtnJugadores4.Location = new System.Drawing.Point(23, 171);
            this.rdiobtnJugadores4.Name = "rdiobtnJugadores4";
            this.rdiobtnJugadores4.Size = new System.Drawing.Size(160, 43);
            this.rdiobtnJugadores4.TabIndex = 2;
            this.rdiobtnJugadores4.Text = "4 Jugadores";
            this.rdiobtnJugadores4.UseVisualStyleBackColor = true;
            this.rdiobtnJugadores4.CheckedChanged += new System.EventHandler(this.rdiobtnJugadores4_CheckedChanged);
            // 
            // rdiobtnJugadores3
            // 
            this.rdiobtnJugadores3.AutoSize = true;
            this.rdiobtnJugadores3.Location = new System.Drawing.Point(23, 122);
            this.rdiobtnJugadores3.Name = "rdiobtnJugadores3";
            this.rdiobtnJugadores3.Size = new System.Drawing.Size(157, 43);
            this.rdiobtnJugadores3.TabIndex = 1;
            this.rdiobtnJugadores3.Text = "3 Jugadores";
            this.rdiobtnJugadores3.UseVisualStyleBackColor = true;
            this.rdiobtnJugadores3.CheckedChanged += new System.EventHandler(this.rdiobtnJugadores3_CheckedChanged);
            // 
            // rdiobtnJugador2
            // 
            this.rdiobtnJugador2.AutoSize = true;
            this.rdiobtnJugador2.Location = new System.Drawing.Point(23, 73);
            this.rdiobtnJugador2.Name = "rdiobtnJugador2";
            this.rdiobtnJugador2.Size = new System.Drawing.Size(161, 43);
            this.rdiobtnJugador2.TabIndex = 0;
            this.rdiobtnJugador2.Text = "2 Jugadores";
            this.rdiobtnJugador2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdiobtnJugador2.UseVisualStyleBackColor = true;
            this.rdiobtnJugador2.CheckedChanged += new System.EventHandler(this.rdiobtnJugador2_CheckedChanged);
            // 
            // lblJug1
            // 
            this.lblJug1.AutoSize = true;
            this.lblJug1.BackColor = System.Drawing.Color.Transparent;
            this.lblJug1.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJug1.ForeColor = System.Drawing.Color.Yellow;
            this.lblJug1.Location = new System.Drawing.Point(86, 451);
            this.lblJug1.Name = "lblJug1";
            this.lblJug1.Size = new System.Drawing.Size(155, 52);
            this.lblJug1.TabIndex = 1;
            this.lblJug1.Text = "Jugador 1";
            this.lblJug1.Visible = false;
            // 
            // imgTRex
            // 
            this.imgTRex.BackgroundImage = global::Proyecto.Properties.Resources.TrexNuevo;
            this.imgTRex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgTRex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgTRex.Location = new System.Drawing.Point(968, 87);
            this.imgTRex.Name = "imgTRex";
            this.imgTRex.Size = new System.Drawing.Size(126, 142);
            this.imgTRex.TabIndex = 8;
            this.imgTRex.TabStop = false;
            this.imgTRex.Visible = false;
            this.imgTRex.Click += new System.EventHandler(this.imgTRex_Click);
            // 
            // imgSirena
            // 
            this.imgSirena.BackgroundImage = global::Proyecto.Properties.Resources.Sirena;
            this.imgSirena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgSirena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgSirena.Location = new System.Drawing.Point(802, 87);
            this.imgSirena.Name = "imgSirena";
            this.imgSirena.Size = new System.Drawing.Size(114, 142);
            this.imgSirena.TabIndex = 7;
            this.imgSirena.TabStop = false;
            this.imgSirena.Visible = false;
            this.imgSirena.Click += new System.EventHandler(this.imgSirena_Click);
            // 
            // imgCaballo
            // 
            this.imgCaballo.BackgroundImage = global::Proyecto.Properties.Resources.nuevo;
            this.imgCaballo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCaballo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCaballo.Location = new System.Drawing.Point(630, 87);
            this.imgCaballo.Name = "imgCaballo";
            this.imgCaballo.Size = new System.Drawing.Size(124, 144);
            this.imgCaballo.TabIndex = 6;
            this.imgCaballo.TabStop = false;
            this.imgCaballo.Visible = false;
            this.imgCaballo.Click += new System.EventHandler(this.imgCaballo_Click);
            // 
            // imgFenix
            // 
            this.imgFenix.BackgroundImage = global::Proyecto.Properties.Resources.Fenix;
            this.imgFenix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgFenix.Location = new System.Drawing.Point(470, 86);
            this.imgFenix.Name = "imgFenix";
            this.imgFenix.Size = new System.Drawing.Size(110, 145);
            this.imgFenix.TabIndex = 5;
            this.imgFenix.TabStop = false;
            this.imgFenix.Visible = false;
            this.imgFenix.Click += new System.EventHandler(this.imgFenix_Click);
            // 
            // lblPersonaje
            // 
            this.lblPersonaje.AutoSize = true;
            this.lblPersonaje.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonaje.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonaje.ForeColor = System.Drawing.Color.Yellow;
            this.lblPersonaje.Location = new System.Drawing.Point(477, 31);
            this.lblPersonaje.Name = "lblPersonaje";
            this.lblPersonaje.Size = new System.Drawing.Size(700, 52);
            this.lblPersonaje.TabIndex = 9;
            this.lblPersonaje.Text = "Elija su personaje haciendo click en la imagen";
            this.lblPersonaje.Visible = false;
            // 
            // lblJug2
            // 
            this.lblJug2.AutoSize = true;
            this.lblJug2.BackColor = System.Drawing.Color.Transparent;
            this.lblJug2.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJug2.ForeColor = System.Drawing.Color.Yellow;
            this.lblJug2.Location = new System.Drawing.Point(354, 451);
            this.lblJug2.Name = "lblJug2";
            this.lblJug2.Size = new System.Drawing.Size(167, 52);
            this.lblJug2.TabIndex = 10;
            this.lblJug2.Text = "Jugador 2";
            this.lblJug2.Visible = false;
            // 
            // lblJug3
            // 
            this.lblJug3.AutoSize = true;
            this.lblJug3.BackColor = System.Drawing.Color.Transparent;
            this.lblJug3.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJug3.ForeColor = System.Drawing.Color.Yellow;
            this.lblJug3.Location = new System.Drawing.Point(630, 451);
            this.lblJug3.Name = "lblJug3";
            this.lblJug3.Size = new System.Drawing.Size(161, 52);
            this.lblJug3.TabIndex = 11;
            this.lblJug3.Text = "Jugador 3";
            this.lblJug3.Visible = false;
            // 
            // lblJug4
            // 
            this.lblJug4.AutoSize = true;
            this.lblJug4.BackColor = System.Drawing.Color.Transparent;
            this.lblJug4.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJug4.ForeColor = System.Drawing.Color.Yellow;
            this.lblJug4.Location = new System.Drawing.Point(918, 451);
            this.lblJug4.Name = "lblJug4";
            this.lblJug4.Size = new System.Drawing.Size(165, 52);
            this.lblJug4.TabIndex = 12;
            this.lblJug4.Text = "Jugador 4";
            this.lblJug4.Visible = false;
            // 
            // txtJug1
            // 
            this.txtJug1.Font = new System.Drawing.Font("Vivaldi", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJug1.Location = new System.Drawing.Point(75, 506);
            this.txtJug1.Name = "txtJug1";
            this.txtJug1.Size = new System.Drawing.Size(166, 37);
            this.txtJug1.TabIndex = 0;
            this.txtJug1.Visible = false;
            this.txtJug1.TextChanged += new System.EventHandler(this.txtJug1_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Viner Hand ITC", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Yellow;
            this.lblNombre.Location = new System.Drawing.Point(339, 399);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(381, 52);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Escriba su nombre debajo";
            this.lblNombre.Visible = false;
            // 
            // txtJug2
            // 
            this.txtJug2.Font = new System.Drawing.Font("Vivaldi", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJug2.Location = new System.Drawing.Point(348, 506);
            this.txtJug2.Name = "txtJug2";
            this.txtJug2.Size = new System.Drawing.Size(173, 37);
            this.txtJug2.TabIndex = 1;
            this.txtJug2.Visible = false;
            this.txtJug2.TextChanged += new System.EventHandler(this.txtJug2_TextChanged);
            // 
            // txtJug3
            // 
            this.txtJug3.Font = new System.Drawing.Font("Vivaldi", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJug3.Location = new System.Drawing.Point(630, 506);
            this.txtJug3.Name = "txtJug3";
            this.txtJug3.Size = new System.Drawing.Size(161, 37);
            this.txtJug3.TabIndex = 2;
            this.txtJug3.Visible = false;
            this.txtJug3.TextChanged += new System.EventHandler(this.txtJug3_TextChanged);
            // 
            // txtJug4
            // 
            this.txtJug4.Font = new System.Drawing.Font("Vivaldi", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJug4.Location = new System.Drawing.Point(916, 506);
            this.txtJug4.Name = "txtJug4";
            this.txtJug4.Size = new System.Drawing.Size(167, 37);
            this.txtJug4.TabIndex = 3;
            this.txtJug4.Visible = false;
            this.txtJug4.TextChanged += new System.EventHandler(this.txtJug4_TextChanged);
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.BackgroundImage = global::Proyecto.Properties.Resources.dialog;
            this.btnEmpezar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpezar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpezar.Font = new System.Drawing.Font("Viner Hand ITC", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpezar.ForeColor = System.Drawing.Color.Maroon;
            this.btnEmpezar.Location = new System.Drawing.Point(546, 174);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(308, 66);
            this.btnEmpezar.TabIndex = 18;
            this.btnEmpezar.Text = "Siguiente";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(677, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 52);
            this.label1.TabIndex = 19;
            this.label1.Text = "que";
            this.label1.Visible = false;
            // 
            // IntroducirJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.BG_001;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1174, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.txtJug4);
            this.Controls.Add(this.txtJug3);
            this.Controls.Add(this.txtJug2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtJug1);
            this.Controls.Add(this.lblJug4);
            this.Controls.Add(this.lblJug3);
            this.Controls.Add(this.lblJug2);
            this.Controls.Add(this.lblPersonaje);
            this.Controls.Add(this.imgTRex);
            this.Controls.Add(this.imgSirena);
            this.Controls.Add(this.imgCaballo);
            this.Controls.Add(this.imgFenix);
            this.Controls.Add(this.lblJug1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IntroducirJugadores";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IntroducirJugadores";
            this.Load += new System.EventHandler(this.IntroducirJugadores_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IntroducirJugadores_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTRex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSirena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCaballo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFenix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdiobtnJugadores4;
        private System.Windows.Forms.RadioButton rdiobtnJugadores3;
        private System.Windows.Forms.RadioButton rdiobtnJugador2;
        private System.Windows.Forms.Label lblJug1;
        private System.Windows.Forms.PictureBox imgTRex;
        private System.Windows.Forms.PictureBox imgSirena;
        private System.Windows.Forms.PictureBox imgCaballo;
        private System.Windows.Forms.PictureBox imgFenix;
        private System.Windows.Forms.Label lblPersonaje;
        private System.Windows.Forms.Label lblJug2;
        private System.Windows.Forms.Label lblJug3;
        private System.Windows.Forms.Label lblJug4;
        private System.Windows.Forms.TextBox txtJug1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtJug2;
        private System.Windows.Forms.TextBox txtJug3;
        private System.Windows.Forms.TextBox txtJug4;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Label label1;
    }
}
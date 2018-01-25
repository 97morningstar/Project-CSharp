namespace Proyecto
{
    partial class Game
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.colorTable1 = new JPUtil.ColorTable();
            this.imgDado = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.btnVolver = new System.Windows.Forms.Button();
            this.timerDado = new System.Windows.Forms.Timer(this.components);
            this.btnTirar = new System.Windows.Forms.Button();
            this.timerDetenerElDado = new System.Windows.Forms.Timer(this.components);
            this.lblInformacion = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.Checkeador = new System.Windows.Forms.Timer(this.components);
            this.btnUsarPoder = new System.Windows.Forms.Button();
            this.timerdeLamuerte = new System.Windows.Forms.Timer(this.components);
            this.otroCheckeador = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imgDado)).BeginInit();
            this.SuspendLayout();
            // 
            // colorTable1
            // 
            this.colorTable1.AutoScroll = true;
            this.colorTable1.AutoScrollMinSize = new System.Drawing.Size(496, 496);
            this.colorTable1.BackColor = System.Drawing.Color.Transparent;
            this.colorTable1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.colorTable1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorTable1.CellSize = 45;
            this.colorTable1.CirclesLineColor = System.Drawing.Color.Gainsboro;
            this.colorTable1.ForeColor = System.Drawing.Color.Transparent;
            this.colorTable1.GridLineColor = System.Drawing.Color.Gray;
            this.colorTable1.ImageCellSize = 24;
            this.colorTable1.Location = new System.Drawing.Point(14, 2);
            this.colorTable1.Name = "colorTable1";
            this.colorTable1.Size = new System.Drawing.Size(929, 503);
            this.colorTable1.TabIndex = 0;
            this.colorTable1.TableHeight = 11;
            this.colorTable1.TableWidth = 11;
            this.colorTable1.TabStop = true;
            this.colorTable1.Paint += new System.Windows.Forms.PaintEventHandler(this.colorTable1_Paint);
            // 
            // imgDado
            // 
            this.imgDado.BackColor = System.Drawing.Color.Transparent;
            this.imgDado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgDado.Location = new System.Drawing.Point(1017, 159);
            this.imgDado.Name = "imgDado";
            this.imgDado.Size = new System.Drawing.Size(176, 165);
            this.imgDado.TabIndex = 11;
            this.imgDado.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver.BackgroundImage")));
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.Maroon;
            this.btnVolver.Location = new System.Drawing.Point(949, 26);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(381, 49);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Cerrar el Juego";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // timerDado
            // 
            this.timerDado.Tick += new System.EventHandler(this.timerDado_Tick);
            // 
            // btnTirar
            // 
            this.btnTirar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTirar.BackgroundImage")));
            this.btnTirar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTirar.Font = new System.Drawing.Font("Viner Hand ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTirar.ForeColor = System.Drawing.Color.Maroon;
            this.btnTirar.Location = new System.Drawing.Point(996, 433);
            this.btnTirar.Name = "btnTirar";
            this.btnTirar.Size = new System.Drawing.Size(263, 55);
            this.btnTirar.TabIndex = 12;
            this.btnTirar.Text = "Tirar";
            this.btnTirar.UseVisualStyleBackColor = true;
            this.btnTirar.Click += new System.EventHandler(this.btnTirar_Click);
            // 
            // timerDetenerElDado
            // 
            this.timerDetenerElDado.Interval = 1000;
            this.timerDetenerElDado.Tick += new System.EventHandler(this.timerDetenerElDado_Tick);
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblInformacion.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.ForeColor = System.Drawing.Color.Gold;
            this.lblInformacion.Location = new System.Drawing.Point(988, 102);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(0, 39);
            this.lblInformacion.TabIndex = 0;
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // Checkeador
            // 
            this.Checkeador.Interval = 50;
            // 
            // btnUsarPoder
            // 
            this.btnUsarPoder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUsarPoder.BackgroundImage")));
            this.btnUsarPoder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsarPoder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsarPoder.Enabled = false;
            this.btnUsarPoder.Font = new System.Drawing.Font("Viner Hand ITC", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsarPoder.ForeColor = System.Drawing.Color.Maroon;
            this.btnUsarPoder.Location = new System.Drawing.Point(949, 81);
            this.btnUsarPoder.Name = "btnUsarPoder";
            this.btnUsarPoder.Size = new System.Drawing.Size(286, 49);
            this.btnUsarPoder.TabIndex = 14;
            this.btnUsarPoder.Text = "Usar Poder";
            this.btnUsarPoder.UseVisualStyleBackColor = true;
            this.btnUsarPoder.Click += new System.EventHandler(this.btnUsarPoder_Click);
            // 
            // timerdeLamuerte
            // 
            this.timerdeLamuerte.Interval = 3000;
            this.timerdeLamuerte.Tick += new System.EventHandler(this.timerdeLamuerte_Tick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Proyecto.Properties.Resources.Music_by_Flarup;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1189, 555);
            this.Controls.Add(this.btnUsarPoder);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.btnTirar);
            this.Controls.Add(this.imgDado);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.colorTable1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgDado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private JPUtil.ColorTable colorTable1;

        #endregion

        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Timer timerDado;
        private System.Windows.Forms.PictureBox imgDado;
        private System.Windows.Forms.Button btnTirar;
        private System.Windows.Forms.Timer timerDetenerElDado;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer Checkeador;
        private System.Windows.Forms.Button btnUsarPoder;
        private System.Windows.Forms.Timer timerdeLamuerte;
        private System.Windows.Forms.Timer otroCheckeador;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

    }
}


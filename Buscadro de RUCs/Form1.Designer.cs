namespace Buscadro_de_RUCs
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.LblRuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PbME = new System.Windows.Forms.PictureBox();
            this.PbGC = new System.Windows.Forms.PictureBox();
            this.PbFA = new System.Windows.Forms.PictureBox();
            this.PbEX = new System.Windows.Forms.PictureBox();
            this.PbCE = new System.Windows.Forms.PictureBox();
            this.PbAR = new System.Windows.Forms.PictureBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.ErrPRuc = new System.Windows.Forms.ErrorProvider(this.components);
            this.LblDato = new System.Windows.Forms.Label();
            this.ErrRuc = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PbME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbFA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbEX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrPRuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrRuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUSCADOR DE RUCS - ECUADOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblRuc
            // 
            this.LblRuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblRuc.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRuc.Location = new System.Drawing.Point(170, 80);
            this.LblRuc.MaxLength = 13;
            this.LblRuc.Name = "LblRuc";
            this.LblRuc.Size = new System.Drawing.Size(226, 28);
            this.LblRuc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultados para el RUC:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Agentes de \r\nRetención";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contribuyentes\r\nEspeciales";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Exportadores de\r\nBienes";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "Empresas\r\nFantasmas";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "Grandes \r\nContribuyentes";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(580, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "MicroEmpresas";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PbME
            // 
            this.PbME.BackColor = System.Drawing.Color.Transparent;
            this.PbME.Location = new System.Drawing.Point(587, 261);
            this.PbME.Name = "PbME";
            this.PbME.Size = new System.Drawing.Size(61, 46);
            this.PbME.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbME.TabIndex = 15;
            this.PbME.TabStop = false;
            // 
            // PbGC
            // 
            this.PbGC.BackColor = System.Drawing.Color.Transparent;
            this.PbGC.Location = new System.Drawing.Point(476, 261);
            this.PbGC.Name = "PbGC";
            this.PbGC.Size = new System.Drawing.Size(61, 46);
            this.PbGC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbGC.TabIndex = 14;
            this.PbGC.TabStop = false;
            // 
            // PbFA
            // 
            this.PbFA.BackColor = System.Drawing.Color.Transparent;
            this.PbFA.Location = new System.Drawing.Point(370, 261);
            this.PbFA.Name = "PbFA";
            this.PbFA.Size = new System.Drawing.Size(61, 46);
            this.PbFA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbFA.TabIndex = 13;
            this.PbFA.TabStop = false;
            // 
            // PbEX
            // 
            this.PbEX.BackColor = System.Drawing.Color.Transparent;
            this.PbEX.Location = new System.Drawing.Point(259, 261);
            this.PbEX.Name = "PbEX";
            this.PbEX.Size = new System.Drawing.Size(61, 46);
            this.PbEX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbEX.TabIndex = 12;
            this.PbEX.TabStop = false;
            // 
            // PbCE
            // 
            this.PbCE.BackColor = System.Drawing.Color.Transparent;
            this.PbCE.Location = new System.Drawing.Point(148, 261);
            this.PbCE.Name = "PbCE";
            this.PbCE.Size = new System.Drawing.Size(61, 46);
            this.PbCE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCE.TabIndex = 11;
            this.PbCE.TabStop = false;
            // 
            // PbAR
            // 
            this.PbAR.BackColor = System.Drawing.Color.Transparent;
            this.PbAR.Location = new System.Drawing.Point(38, 261);
            this.PbAR.Name = "PbAR";
            this.PbAR.Size = new System.Drawing.Size(61, 46);
            this.PbAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbAR.TabIndex = 10;
            this.PbAR.TabStop = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackgroundImage = global::Buscadro_de_RUCs.Properties.Resources.depositphotos_38005243_stock_illustration_vector_magnifying_glass;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscar.Location = new System.Drawing.Point(438, 75);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(42, 40);
            this.BtnBuscar.TabIndex = 1;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // ErrPRuc
            // 
            this.ErrPRuc.BlinkRate = 300;
            this.ErrPRuc.ContainerControl = this;
            this.ErrPRuc.RightToLeft = true;
            // 
            // LblDato
            // 
            this.LblDato.AutoSize = true;
            this.LblDato.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDato.Location = new System.Drawing.Point(386, 160);
            this.LblDato.Name = "LblDato";
            this.LblDato.Size = new System.Drawing.Size(57, 21);
            this.LblDato.TabIndex = 16;
            this.LblDato.Text = "label9";
            this.LblDato.Visible = false;
            // 
            // ErrRuc
            // 
            this.ErrRuc.ContainerControl = this;
            this.ErrRuc.RightToLeft = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(670, 343);
            this.Controls.Add(this.LblDato);
            this.Controls.Add(this.PbME);
            this.Controls.Add(this.PbGC);
            this.Controls.Add(this.PbFA);
            this.Controls.Add(this.PbEX);
            this.Controls.Add(this.PbCE);
            this.Controls.Add(this.PbAR);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblRuc);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador de RUCs V 1.1";
            ((System.ComponentModel.ISupportInitialize)(this.PbME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbFA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbEX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrPRuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrRuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox LblRuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox PbAR;
        private System.Windows.Forms.PictureBox PbCE;
        private System.Windows.Forms.PictureBox PbEX;
        private System.Windows.Forms.PictureBox PbFA;
        private System.Windows.Forms.PictureBox PbGC;
        private System.Windows.Forms.PictureBox PbME;
        private System.Windows.Forms.ErrorProvider ErrPRuc;
        private System.Windows.Forms.Label LblDato;
        private System.Windows.Forms.ErrorProvider ErrRuc;
    }
}


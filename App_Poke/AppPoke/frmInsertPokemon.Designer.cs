namespace AppPoke
{
    partial class FrmInsertPokemon
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labNum = new System.Windows.Forms.Label();
            this.labNom = new System.Windows.Forms.Label();
            this.labDesc = new System.Windows.Forms.Label();
            this.labUrl = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.labTipo = new System.Windows.Forms.Label();
            this.labDebi = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboDebi = new System.Windows.Forms.ComboBox();
            this.pictureImg = new System.Windows.Forms.PictureBox();
            this.btnImg = new System.Windows.Forms.Button();
            this.lblErrNum = new System.Windows.Forms.Label();
            this.lblErrNom = new System.Windows.Forms.Label();
            this.lblErrDes = new System.Windows.Forms.Label();
            this.lblErrImg = new System.Windows.Forms.Label();
            this.lblErrTipo = new System.Windows.Forms.Label();
            this.lblErrDeb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(173, 358);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(159, 50);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(414, 358);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 50);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labNum
            // 
            this.labNum.AutoSize = true;
            this.labNum.Location = new System.Drawing.Point(34, 43);
            this.labNum.Name = "labNum";
            this.labNum.Size = new System.Drawing.Size(47, 13);
            this.labNum.TabIndex = 2;
            this.labNum.Text = "Numero:";
            // 
            // labNom
            // 
            this.labNom.AutoSize = true;
            this.labNom.Location = new System.Drawing.Point(34, 83);
            this.labNom.Name = "labNom";
            this.labNom.Size = new System.Drawing.Size(47, 13);
            this.labNom.TabIndex = 3;
            this.labNom.Text = "Nombre:";
            // 
            // labDesc
            // 
            this.labDesc.AutoSize = true;
            this.labDesc.Location = new System.Drawing.Point(34, 122);
            this.labDesc.Name = "labDesc";
            this.labDesc.Size = new System.Drawing.Size(66, 13);
            this.labDesc.TabIndex = 4;
            this.labDesc.Text = "Descripcion:";
            // 
            // labUrl
            // 
            this.labUrl.AutoSize = true;
            this.labUrl.Location = new System.Drawing.Point(34, 196);
            this.labUrl.Name = "labUrl";
            this.labUrl.Size = new System.Drawing.Size(40, 13);
            this.labUrl.TabIndex = 5;
            this.labUrl.Text = "UrlImg:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(106, 36);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(159, 20);
            this.txtNum.TabIndex = 0;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(106, 76);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(159, 20);
            this.txtNom.TabIndex = 1;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(106, 115);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(159, 52);
            this.txtDesc.TabIndex = 2;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(106, 189);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(159, 20);
            this.txtUrl.TabIndex = 3;
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            // 
            // labTipo
            // 
            this.labTipo.AutoSize = true;
            this.labTipo.Location = new System.Drawing.Point(34, 251);
            this.labTipo.Name = "labTipo";
            this.labTipo.Size = new System.Drawing.Size(31, 13);
            this.labTipo.TabIndex = 10;
            this.labTipo.Text = "Tipo:";
            // 
            // labDebi
            // 
            this.labDebi.AutoSize = true;
            this.labDebi.Location = new System.Drawing.Point(34, 292);
            this.labDebi.Name = "labDebi";
            this.labDebi.Size = new System.Drawing.Size(54, 13);
            this.labDebi.TabIndex = 11;
            this.labDebi.Text = "Debilidad:";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(106, 243);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(159, 21);
            this.cboTipo.TabIndex = 4;
            // 
            // cboDebi
            // 
            this.cboDebi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDebi.FormattingEnabled = true;
            this.cboDebi.Location = new System.Drawing.Point(106, 284);
            this.cboDebi.Name = "cboDebi";
            this.cboDebi.Size = new System.Drawing.Size(159, 21);
            this.cboDebi.TabIndex = 5;
            // 
            // pictureImg
            // 
            this.pictureImg.Location = new System.Drawing.Point(414, 36);
            this.pictureImg.Name = "pictureImg";
            this.pictureImg.Size = new System.Drawing.Size(255, 228);
            this.pictureImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureImg.TabIndex = 14;
            this.pictureImg.TabStop = false;
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(282, 187);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(75, 23);
            this.btnImg.TabIndex = 15;
            this.btnImg.Text = "Abrir Img";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // lblErrNum
            // 
            this.lblErrNum.AutoSize = true;
            this.lblErrNum.ForeColor = System.Drawing.Color.Red;
            this.lblErrNum.Location = new System.Drawing.Point(271, 36);
            this.lblErrNum.Name = "lblErrNum";
            this.lblErrNum.Size = new System.Drawing.Size(0, 13);
            this.lblErrNum.TabIndex = 16;
            // 
            // lblErrNom
            // 
            this.lblErrNom.AutoSize = true;
            this.lblErrNom.ForeColor = System.Drawing.Color.Red;
            this.lblErrNom.Location = new System.Drawing.Point(271, 76);
            this.lblErrNom.Name = "lblErrNom";
            this.lblErrNom.Size = new System.Drawing.Size(0, 13);
            this.lblErrNom.TabIndex = 17;
            // 
            // lblErrDes
            // 
            this.lblErrDes.AutoSize = true;
            this.lblErrDes.ForeColor = System.Drawing.Color.Red;
            this.lblErrDes.Location = new System.Drawing.Point(271, 115);
            this.lblErrDes.Name = "lblErrDes";
            this.lblErrDes.Size = new System.Drawing.Size(0, 13);
            this.lblErrDes.TabIndex = 18;
            // 
            // lblErrImg
            // 
            this.lblErrImg.AutoSize = true;
            this.lblErrImg.ForeColor = System.Drawing.Color.Red;
            this.lblErrImg.Location = new System.Drawing.Point(363, 187);
            this.lblErrImg.Name = "lblErrImg";
            this.lblErrImg.Size = new System.Drawing.Size(0, 13);
            this.lblErrImg.TabIndex = 19;
            // 
            // lblErrTipo
            // 
            this.lblErrTipo.AutoSize = true;
            this.lblErrTipo.ForeColor = System.Drawing.Color.Red;
            this.lblErrTipo.Location = new System.Drawing.Point(271, 243);
            this.lblErrTipo.Name = "lblErrTipo";
            this.lblErrTipo.Size = new System.Drawing.Size(0, 13);
            this.lblErrTipo.TabIndex = 20;
            // 
            // lblErrDeb
            // 
            this.lblErrDeb.AutoSize = true;
            this.lblErrDeb.ForeColor = System.Drawing.Color.Red;
            this.lblErrDeb.Location = new System.Drawing.Point(271, 284);
            this.lblErrDeb.Name = "lblErrDeb";
            this.lblErrDeb.Size = new System.Drawing.Size(0, 13);
            this.lblErrDeb.TabIndex = 21;
            // 
            // FrmInsertPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(708, 475);
            this.Controls.Add(this.lblErrDeb);
            this.Controls.Add(this.lblErrTipo);
            this.Controls.Add(this.lblErrImg);
            this.Controls.Add(this.lblErrDes);
            this.Controls.Add(this.lblErrNom);
            this.Controls.Add(this.lblErrNum);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.pictureImg);
            this.Controls.Add(this.cboDebi);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.labDebi);
            this.Controls.Add(this.labTipo);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.labUrl);
            this.Controls.Add(this.labDesc);
            this.Controls.Add(this.labNom);
            this.Controls.Add(this.labNum);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "FrmInsertPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Pokemon";
            this.Load += new System.EventHandler(this.FrmInsertPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label labNum;
        private System.Windows.Forms.Label labNom;
        private System.Windows.Forms.Label labDesc;
        private System.Windows.Forms.Label labUrl;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label labTipo;
        private System.Windows.Forms.Label labDebi;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ComboBox cboDebi;
        private System.Windows.Forms.PictureBox pictureImg;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Label lblErrNum;
        private System.Windows.Forms.Label lblErrNom;
        private System.Windows.Forms.Label lblErrDes;
        private System.Windows.Forms.Label lblErrImg;
        private System.Windows.Forms.Label lblErrTipo;
        private System.Windows.Forms.Label lblErrDeb;
    }
}
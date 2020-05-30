namespace Work_Register
{
    partial class MC
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MC));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_top = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.Numero_txt = new System.Windows.Forms.TextBox();
            this.Nome_txt = new System.Windows.Forms.TextBox();
            this.Dados_dgv = new System.Windows.Forms.DataGridView();
            this.categoria_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_statusbar = new System.Windows.Forms.Panel();
            this.Cancelar_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Salvar_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Eliminar_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Editar_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Novo_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Categoria_cbx = new System.Windows.Forms.ComboBox();
            this.Categoria_txt = new System.Windows.Forms.TextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Notificação = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dados_dgv)).BeginInit();
            this.panel_statusbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Goldenrod;
            this.panel_top.Controls.Add(this.bunifuImageButton2);
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(485, 28);
            this.panel_top.TabIndex = 0;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Olive;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(453, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(29, 24);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 13;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Location = new System.Drawing.Point(24, 67);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(52, 13);
            this.lbl_categoria.TabIndex = 1;
            this.lbl_categoria.Text = "Categoria";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(24, 111);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(24, 158);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(44, 13);
            this.lbl_numero.TabIndex = 3;
            this.lbl_numero.Text = "Número";
            // 
            // Numero_txt
            // 
            this.Numero_txt.Location = new System.Drawing.Point(80, 155);
            this.Numero_txt.Name = "Numero_txt";
            this.Numero_txt.Size = new System.Drawing.Size(100, 20);
            this.Numero_txt.TabIndex = 5;
            // 
            // Nome_txt
            // 
            this.Nome_txt.Location = new System.Drawing.Point(80, 108);
            this.Nome_txt.Name = "Nome_txt";
            this.Nome_txt.Size = new System.Drawing.Size(112, 20);
            this.Nome_txt.TabIndex = 6;
            // 
            // Dados_dgv
            // 
            this.Dados_dgv.AllowUserToAddRows = false;
            this.Dados_dgv.AllowUserToOrderColumns = true;
            this.Dados_dgv.AllowUserToResizeColumns = false;
            this.Dados_dgv.AllowUserToResizeRows = false;
            this.Dados_dgv.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.Dados_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dados_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoria_dgv,
            this.nome_dgv,
            this.numero_dgv});
            this.Dados_dgv.GridColor = System.Drawing.Color.Gold;
            this.Dados_dgv.Location = new System.Drawing.Point(198, 51);
            this.Dados_dgv.MultiSelect = false;
            this.Dados_dgv.Name = "Dados_dgv";
            this.Dados_dgv.ReadOnly = true;
            this.Dados_dgv.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Olive;
            this.Dados_dgv.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dados_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dados_dgv.Size = new System.Drawing.Size(275, 133);
            this.Dados_dgv.TabIndex = 7;
            this.Dados_dgv.SelectionChanged += new System.EventHandler(this.Dados_dgv_SelectionChanged);
            // 
            // categoria_dgv
            // 
            this.categoria_dgv.HeaderText = "Categoria";
            this.categoria_dgv.Name = "categoria_dgv";
            this.categoria_dgv.ReadOnly = true;
            this.categoria_dgv.ToolTipText = "Categoria do Contacto";
            // 
            // nome_dgv
            // 
            this.nome_dgv.HeaderText = "Nome";
            this.nome_dgv.Name = "nome_dgv";
            this.nome_dgv.ReadOnly = true;
            this.nome_dgv.ToolTipText = "Número de Contacto";
            // 
            // numero_dgv
            // 
            this.numero_dgv.HeaderText = "Número";
            this.numero_dgv.Name = "numero_dgv";
            this.numero_dgv.ReadOnly = true;
            this.numero_dgv.ToolTipText = "Número de Contacto";
            // 
            // panel_statusbar
            // 
            this.panel_statusbar.BackColor = System.Drawing.Color.Goldenrod;
            this.panel_statusbar.Controls.Add(this.Cancelar_btn);
            this.panel_statusbar.Controls.Add(this.Salvar_btn);
            this.panel_statusbar.Controls.Add(this.Eliminar_btn);
            this.panel_statusbar.Controls.Add(this.Editar_btn);
            this.panel_statusbar.Controls.Add(this.Novo_btn);
            this.panel_statusbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_statusbar.Location = new System.Drawing.Point(0, 201);
            this.panel_statusbar.Name = "panel_statusbar";
            this.panel_statusbar.Size = new System.Drawing.Size(485, 39);
            this.panel_statusbar.TabIndex = 8;
            // 
            // Cancelar_btn
            // 
            this.Cancelar_btn.ActiveBorderThickness = 1;
            this.Cancelar_btn.ActiveCornerRadius = 20;
            this.Cancelar_btn.ActiveFillColor = System.Drawing.Color.Gold;
            this.Cancelar_btn.ActiveForecolor = System.Drawing.Color.White;
            this.Cancelar_btn.ActiveLineColor = System.Drawing.Color.DarkGoldenrod;
            this.Cancelar_btn.BackColor = System.Drawing.Color.Goldenrod;
            this.Cancelar_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cancelar_btn.BackgroundImage")));
            this.Cancelar_btn.ButtonText = "Cancelar";
            this.Cancelar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancelar_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Cancelar_btn.IdleBorderThickness = 1;
            this.Cancelar_btn.IdleCornerRadius = 20;
            this.Cancelar_btn.IdleFillColor = System.Drawing.Color.White;
            this.Cancelar_btn.IdleForecolor = System.Drawing.Color.Orange;
            this.Cancelar_btn.IdleLineColor = System.Drawing.Color.Orange;
            this.Cancelar_btn.Location = new System.Drawing.Point(383, 0);
            this.Cancelar_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Cancelar_btn.Name = "Cancelar_btn";
            this.Cancelar_btn.Size = new System.Drawing.Size(88, 37);
            this.Cancelar_btn.TabIndex = 13;
            this.Cancelar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click);
            // 
            // Salvar_btn
            // 
            this.Salvar_btn.ActiveBorderThickness = 1;
            this.Salvar_btn.ActiveCornerRadius = 20;
            this.Salvar_btn.ActiveFillColor = System.Drawing.Color.Gold;
            this.Salvar_btn.ActiveForecolor = System.Drawing.Color.White;
            this.Salvar_btn.ActiveLineColor = System.Drawing.Color.DarkGoldenrod;
            this.Salvar_btn.BackColor = System.Drawing.Color.Goldenrod;
            this.Salvar_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Salvar_btn.BackgroundImage")));
            this.Salvar_btn.ButtonText = "Salvar";
            this.Salvar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salvar_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salvar_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Salvar_btn.IdleBorderThickness = 1;
            this.Salvar_btn.IdleCornerRadius = 20;
            this.Salvar_btn.IdleFillColor = System.Drawing.Color.White;
            this.Salvar_btn.IdleForecolor = System.Drawing.Color.Orange;
            this.Salvar_btn.IdleLineColor = System.Drawing.Color.Orange;
            this.Salvar_btn.Location = new System.Drawing.Point(302, 0);
            this.Salvar_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Salvar_btn.Name = "Salvar_btn";
            this.Salvar_btn.Size = new System.Drawing.Size(71, 37);
            this.Salvar_btn.TabIndex = 12;
            this.Salvar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Salvar_btn.Click += new System.EventHandler(this.Salvar_btn_Click);
            // 
            // Eliminar_btn
            // 
            this.Eliminar_btn.ActiveBorderThickness = 1;
            this.Eliminar_btn.ActiveCornerRadius = 20;
            this.Eliminar_btn.ActiveFillColor = System.Drawing.Color.Gold;
            this.Eliminar_btn.ActiveForecolor = System.Drawing.Color.White;
            this.Eliminar_btn.ActiveLineColor = System.Drawing.Color.DarkGoldenrod;
            this.Eliminar_btn.BackColor = System.Drawing.Color.Goldenrod;
            this.Eliminar_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Eliminar_btn.BackgroundImage")));
            this.Eliminar_btn.ButtonText = "Eliminar";
            this.Eliminar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Eliminar_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Eliminar_btn.IdleBorderThickness = 1;
            this.Eliminar_btn.IdleCornerRadius = 20;
            this.Eliminar_btn.IdleFillColor = System.Drawing.Color.White;
            this.Eliminar_btn.IdleForecolor = System.Drawing.Color.Orange;
            this.Eliminar_btn.IdleLineColor = System.Drawing.Color.Orange;
            this.Eliminar_btn.Location = new System.Drawing.Point(157, 0);
            this.Eliminar_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Eliminar_btn.Name = "Eliminar_btn";
            this.Eliminar_btn.Size = new System.Drawing.Size(71, 37);
            this.Eliminar_btn.TabIndex = 11;
            this.Eliminar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Eliminar_btn.Click += new System.EventHandler(this.Eliminar_btn_Click);
            // 
            // Editar_btn
            // 
            this.Editar_btn.ActiveBorderThickness = 1;
            this.Editar_btn.ActiveCornerRadius = 20;
            this.Editar_btn.ActiveFillColor = System.Drawing.Color.Gold;
            this.Editar_btn.ActiveForecolor = System.Drawing.Color.White;
            this.Editar_btn.ActiveLineColor = System.Drawing.Color.DarkGoldenrod;
            this.Editar_btn.BackColor = System.Drawing.Color.Goldenrod;
            this.Editar_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Editar_btn.BackgroundImage")));
            this.Editar_btn.ButtonText = "Editar";
            this.Editar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Editar_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editar_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Editar_btn.IdleBorderThickness = 1;
            this.Editar_btn.IdleCornerRadius = 20;
            this.Editar_btn.IdleFillColor = System.Drawing.Color.White;
            this.Editar_btn.IdleForecolor = System.Drawing.Color.Orange;
            this.Editar_btn.IdleLineColor = System.Drawing.Color.Orange;
            this.Editar_btn.Location = new System.Drawing.Point(78, 0);
            this.Editar_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Editar_btn.Name = "Editar_btn";
            this.Editar_btn.Size = new System.Drawing.Size(69, 37);
            this.Editar_btn.TabIndex = 10;
            this.Editar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Editar_btn.Click += new System.EventHandler(this.Editar_btn_Click);
            // 
            // Novo_btn
            // 
            this.Novo_btn.ActiveBorderThickness = 1;
            this.Novo_btn.ActiveCornerRadius = 20;
            this.Novo_btn.ActiveFillColor = System.Drawing.Color.Gold;
            this.Novo_btn.ActiveForecolor = System.Drawing.Color.White;
            this.Novo_btn.ActiveLineColor = System.Drawing.Color.DarkGoldenrod;
            this.Novo_btn.BackColor = System.Drawing.Color.Goldenrod;
            this.Novo_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Novo_btn.BackgroundImage")));
            this.Novo_btn.ButtonText = "Novo";
            this.Novo_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Novo_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Novo_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Novo_btn.IdleBorderThickness = 1;
            this.Novo_btn.IdleCornerRadius = 20;
            this.Novo_btn.IdleFillColor = System.Drawing.Color.White;
            this.Novo_btn.IdleForecolor = System.Drawing.Color.Orange;
            this.Novo_btn.IdleLineColor = System.Drawing.Color.Orange;
            this.Novo_btn.Location = new System.Drawing.Point(5, 0);
            this.Novo_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Novo_btn.Name = "Novo_btn";
            this.Novo_btn.Size = new System.Drawing.Size(63, 37);
            this.Novo_btn.TabIndex = 9;
            this.Novo_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Novo_btn.Click += new System.EventHandler(this.Novo_btn_Click);
            // 
            // Categoria_cbx
            // 
            this.Categoria_cbx.FormattingEnabled = true;
            this.Categoria_cbx.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Categoria_cbx.Items.AddRange(new object[] {
            "Familiar",
            "Amigos",
            "Trabalho",
            "Colegas"});
            this.Categoria_cbx.Location = new System.Drawing.Point(80, 64);
            this.Categoria_cbx.Name = "Categoria_cbx";
            this.Categoria_cbx.Size = new System.Drawing.Size(112, 21);
            this.Categoria_cbx.TabIndex = 9;
            this.Categoria_cbx.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Categoria_txt
            // 
            this.Categoria_txt.Location = new System.Drawing.Point(238, 104);
            this.Categoria_txt.Name = "Categoria_txt";
            this.Categoria_txt.Size = new System.Drawing.Size(100, 20);
            this.Categoria_txt.TabIndex = 4;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Notificação
            // 
            this.Notificação.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Notificação.BalloonTipText = "Olá Juciano, DLIC está operacional para adicionares os teus contactos!";
            this.Notificação.BalloonTipTitle = "DLIC";
            this.Notificação.Icon = ((System.Drawing.Icon)(resources.GetObject("Notificação.Icon")));
            this.Notificação.Text = "DLIC - Agenda telefônica";
            this.Notificação.Visible = true;
            this.Notificação.Click += new System.EventHandler(this.Notificação_Click);
            // 
            // MC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 240);
            this.Controls.Add(this.Categoria_cbx);
            this.Controls.Add(this.panel_statusbar);
            this.Controls.Add(this.Dados_dgv);
            this.Controls.Add(this.Nome_txt);
            this.Controls.Add(this.Numero_txt);
            this.Controls.Add(this.Categoria_txt);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MC";
            this.ShowInTaskbar = false;
            this.Text = "DLIC";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MC_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dados_dgv)).EndInit();
            this.panel_statusbar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel_statusbar;
        private Bunifu.Framework.UI.BunifuThinButton2 Eliminar_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 Editar_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 Novo_btn;
        private System.Windows.Forms.DataGridView Dados_dgv;
        private System.Windows.Forms.TextBox Nome_txt;
        private System.Windows.Forms.TextBox Numero_txt;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.Panel panel_top;
        private Bunifu.Framework.UI.BunifuThinButton2 Cancelar_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 Salvar_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Categoria_cbx;
        private System.Windows.Forms.TextBox Categoria_txt;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.NotifyIcon Notificação;
    }
}


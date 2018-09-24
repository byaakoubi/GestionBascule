namespace GestionBascule
{
    partial class PontBascule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PontBascule));
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.TimerReadWeight = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Camion_Trans_DGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pes_1_entre_b = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pes_1_sortie_b = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.refresh_b = new System.Windows.Forms.Button();
            this.reconnect_bas_pb = new System.Windows.Forms.PictureBox();
            this.quit_b = new System.Windows.Forms.Button();
            this.edit_b = new System.Windows.Forms.Button();
            this.status_bas_pb = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.delete_b = new System.Windows.Forms.Button();
            this.pes_2_b = new System.Windows.Forms.Button();
            this.preferences_b = new System.Windows.Forms.Button();
            this.AfficheurBascule_lab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Camion_Trans_DGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reconnect_bas_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_bas_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // SerialPort1
            // 
            this.SerialPort1.StopBits = System.IO.Ports.StopBits.Two;
            this.SerialPort1.WriteBufferSize = 8000;
            this.SerialPort1.WriteTimeout = 10000;
            this.SerialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // TimerReadWeight
            // 
            this.TimerReadWeight.Enabled = true;
            this.TimerReadWeight.Interval = 1000;
            this.TimerReadWeight.Tick += new System.EventHandler(this.timerReadWeight_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 34);
            this.label1.TabIndex = 59;
            this.label1.Text = "Liste Camions en Transit (Attente 2 ème pesage)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Camion_Trans_DGV
            // 
            this.Camion_Trans_DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Camion_Trans_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Camion_Trans_DGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Camion_Trans_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Camion_Trans_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Camion_Trans_DGV.Location = new System.Drawing.Point(0, 193);
            this.Camion_Trans_DGV.Name = "Camion_Trans_DGV";
            this.Camion_Trans_DGV.Size = new System.Drawing.Size(788, 201);
            this.Camion_Trans_DGV.TabIndex = 0;
            this.Camion_Trans_DGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listTransit_dgv_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Poids Entré";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // SerialPort2
            // 
            this.SerialPort2.StopBits = System.IO.Ports.StopBits.Two;
            this.SerialPort2.WriteBufferSize = 8000;
            this.SerialPort2.WriteTimeout = 10000;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pes_1_entre_b);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pes_1_sortie_b);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 459);
            this.panel1.TabIndex = 1;
            // 
            // pes_1_entre_b
            // 
            this.pes_1_entre_b.BackColor = System.Drawing.Color.White;
            this.pes_1_entre_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pes_1_entre_b.Image = ((System.Drawing.Image)(resources.GetObject("pes_1_entre_b.Image")));
            this.pes_1_entre_b.Location = new System.Drawing.Point(9, 52);
            this.pes_1_entre_b.Name = "pes_1_entre_b";
            this.pes_1_entre_b.Size = new System.Drawing.Size(151, 47);
            this.pes_1_entre_b.TabIndex = 3;
            this.pes_1_entre_b.Text = "    Entrée Stock [F1]";
            this.pes_1_entre_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pes_1_entre_b.UseVisualStyleBackColor = false;
            this.pes_1_entre_b.Click += new System.EventHandler(this.pesage_1_Entre_handler);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pesage 1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pes_1_sortie_b
            // 
            this.pes_1_sortie_b.BackColor = System.Drawing.Color.White;
            this.pes_1_sortie_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pes_1_sortie_b.Image = ((System.Drawing.Image)(resources.GetObject("pes_1_sortie_b.Image")));
            this.pes_1_sortie_b.Location = new System.Drawing.Point(9, 105);
            this.pes_1_sortie_b.Name = "pes_1_sortie_b";
            this.pes_1_sortie_b.Size = new System.Drawing.Size(151, 47);
            this.pes_1_sortie_b.TabIndex = 1;
            this.pes_1_sortie_b.Text = "    Sortie Stock [F2]";
            this.pes_1_sortie_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pes_1_sortie_b.UseVisualStyleBackColor = false;
            this.pes_1_sortie_b.Click += new System.EventHandler(this.pesage_1_Sortie_handler);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.refresh_b);
            this.panel4.Controls.Add(this.reconnect_bas_pb);
            this.panel4.Controls.Add(this.quit_b);
            this.panel4.Controls.Add(this.edit_b);
            this.panel4.Controls.Add(this.status_bas_pb);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.delete_b);
            this.panel4.Controls.Add(this.pes_2_b);
            this.panel4.Controls.Add(this.preferences_b);
            this.panel4.Controls.Add(this.AfficheurBascule_lab);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.Camion_Trans_DGV);
            this.panel4.Location = new System.Drawing.Point(169, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(790, 459);
            this.panel4.TabIndex = 2;
            // 
            // refresh_b
            // 
            this.refresh_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refresh_b.BackColor = System.Drawing.Color.White;
            this.refresh_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_b.Image = ((System.Drawing.Image)(resources.GetObject("refresh_b.Image")));
            this.refresh_b.Location = new System.Drawing.Point(453, 402);
            this.refresh_b.Name = "refresh_b";
            this.refresh_b.Size = new System.Drawing.Size(142, 47);
            this.refresh_b.TabIndex = 70;
            this.refresh_b.Text = "    Rafraichir [F6]";
            this.refresh_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.refresh_b.UseVisualStyleBackColor = false;
            this.refresh_b.Click += new System.EventHandler(this.rafraichir_but_Click);
            // 
            // reconnect_bas_pb
            // 
            this.reconnect_bas_pb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reconnect_bas_pb.Image = ((System.Drawing.Image)(resources.GetObject("reconnect_bas_pb.Image")));
            this.reconnect_bas_pb.Location = new System.Drawing.Point(760, 61);
            this.reconnect_bas_pb.Name = "reconnect_bas_pb";
            this.reconnect_bas_pb.Size = new System.Drawing.Size(16, 16);
            this.reconnect_bas_pb.TabIndex = 69;
            this.reconnect_bas_pb.TabStop = false;
            this.reconnect_bas_pb.Tag = "Reconnect";
            this.reconnect_bas_pb.Click += new System.EventHandler(this.Connect_Click);
            // 
            // quit_b
            // 
            this.quit_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quit_b.BackColor = System.Drawing.Color.White;
            this.quit_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit_b.Image = ((System.Drawing.Image)(resources.GetObject("quit_b.Image")));
            this.quit_b.Location = new System.Drawing.Point(717, 402);
            this.quit_b.Name = "quit_b";
            this.quit_b.Size = new System.Drawing.Size(59, 47);
            this.quit_b.TabIndex = 68;
            this.quit_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.quit_b.UseVisualStyleBackColor = false;
            this.quit_b.Click += new System.EventHandler(this.quit_b_Click);
            // 
            // edit_b
            // 
            this.edit_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edit_b.BackColor = System.Drawing.Color.White;
            this.edit_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_b.Image = ((System.Drawing.Image)(resources.GetObject("edit_b.Image")));
            this.edit_b.Location = new System.Drawing.Point(157, 402);
            this.edit_b.Name = "edit_b";
            this.edit_b.Size = new System.Drawing.Size(142, 47);
            this.edit_b.TabIndex = 67;
            this.edit_b.Text = "    Editer [F4]";
            this.edit_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit_b.UseVisualStyleBackColor = false;
            this.edit_b.Click += new System.EventHandler(this.edit_b_Click);
            // 
            // status_bas_pb
            // 
            this.status_bas_pb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.status_bas_pb.Image = global::GestionBascule.Properties.Resources.ko;
            this.status_bas_pb.Location = new System.Drawing.Point(738, 61);
            this.status_bas_pb.Name = "status_bas_pb";
            this.status_bas_pb.Size = new System.Drawing.Size(16, 16);
            this.status_bas_pb.TabIndex = 66;
            this.status_bas_pb.TabStop = false;
            this.status_bas_pb.Tag = "Statut bascule";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(483, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 23);
            this.label4.TabIndex = 64;
            this.label4.Text = "Poids affiché par la bascule (kg) ";
            // 
            // delete_b
            // 
            this.delete_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delete_b.BackColor = System.Drawing.Color.White;
            this.delete_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_b.Image = ((System.Drawing.Image)(resources.GetObject("delete_b.Image")));
            this.delete_b.Location = new System.Drawing.Point(305, 402);
            this.delete_b.Name = "delete_b";
            this.delete_b.Size = new System.Drawing.Size(142, 47);
            this.delete_b.TabIndex = 63;
            this.delete_b.Text = "    Supprimer [F5]";
            this.delete_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delete_b.UseVisualStyleBackColor = false;
            this.delete_b.Click += new System.EventHandler(this.delete_pes_1_handler);
            // 
            // pes_2_b
            // 
            this.pes_2_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pes_2_b.BackColor = System.Drawing.Color.White;
            this.pes_2_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pes_2_b.Image = ((System.Drawing.Image)(resources.GetObject("pes_2_b.Image")));
            this.pes_2_b.Location = new System.Drawing.Point(9, 402);
            this.pes_2_b.Name = "pes_2_b";
            this.pes_2_b.Size = new System.Drawing.Size(142, 47);
            this.pes_2_b.TabIndex = 62;
            this.pes_2_b.Text = "    Pesage 2 [F3]";
            this.pes_2_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pes_2_b.UseVisualStyleBackColor = false;
            this.pes_2_b.Click += new System.EventHandler(this.pesage_2_handler);
            // 
            // preferences_b
            // 
            this.preferences_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.preferences_b.BackColor = System.Drawing.Color.White;
            this.preferences_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preferences_b.Image = ((System.Drawing.Image)(resources.GetObject("preferences_b.Image")));
            this.preferences_b.Location = new System.Drawing.Point(634, 1);
            this.preferences_b.Name = "preferences_b";
            this.preferences_b.Size = new System.Drawing.Size(142, 31);
            this.preferences_b.TabIndex = 61;
            this.preferences_b.Text = "    Paramètres [F10]";
            this.preferences_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.preferences_b.UseVisualStyleBackColor = false;
            this.preferences_b.Click += new System.EventHandler(this.preferences_b_Click);
            // 
            // AfficheurBascule_lab
            // 
            this.AfficheurBascule_lab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AfficheurBascule_lab.BackColor = System.Drawing.Color.YellowGreen;
            this.AfficheurBascule_lab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AfficheurBascule_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.AfficheurBascule_lab.ForeColor = System.Drawing.Color.White;
            this.AfficheurBascule_lab.Location = new System.Drawing.Point(486, 84);
            this.AfficheurBascule_lab.Name = "AfficheurBascule_lab";
            this.AfficheurBascule_lab.Size = new System.Drawing.Size(290, 47);
            this.AfficheurBascule_lab.TabIndex = 60;
            this.AfficheurBascule_lab.Text = "0";
            this.AfficheurBascule_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(788, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Statut de la bascule";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PontBascule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(959, 459);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "PontBascule";
            this.Text = "Pont Bascule";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PontBascule_FormClosing);
            this.Load += new System.EventHandler(this.dashboardPesage_Load);
            this.Leave += new System.EventHandler(this.DashboardPesage_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.Camion_Trans_DGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reconnect_bas_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_bas_pb)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.Timer TimerReadWeight;
        private System.Windows.Forms.DataGridView Camion_Trans_DGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pes_1_sortie_b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AfficheurBascule_lab;
        private System.Windows.Forms.Button preferences_b;
        private System.Windows.Forms.Button pes_2_b;
        private System.Windows.Forms.Button delete_b;
        private System.Windows.Forms.Button pes_1_entre_b;
        private System.Windows.Forms.Label label4;
        public System.IO.Ports.SerialPort SerialPort1;
        public System.IO.Ports.SerialPort SerialPort2;
        public System.Windows.Forms.PictureBox status_bas_pb;
        private System.Windows.Forms.Button edit_b;
        private System.Windows.Forms.Button quit_b;
        public System.Windows.Forms.PictureBox reconnect_bas_pb;
        private System.Windows.Forms.Button refresh_b;
	}
}


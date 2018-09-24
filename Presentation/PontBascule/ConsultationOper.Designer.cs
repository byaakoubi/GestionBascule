namespace GestionBascule
{
    partial class ConsultationOper
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultationOper));
            this.STOCK_DGV = new System.Windows.Forms.DataGridView();
            this.datefin_dtp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.datedebut_dtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ecartMax_tb = new USER_CONTROLS.TNumEditBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ecartMin_tb = new USER_CONTROLS.TNumEditBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chauffeur_cb = new System.Windows.Forms.ComboBox();
            this.camion_cb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.type_oper_cb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nom_clt_cb = new System.Windows.Forms.ComboBox();
            this.nom_frn_cb = new System.Windows.Forms.ComboBox();
            this.desig_article_cb = new System.Windows.Forms.ComboBox();
            this.supprimer_but = new System.Windows.Forms.Button();
            this.afficher_but = new System.Windows.Forms.Button();
            this.quitter_but = new System.Windows.Forms.Button();
            this.imprimer_but = new System.Windows.Forms.Button();
            this.editer_but = new System.Windows.Forms.Button();
            this.transit_but = new System.Windows.Forms.Button();
            this.resetfilter_but = new System.Windows.Forms.Button();
            this.switchDBComp1 = new GestionBascule.Presentation.Components.SwitchDBComp();
            ((System.ComponentModel.ISupportInitialize)(this.STOCK_DGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // STOCK_DGV
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.STOCK_DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.STOCK_DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.STOCK_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.STOCK_DGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.STOCK_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.STOCK_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.STOCK_DGV.GridColor = System.Drawing.Color.White;
            this.STOCK_DGV.Location = new System.Drawing.Point(12, 301);
            this.STOCK_DGV.Name = "STOCK_DGV";
            this.STOCK_DGV.Size = new System.Drawing.Size(1252, 376);
            this.STOCK_DGV.TabIndex = 2;
            this.STOCK_DGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.STOCK_DGV_CellDoubleClick);
            // 
            // datefin_dtp
            // 
            this.datefin_dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.datefin_dtp.Location = new System.Drawing.Point(482, 145);
            this.datefin_dtp.Name = "datefin_dtp";
            this.datefin_dtp.Size = new System.Drawing.Size(200, 20);
            this.datefin_dtp.TabIndex = 8;
            this.datefin_dtp.ValueChanged += new System.EventHandler(this.datefin_dtp_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(376, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date fin";
            // 
            // datedebut_dtp
            // 
            this.datedebut_dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.datedebut_dtp.Location = new System.Drawing.Point(126, 145);
            this.datedebut_dtp.Name = "datedebut_dtp";
            this.datedebut_dtp.Size = new System.Drawing.Size(200, 20);
            this.datedebut_dtp.TabIndex = 7;
            this.datedebut_dtp.ValueChanged += new System.EventHandler(this.datedebut_dtp_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(17, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date début";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.switchDBComp1);
            this.groupBox2.Controls.Add(this.ecartMax_tb);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.ecartMin_tb);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.chauffeur_cb);
            this.groupBox2.Controls.Add(this.camion_cb);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.type_oper_cb);
            this.groupBox2.Controls.Add(this.datefin_dtp);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.datedebut_dtp);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nom_clt_cb);
            this.groupBox2.Controls.Add(this.nom_frn_cb);
            this.groupBox2.Controls.Add(this.desig_article_cb);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1252, 227);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Critères de recherche";
            // 
            // ecartMax_tb
            // 
            this.ecartMax_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ecartMax_tb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ecartMax_tb.Location = new System.Drawing.Point(482, 180);
            this.ecartMax_tb.Name = "ecartMax_tb";
            this.ecartMax_tb.Size = new System.Drawing.Size(200, 20);
            this.ecartMax_tb.TabIndex = 10;
            this.ecartMax_tb.Text = "9999";
            this.ecartMax_tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ecartMax_tb_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(376, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 79;
            this.label10.Text = "Ecart maximum";
            // 
            // ecartMin_tb
            // 
            this.ecartMin_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ecartMin_tb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ecartMin_tb.Location = new System.Drawing.Point(126, 180);
            this.ecartMin_tb.Name = "ecartMin_tb";
            this.ecartMin_tb.Size = new System.Drawing.Size(200, 20);
            this.ecartMin_tb.TabIndex = 9;
            this.ecartMin_tb.Text = "-9999";
            this.ecartMin_tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ecartMin_tb_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(17, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 77;
            this.label9.Text = "Ecart minimum";
            // 
            // chauffeur_cb
            // 
            this.chauffeur_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chauffeur_cb.FormattingEnabled = true;
            this.chauffeur_cb.Location = new System.Drawing.Point(126, 109);
            this.chauffeur_cb.Name = "chauffeur_cb";
            this.chauffeur_cb.Size = new System.Drawing.Size(200, 21);
            this.chauffeur_cb.TabIndex = 5;
            this.chauffeur_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chauffeur_cb_KeyUp);
            // 
            // camion_cb
            // 
            this.camion_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.camion_cb.FormattingEnabled = true;
            this.camion_cb.Location = new System.Drawing.Point(482, 109);
            this.camion_cb.Name = "camion_cb";
            this.camion_cb.Size = new System.Drawing.Size(200, 21);
            this.camion_cb.TabIndex = 6;
            this.camion_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.camion_cb_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(376, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Matricule camion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(17, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 75;
            this.label8.Text = "Chauffeur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(17, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Opération Stock";
            // 
            // type_oper_cb
            // 
            this.type_oper_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.type_oper_cb.FormattingEnabled = true;
            this.type_oper_cb.Items.AddRange(new object[] {
            "Entrée Stock",
            "Sortie Stock"});
            this.type_oper_cb.Location = new System.Drawing.Point(126, 37);
            this.type_oper_cb.Name = "type_oper_cb";
            this.type_oper_cb.Size = new System.Drawing.Size(200, 21);
            this.type_oper_cb.TabIndex = 1;
            this.type_oper_cb.SelectedIndexChanged += new System.EventHandler(this.type_oper_cb_SelectedIndexChanged);
            this.type_oper_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.type_oper_cb_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(376, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(17, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Fournisseur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(376, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Désignation article";
            // 
            // nom_clt_cb
            // 
            this.nom_clt_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nom_clt_cb.FormattingEnabled = true;
            this.nom_clt_cb.Location = new System.Drawing.Point(482, 73);
            this.nom_clt_cb.Name = "nom_clt_cb";
            this.nom_clt_cb.Size = new System.Drawing.Size(200, 21);
            this.nom_clt_cb.TabIndex = 4;
            this.nom_clt_cb.SelectedIndexChanged += new System.EventHandler(this.nom_clt_cb_SelectedIndexChanged);
            this.nom_clt_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nom_clt_cb_KeyUp);
            // 
            // nom_frn_cb
            // 
            this.nom_frn_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nom_frn_cb.FormattingEnabled = true;
            this.nom_frn_cb.Location = new System.Drawing.Point(126, 73);
            this.nom_frn_cb.Name = "nom_frn_cb";
            this.nom_frn_cb.Size = new System.Drawing.Size(200, 21);
            this.nom_frn_cb.TabIndex = 3;
            this.nom_frn_cb.SelectedIndexChanged += new System.EventHandler(this.nom_frn_cb_SelectedIndexChanged);
            this.nom_frn_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nom_frn_cb_KeyUp);
            // 
            // desig_article_cb
            // 
            this.desig_article_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.desig_article_cb.FormattingEnabled = true;
            this.desig_article_cb.Location = new System.Drawing.Point(482, 37);
            this.desig_article_cb.Name = "desig_article_cb";
            this.desig_article_cb.Size = new System.Drawing.Size(200, 21);
            this.desig_article_cb.TabIndex = 2;
            this.desig_article_cb.SelectedIndexChanged += new System.EventHandler(this.desig_produit_cb_SelectedIndexChanged);
            this.desig_article_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.desig_produit_cb_KeyUp);
            // 
            // supprimer_but
            // 
            this.supprimer_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.supprimer_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.supprimer_but.Image = global::GestionBascule.Properties.Resources.if_Delete;
            this.supprimer_but.Location = new System.Drawing.Point(238, 697);
            this.supprimer_but.Name = "supprimer_but";
            this.supprimer_but.Size = new System.Drawing.Size(107, 33);
            this.supprimer_but.TabIndex = 95;
            this.supprimer_but.Text = "   Supprimer";
            this.supprimer_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.supprimer_but.UseVisualStyleBackColor = true;
            this.supprimer_but.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // afficher_but
            // 
            this.afficher_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.afficher_but.Image = global::GestionBascule.Properties.Resources.if_Accept;
            this.afficher_but.Location = new System.Drawing.Point(12, 256);
            this.afficher_but.Name = "afficher_but";
            this.afficher_but.Size = new System.Drawing.Size(107, 33);
            this.afficher_but.TabIndex = 94;
            this.afficher_but.Text = "   Afficher";
            this.afficher_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.afficher_but.UseVisualStyleBackColor = true;
            this.afficher_but.Click += new System.EventHandler(this.AfficherClick);
            // 
            // quitter_but
            // 
            this.quitter_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quitter_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.quitter_but.Image = ((System.Drawing.Image)(resources.GetObject("quitter_but.Image")));
            this.quitter_but.Location = new System.Drawing.Point(464, 697);
            this.quitter_but.Name = "quitter_but";
            this.quitter_but.Size = new System.Drawing.Size(107, 33);
            this.quitter_but.TabIndex = 94;
            this.quitter_but.Text = "   Quitter";
            this.quitter_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.quitter_but.UseVisualStyleBackColor = true;
            this.quitter_but.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // imprimer_but
            // 
            this.imprimer_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imprimer_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.imprimer_but.Image = ((System.Drawing.Image)(resources.GetObject("imprimer_but.Image")));
            this.imprimer_but.Location = new System.Drawing.Point(12, 697);
            this.imprimer_but.Name = "imprimer_but";
            this.imprimer_but.Size = new System.Drawing.Size(107, 33);
            this.imprimer_but.TabIndex = 93;
            this.imprimer_but.Text = "   Imprimer";
            this.imprimer_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.imprimer_but.UseVisualStyleBackColor = true;
            this.imprimer_but.Click += new System.EventHandler(this.Imprimer_Click);
            // 
            // editer_but
            // 
            this.editer_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editer_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.editer_but.Image = global::GestionBascule.Properties.Resources.if_Edit;
            this.editer_but.Location = new System.Drawing.Point(125, 697);
            this.editer_but.Name = "editer_but";
            this.editer_but.Size = new System.Drawing.Size(107, 33);
            this.editer_but.TabIndex = 96;
            this.editer_but.Text = "   Editer";
            this.editer_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editer_but.UseVisualStyleBackColor = true;
            this.editer_but.Click += new System.EventHandler(this.editer_but_Click);
            // 
            // transit_but
            // 
            this.transit_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.transit_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.transit_but.Image = global::GestionBascule.Properties.Resources.if_Billboard;
            this.transit_but.Location = new System.Drawing.Point(351, 697);
            this.transit_but.Name = "transit_but";
            this.transit_but.Size = new System.Drawing.Size(107, 33);
            this.transit_but.TabIndex = 97;
            this.transit_but.Text = "   Transit";
            this.transit_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.transit_but.UseVisualStyleBackColor = true;
            this.transit_but.Click += new System.EventHandler(this.transit_but_Click);
            // 
            // resetfilter_but
            // 
            this.resetfilter_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.resetfilter_but.Image = global::GestionBascule.Properties.Resources.if_Refresh;
            this.resetfilter_but.Location = new System.Drawing.Point(138, 256);
            this.resetfilter_but.Name = "resetfilter_but";
            this.resetfilter_but.Size = new System.Drawing.Size(107, 33);
            this.resetfilter_but.TabIndex = 98;
            this.resetfilter_but.Text = "   Reset filtres";
            this.resetfilter_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.resetfilter_but.UseVisualStyleBackColor = true;
            this.resetfilter_but.Click += new System.EventHandler(this.resetfilter_but_Click);
            // 
            // switchDBComp1
            // 
            this.switchDBComp1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.switchDBComp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.switchDBComp1.Location = new System.Drawing.Point(1146, 27);
            this.switchDBComp1.Name = "switchDBComp1";
            this.switchDBComp1.Size = new System.Drawing.Size(90, 57);
            this.switchDBComp1.TabIndex = 99;
            this.switchDBComp1.radioStateChanged += new GestionBascule.Presentation.Components.SwitchDBComp.RadioStateChanged(this.switchDBComp1_radioStateChanged);
            // 
            // ConsultationOper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1276, 742);
            this.Controls.Add(this.resetfilter_but);
            this.Controls.Add(this.transit_but);
            this.Controls.Add(this.editer_but);
            this.Controls.Add(this.supprimer_but);
            this.Controls.Add(this.afficher_but);
            this.Controls.Add(this.quitter_but);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.imprimer_but);
            this.Controls.Add(this.STOCK_DGV);
            this.Name = "ConsultationOper";
            this.Text = "Etat pont bascule détaillé";
            this.Load += new System.EventHandler(this.ConsultationOpe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.STOCK_DGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView STOCK_DGV;
        private System.Windows.Forms.DateTimePicker datefin_dtp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datedebut_dtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox nom_frn_cb;
        private System.Windows.Forms.ComboBox desig_article_cb;
        private System.Windows.Forms.ComboBox nom_clt_cb;
        private System.Windows.Forms.Button quitter_but;
        private System.Windows.Forms.Button imprimer_but;
        private System.Windows.Forms.Button supprimer_but;
        private System.Windows.Forms.Button afficher_but;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox type_oper_cb;
        private System.Windows.Forms.Button editer_but;
        private System.Windows.Forms.Button transit_but;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox chauffeur_cb;
        private System.Windows.Forms.ComboBox camion_cb;
        private System.Windows.Forms.Label label9;
        private USER_CONTROLS.TNumEditBox ecartMax_tb;
        private System.Windows.Forms.Label label10;
        private USER_CONTROLS.TNumEditBox ecartMin_tb;
        private System.Windows.Forms.Button resetfilter_but;
        private Presentation.Components.SwitchDBComp switchDBComp1;
    }
}
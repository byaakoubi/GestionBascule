namespace GestionBascule
{
    partial class EntreeStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntreeStock));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chauffeur_cb = new System.Windows.Forms.ComboBox();
            this.camion_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.date_sortie_dtp = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.date_entree_dtp = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.nticket_tb = new USER_CONTROLS.MaskedTextBox();
            this.enregistrer_but = new System.Windows.Forms.Button();
            this.quitter_but = new System.Windows.Forms.Button();
            this.prTabControl = new System.Windows.Forms.TabControl();
            this.pesage_tp = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.poids_recep_tb = new USER_CONTROLS.TNumEditBox();
            this.label26 = new System.Windows.Forms.Label();
            this.poids_net_tb = new USER_CONTROLS.TNumEditBox();
            this.pesage2_tb = new USER_CONTROLS.TNumEditBox();
            this.label27 = new System.Windows.Forms.Label();
            this.pesage1_tb = new USER_CONTROLS.TNumEditBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bls_tp = new System.Windows.Forms.TabPage();
            this.editer_b = new System.Windows.Forms.Button();
            this.supprimer_b = new System.Windows.Forms.Button();
            this.ajouter_b = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BLs_DGV = new System.Windows.Forms.DataGridView();
            this.switchDBComp1 = new GestionBascule.Presentation.Components.SwitchDBComp();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.prTabControl.SuspendLayout();
            this.pesage_tp.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.bls_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BLs_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chauffeur_cb);
            this.groupBox1.Controls.Add(this.camion_cb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(27, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 112);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information Camion";
            // 
            // chauffeur_cb
            // 
            this.chauffeur_cb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chauffeur_cb.FormattingEnabled = true;
            this.chauffeur_cb.Location = new System.Drawing.Point(170, 71);
            this.chauffeur_cb.Name = "chauffeur_cb";
            this.chauffeur_cb.Size = new System.Drawing.Size(275, 23);
            this.chauffeur_cb.TabIndex = 2;
            this.chauffeur_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chauffeur_cb_KeyUp);
            // 
            // camion_cb
            // 
            this.camion_cb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camion_cb.FormattingEnabled = true;
            this.camion_cb.Location = new System.Drawing.Point(170, 34);
            this.camion_cb.Name = "camion_cb";
            this.camion_cb.Size = new System.Drawing.Size(275, 23);
            this.camion_cb.TabIndex = 1;
            this.camion_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.camion_cb_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(42, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom chauffeur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricule camion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(42, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "N° Ticket";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.date_sortie_dtp);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.date_entree_dtp);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.nticket_tb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(27, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information BL";
            // 
            // date_sortie_dtp
            // 
            this.date_sortie_dtp.CustomFormat = "dd/MM/yyyy     HH:mm:ss ";
            this.date_sortie_dtp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_sortie_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_sortie_dtp.Location = new System.Drawing.Point(170, 113);
            this.date_sortie_dtp.Name = "date_sortie_dtp";
            this.date_sortie_dtp.Size = new System.Drawing.Size(275, 22);
            this.date_sortie_dtp.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(42, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 15);
            this.label15.TabIndex = 13;
            this.label15.Text = "Date / Heure Sortie";
            // 
            // date_entree_dtp
            // 
            this.date_entree_dtp.CustomFormat = "dd/MM/yyyy     HH:mm:ss ";
            this.date_entree_dtp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_entree_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_entree_dtp.Location = new System.Drawing.Point(170, 71);
            this.date_entree_dtp.Name = "date_entree_dtp";
            this.date_entree_dtp.Size = new System.Drawing.Size(275, 22);
            this.date_entree_dtp.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(42, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Date / Heure Entrée";
            // 
            // nticket_tb
            // 
            this.nticket_tb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nticket_tb.Location = new System.Drawing.Point(170, 34);
            this.nticket_tb.Masked = USER_CONTROLS.Mask.None;
            this.nticket_tb.Name = "nticket_tb";
            this.nticket_tb.Size = new System.Drawing.Size(275, 22);
            this.nticket_tb.TabIndex = 1;
            // 
            // enregistrer_but
            // 
            this.enregistrer_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.enregistrer_but.Image = ((System.Drawing.Image)(resources.GetObject("enregistrer_but.Image")));
            this.enregistrer_but.Location = new System.Drawing.Point(34, 567);
            this.enregistrer_but.Name = "enregistrer_but";
            this.enregistrer_but.Size = new System.Drawing.Size(107, 33);
            this.enregistrer_but.TabIndex = 5;
            this.enregistrer_but.Text = "   Enregistrer";
            this.enregistrer_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.enregistrer_but.UseVisualStyleBackColor = true;
            this.enregistrer_but.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // quitter_but
            // 
            this.quitter_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quitter_but.Image = ((System.Drawing.Image)(resources.GetObject("quitter_but.Image")));
            this.quitter_but.Location = new System.Drawing.Point(165, 567);
            this.quitter_but.Name = "quitter_but";
            this.quitter_but.Size = new System.Drawing.Size(107, 33);
            this.quitter_but.TabIndex = 54;
            this.quitter_but.Text = "   Quitter";
            this.quitter_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.quitter_but.UseVisualStyleBackColor = true;
            this.quitter_but.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // prTabControl
            // 
            this.prTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prTabControl.Controls.Add(this.pesage_tp);
            this.prTabControl.Controls.Add(this.bls_tp);
            this.prTabControl.Location = new System.Drawing.Point(3, 10);
            this.prTabControl.Name = "prTabControl";
            this.prTabControl.SelectedIndex = 0;
            this.prTabControl.Size = new System.Drawing.Size(860, 543);
            this.prTabControl.TabIndex = 55;
            // 
            // pesage_tp
            // 
            this.pesage_tp.Controls.Add(this.switchDBComp1);
            this.pesage_tp.Controls.Add(this.groupBox6);
            this.pesage_tp.Controls.Add(this.groupBox2);
            this.pesage_tp.Controls.Add(this.groupBox1);
            this.pesage_tp.Location = new System.Drawing.Point(4, 22);
            this.pesage_tp.Name = "pesage_tp";
            this.pesage_tp.Padding = new System.Windows.Forms.Padding(3);
            this.pesage_tp.Size = new System.Drawing.Size(852, 517);
            this.pesage_tp.TabIndex = 0;
            this.pesage_tp.Text = "Données pesage";
            this.pesage_tp.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.poids_recep_tb);
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Controls.Add(this.poids_net_tb);
            this.groupBox6.Controls.Add(this.pesage2_tb);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.pesage1_tb);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox6.Location = new System.Drawing.Point(26, 301);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(561, 194);
            this.groupBox6.TabIndex = 58;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pesage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(43, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Poids commandé";
            // 
            // poids_recep_tb
            // 
            this.poids_recep_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.poids_recep_tb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poids_recep_tb.Location = new System.Drawing.Point(170, 31);
            this.poids_recep_tb.Name = "poids_recep_tb";
            this.poids_recep_tb.ReadOnly = true;
            this.poids_recep_tb.Size = new System.Drawing.Size(275, 22);
            this.poids_recep_tb.TabIndex = 10;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(43, 148);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(60, 15);
            this.label26.TabIndex = 25;
            this.label26.Text = "Poids Net";
            // 
            // poids_net_tb
            // 
            this.poids_net_tb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poids_net_tb.Location = new System.Drawing.Point(170, 145);
            this.poids_net_tb.Name = "poids_net_tb";
            this.poids_net_tb.Size = new System.Drawing.Size(275, 22);
            this.poids_net_tb.TabIndex = 3;
            // 
            // pesage2_tb
            // 
            this.pesage2_tb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesage2_tb.Location = new System.Drawing.Point(170, 107);
            this.pesage2_tb.Name = "pesage2_tb";
            this.pesage2_tb.Size = new System.Drawing.Size(275, 22);
            this.pesage2_tb.TabIndex = 2;
            this.pesage2_tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pesage2_tb_KeyUp);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(43, 110);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 15);
            this.label27.TabIndex = 24;
            this.label27.Text = "Pesage_2";
            // 
            // pesage1_tb
            // 
            this.pesage1_tb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesage1_tb.Location = new System.Drawing.Point(170, 69);
            this.pesage1_tb.Name = "pesage1_tb";
            this.pesage1_tb.Size = new System.Drawing.Size(275, 22);
            this.pesage1_tb.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(43, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Pesage_1";
            // 
            // bls_tp
            // 
            this.bls_tp.Controls.Add(this.editer_b);
            this.bls_tp.Controls.Add(this.supprimer_b);
            this.bls_tp.Controls.Add(this.ajouter_b);
            this.bls_tp.Controls.Add(this.label4);
            this.bls_tp.Controls.Add(this.BLs_DGV);
            this.bls_tp.Location = new System.Drawing.Point(4, 22);
            this.bls_tp.Name = "bls_tp";
            this.bls_tp.Padding = new System.Windows.Forms.Padding(3);
            this.bls_tp.Size = new System.Drawing.Size(852, 517);
            this.bls_tp.TabIndex = 1;
            this.bls_tp.Text = "Bons livraison";
            this.bls_tp.UseVisualStyleBackColor = true;
            // 
            // editer_b
            // 
            this.editer_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editer_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editer_b.Image = global::GestionBascule.Properties.Resources.if_Edit;
            this.editer_b.Location = new System.Drawing.Point(62, 476);
            this.editer_b.Name = "editer_b";
            this.editer_b.Size = new System.Drawing.Size(32, 26);
            this.editer_b.TabIndex = 59;
            this.editer_b.Tag = "Editer la BL selectionnée";
            this.editer_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editer_b.UseVisualStyleBackColor = true;
            this.editer_b.Click += new System.EventHandler(this.editer_b_Click);
            // 
            // supprimer_b
            // 
            this.supprimer_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.supprimer_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimer_b.Image = global::GestionBascule.Properties.Resources.if_Delete;
            this.supprimer_b.Location = new System.Drawing.Point(100, 476);
            this.supprimer_b.Name = "supprimer_b";
            this.supprimer_b.Size = new System.Drawing.Size(32, 26);
            this.supprimer_b.TabIndex = 58;
            this.supprimer_b.Tag = "Supprimer la BL selectionnée";
            this.supprimer_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.supprimer_b.UseVisualStyleBackColor = true;
            this.supprimer_b.Click += new System.EventHandler(this.supprimer_bl_Click);
            // 
            // ajouter_b
            // 
            this.ajouter_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ajouter_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajouter_b.Image = global::GestionBascule.Properties.Resources.if_Add_85235;
            this.ajouter_b.Location = new System.Drawing.Point(24, 476);
            this.ajouter_b.Name = "ajouter_b";
            this.ajouter_b.Size = new System.Drawing.Size(32, 26);
            this.ajouter_b.TabIndex = 57;
            this.ajouter_b.Tag = "Ajouter BL";
            this.ajouter_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ajouter_b.UseVisualStyleBackColor = true;
            this.ajouter_b.Click += new System.EventHandler(this.ajouter_bl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Liste des BLs ";
            // 
            // BLs_DGV
            // 
            this.BLs_DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BLs_DGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.BLs_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BLs_DGV.Location = new System.Drawing.Point(24, 55);
            this.BLs_DGV.Name = "BLs_DGV";
            this.BLs_DGV.Size = new System.Drawing.Size(806, 406);
            this.BLs_DGV.TabIndex = 0;
            // 
            // switchDBComp1
            // 
            this.switchDBComp1.Location = new System.Drawing.Point(741, 18);
            this.switchDBComp1.Name = "switchDBComp1";
            this.switchDBComp1.Size = new System.Drawing.Size(90, 57);
            this.switchDBComp1.TabIndex = 59;
            this.switchDBComp1.radioStateChanged += new GestionBascule.Presentation.Components.SwitchDBComp.RadioStateChanged(this.switchDBComp1_radioStateChanged);
            // 
            // EntreeStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(867, 612);
            this.Controls.Add(this.prTabControl);
            this.Controls.Add(this.quitter_but);
            this.Controls.Add(this.enregistrer_but);
            this.Name = "EntreeStock";
            this.Text = "Entrée Stock";
            this.Load += new System.EventHandler(this.Pesage1Sortie_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.prTabControl.ResumeLayout(false);
            this.pesage_tp.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.bls_tp.ResumeLayout(false);
            this.bls_tp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BLs_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private USER_CONTROLS.MaskedTextBox nticket_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker date_entree_dtp;
        private System.Windows.Forms.ComboBox camion_cb;
        private System.Windows.Forms.ComboBox chauffeur_cb;
        private System.Windows.Forms.Button enregistrer_but;
        private System.Windows.Forms.Button quitter_but;
        private System.Windows.Forms.TabControl prTabControl;
        private System.Windows.Forms.TabPage pesage_tp;
        private System.Windows.Forms.GroupBox groupBox6;
        private USER_CONTROLS.TNumEditBox pesage1_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage bls_tp;
        private System.Windows.Forms.DataGridView BLs_DGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ajouter_b;
        private System.Windows.Forms.Button supprimer_b;
        private System.Windows.Forms.Button editer_b;
        private System.Windows.Forms.Label label5;
        private USER_CONTROLS.TNumEditBox poids_recep_tb;
        private System.Windows.Forms.Label label26;
        private USER_CONTROLS.TNumEditBox poids_net_tb;
        private USER_CONTROLS.TNumEditBox pesage2_tb;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DateTimePicker date_sortie_dtp;
        private System.Windows.Forms.Label label15;
        private Presentation.Components.SwitchDBComp switchDBComp1;
    }
}
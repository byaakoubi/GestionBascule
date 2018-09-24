namespace GestionBascule
{
    partial class LineFournisseur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LineFournisseur));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.switchDBComp1 = new GestionBascule.Presentation.Components.SwitchDBComp();
            this.nom_frn_cb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.code_frn_cb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.date_entree_dtp = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.selectBLFrn1 = new GestionBascule.Presentation.Components.SelectBLFrn();
            this.enregistrer_but = new System.Windows.Forms.Button();
            this.quitter_but = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.calculerPoids_5 = new System.Windows.Forms.Button();
            this.calculerPoids_4 = new System.Windows.Forms.Button();
            this.qte_article_5_tb = new USER_CONTROLS.TNumEditBox();
            this.calculerPoids_3 = new System.Windows.Forms.Button();
            this.desig_article_5_cb = new System.Windows.Forms.ComboBox();
            this.qte_article_4_tb = new USER_CONTROLS.TNumEditBox();
            this.label23 = new System.Windows.Forms.Label();
            this.desig_article_4_cb = new System.Windows.Forms.ComboBox();
            this.num_article_5_cb = new System.Windows.Forms.ComboBox();
            this.calculerPoids_2 = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.qte_article_3_tb = new USER_CONTROLS.TNumEditBox();
            this.num_article_4_cb = new System.Windows.Forms.ComboBox();
            this.desig_article_3_cb = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.calculerPoids_1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.qte_article_2_tb = new USER_CONTROLS.TNumEditBox();
            this.num_article_3_cb = new System.Windows.Forms.ComboBox();
            this.desig_article_2_cb = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.qte_article_1_tb = new USER_CONTROLS.TNumEditBox();
            this.label13 = new System.Windows.Forms.Label();
            this.desig_article_1_cb = new System.Windows.Forms.ComboBox();
            this.num_article_2_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.num_article_1_cb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.switchDBComp1);
            this.groupBox2.Controls.Add(this.nom_frn_cb);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.code_frn_cb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.date_entree_dtp);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(19, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(713, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information Générale BL";
            // 
            // switchDBComp1
            // 
            this.switchDBComp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.switchDBComp1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.switchDBComp1.Location = new System.Drawing.Point(587, 22);
            this.switchDBComp1.Name = "switchDBComp1";
            this.switchDBComp1.Size = new System.Drawing.Size(90, 54);
            this.switchDBComp1.TabIndex = 99;
            this.switchDBComp1.radioStateChanged += new GestionBascule.Presentation.Components.SwitchDBComp.RadioStateChanged(this.switchDBComp1_radioStateChanged);
            // 
            // nom_frn_cb
            // 
            this.nom_frn_cb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_frn_cb.FormattingEnabled = true;
            this.nom_frn_cb.Location = new System.Drawing.Point(246, 65);
            this.nom_frn_cb.Name = "nom_frn_cb";
            this.nom_frn_cb.Size = new System.Drawing.Size(225, 23);
            this.nom_frn_cb.TabIndex = 2;
            this.nom_frn_cb.SelectedIndexChanged += new System.EventHandler(this.nom_cb_SelectedIndexChanged);
            this.nom_frn_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nom_frn_cb_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(20, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "N° BL";
            // 
            // code_frn_cb
            // 
            this.code_frn_cb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_frn_cb.FormattingEnabled = true;
            this.code_frn_cb.Location = new System.Drawing.Point(106, 65);
            this.code_frn_cb.Name = "code_frn_cb";
            this.code_frn_cb.Size = new System.Drawing.Size(127, 23);
            this.code_frn_cb.TabIndex = 1;
            this.code_frn_cb.SelectedIndexChanged += new System.EventHandler(this.code_frn_cb_SelectedIndexChanged);
            this.code_frn_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.code_frn_cb_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(22, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Code frn";
            // 
            // date_entree_dtp
            // 
            this.date_entree_dtp.CustomFormat = "";
            this.date_entree_dtp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_entree_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_entree_dtp.Location = new System.Drawing.Point(310, 33);
            this.date_entree_dtp.Name = "date_entree_dtp";
            this.date_entree_dtp.Size = new System.Drawing.Size(161, 22);
            this.date_entree_dtp.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(249, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Date BL";
            // 
            // selectBLFrn1
            // 
            this.selectBLFrn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.selectBLFrn1.Location = new System.Drawing.Point(125, 53);
            this.selectBLFrn1.Name = "selectBLFrn1";
            this.selectBLFrn1.Size = new System.Drawing.Size(127, 22);
            this.selectBLFrn1.TabIndex = 100;
            this.selectBLFrn1.bLValidated += new GestionBascule.Presentation.Components.SelectBLFrn.EventDelegate(this.selectBLFrn1_bLValidated);
            // 
            // enregistrer_but
            // 
            this.enregistrer_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.enregistrer_but.Image = ((System.Drawing.Image)(resources.GetObject("enregistrer_but.Image")));
            this.enregistrer_but.Location = new System.Drawing.Point(12, 390);
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
            this.quitter_but.Location = new System.Drawing.Point(137, 390);
            this.quitter_but.Name = "quitter_but";
            this.quitter_but.Size = new System.Drawing.Size(107, 33);
            this.quitter_but.TabIndex = 54;
            this.quitter_but.Text = "   Quitter";
            this.quitter_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.quitter_but.UseVisualStyleBackColor = true;
            this.quitter_but.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.BackColor = System.Drawing.SystemColors.Window;
            this.tabControl1.Controls.Add(this.selectBLFrn1);
            this.tabControl1.Controls.Add(this.groupBox4);
            this.tabControl1.Controls.Add(this.groupBox2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(766, 381);
            this.tabControl1.TabIndex = 55;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.calculerPoids_5);
            this.groupBox4.Controls.Add(this.calculerPoids_4);
            this.groupBox4.Controls.Add(this.qte_article_5_tb);
            this.groupBox4.Controls.Add(this.calculerPoids_3);
            this.groupBox4.Controls.Add(this.desig_article_5_cb);
            this.groupBox4.Controls.Add(this.qte_article_4_tb);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.desig_article_4_cb);
            this.groupBox4.Controls.Add(this.num_article_5_cb);
            this.groupBox4.Controls.Add(this.calculerPoids_2);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.qte_article_3_tb);
            this.groupBox4.Controls.Add(this.num_article_4_cb);
            this.groupBox4.Controls.Add(this.desig_article_3_cb);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.calculerPoids_1);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.qte_article_2_tb);
            this.groupBox4.Controls.Add(this.num_article_3_cb);
            this.groupBox4.Controls.Add(this.desig_article_2_cb);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.qte_article_1_tb);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.desig_article_1_cb);
            this.groupBox4.Controls.Add(this.num_article_2_cb);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.num_article_1_cb);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Location = new System.Drawing.Point(19, 132);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(713, 222);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Détails  articles";
            // 
            // calculerPoids_5
            // 
            this.calculerPoids_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculerPoids_5.Image = global::GestionBascule.Properties.Resources.if_Edit;
            this.calculerPoids_5.Location = new System.Drawing.Point(643, 174);
            this.calculerPoids_5.Name = "calculerPoids_5";
            this.calculerPoids_5.Size = new System.Drawing.Size(25, 22);
            this.calculerPoids_5.TabIndex = 58;
            this.calculerPoids_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.calculerPoids_5.UseVisualStyleBackColor = true;
            this.calculerPoids_5.Click += new System.EventHandler(this.calculerPoids_5_Click);
            // 
            // calculerPoids_4
            // 
            this.calculerPoids_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculerPoids_4.Image = global::GestionBascule.Properties.Resources.if_Edit;
            this.calculerPoids_4.Location = new System.Drawing.Point(643, 138);
            this.calculerPoids_4.Name = "calculerPoids_4";
            this.calculerPoids_4.Size = new System.Drawing.Size(25, 22);
            this.calculerPoids_4.TabIndex = 58;
            this.calculerPoids_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.calculerPoids_4.UseVisualStyleBackColor = true;
            this.calculerPoids_4.Click += new System.EventHandler(this.calculerPoids_4_Click);
            // 
            // qte_article_5_tb
            // 
            this.qte_article_5_tb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qte_article_5_tb.Location = new System.Drawing.Point(534, 174);
            this.qte_article_5_tb.Name = "qte_article_5_tb";
            this.qte_article_5_tb.Size = new System.Drawing.Size(87, 22);
            this.qte_article_5_tb.TabIndex = 3;
            // 
            // calculerPoids_3
            // 
            this.calculerPoids_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculerPoids_3.Image = global::GestionBascule.Properties.Resources.if_Edit;
            this.calculerPoids_3.Location = new System.Drawing.Point(643, 102);
            this.calculerPoids_3.Name = "calculerPoids_3";
            this.calculerPoids_3.Size = new System.Drawing.Size(25, 22);
            this.calculerPoids_3.TabIndex = 58;
            this.calculerPoids_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.calculerPoids_3.UseVisualStyleBackColor = true;
            this.calculerPoids_3.Click += new System.EventHandler(this.calculerPoids_3_Click);
            // 
            // desig_article_5_cb
            // 
            this.desig_article_5_cb.Font = new System.Drawing.Font("Candara", 9.75F);
            this.desig_article_5_cb.FormattingEnabled = true;
            this.desig_article_5_cb.Location = new System.Drawing.Point(246, 174);
            this.desig_article_5_cb.Name = "desig_article_5_cb";
            this.desig_article_5_cb.Size = new System.Drawing.Size(225, 23);
            this.desig_article_5_cb.TabIndex = 2;
            this.desig_article_5_cb.SelectedIndexChanged += new System.EventHandler(this.desig_article_5_cb_SelectedIndexChanged);
            this.desig_article_5_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.desig_article_5_cb_KeyUp);
            // 
            // qte_article_4_tb
            // 
            this.qte_article_4_tb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qte_article_4_tb.Location = new System.Drawing.Point(534, 138);
            this.qte_article_4_tb.Name = "qte_article_4_tb";
            this.qte_article_4_tb.Size = new System.Drawing.Size(87, 22);
            this.qte_article_4_tb.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(492, 178);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(28, 15);
            this.label23.TabIndex = 11;
            this.label23.Text = "Qte";
            // 
            // desig_article_4_cb
            // 
            this.desig_article_4_cb.Font = new System.Drawing.Font("Candara", 9.75F);
            this.desig_article_4_cb.FormattingEnabled = true;
            this.desig_article_4_cb.Location = new System.Drawing.Point(246, 138);
            this.desig_article_4_cb.Name = "desig_article_4_cb";
            this.desig_article_4_cb.Size = new System.Drawing.Size(225, 23);
            this.desig_article_4_cb.TabIndex = 2;
            this.desig_article_4_cb.SelectedIndexChanged += new System.EventHandler(this.desig_article_4_cb_SelectedIndexChanged);
            this.desig_article_4_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.desig_article_4_cb_KeyUp);
            // 
            // num_article_5_cb
            // 
            this.num_article_5_cb.Font = new System.Drawing.Font("Candara", 9.75F);
            this.num_article_5_cb.FormattingEnabled = true;
            this.num_article_5_cb.Location = new System.Drawing.Point(106, 174);
            this.num_article_5_cb.Name = "num_article_5_cb";
            this.num_article_5_cb.Size = new System.Drawing.Size(127, 23);
            this.num_article_5_cb.TabIndex = 1;
            this.num_article_5_cb.SelectedIndexChanged += new System.EventHandler(this.num_article_5_cb_SelectedIndexChanged);
            this.num_article_5_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.num_article_5_cb_KeyUp);
            // 
            // calculerPoids_2
            // 
            this.calculerPoids_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculerPoids_2.Image = global::GestionBascule.Properties.Resources.if_Edit;
            this.calculerPoids_2.Location = new System.Drawing.Point(643, 66);
            this.calculerPoids_2.Name = "calculerPoids_2";
            this.calculerPoids_2.Size = new System.Drawing.Size(25, 22);
            this.calculerPoids_2.TabIndex = 58;
            this.calculerPoids_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.calculerPoids_2.UseVisualStyleBackColor = true;
            this.calculerPoids_2.Click += new System.EventHandler(this.calculerPoids_2_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(21, 178);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 15);
            this.label25.TabIndex = 0;
            this.label25.Text = "Article 5";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(492, 142);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 15);
            this.label20.TabIndex = 11;
            this.label20.Text = "Qte";
            // 
            // qte_article_3_tb
            // 
            this.qte_article_3_tb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qte_article_3_tb.Location = new System.Drawing.Point(534, 102);
            this.qte_article_3_tb.Name = "qte_article_3_tb";
            this.qte_article_3_tb.Size = new System.Drawing.Size(87, 22);
            this.qte_article_3_tb.TabIndex = 3;
            // 
            // num_article_4_cb
            // 
            this.num_article_4_cb.Font = new System.Drawing.Font("Candara", 9.75F);
            this.num_article_4_cb.FormattingEnabled = true;
            this.num_article_4_cb.Location = new System.Drawing.Point(106, 138);
            this.num_article_4_cb.Name = "num_article_4_cb";
            this.num_article_4_cb.Size = new System.Drawing.Size(127, 23);
            this.num_article_4_cb.TabIndex = 1;
            this.num_article_4_cb.SelectedIndexChanged += new System.EventHandler(this.num_article_4_cb_SelectedIndexChanged);
            this.num_article_4_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.num_article_4_cb_KeyUp);
            // 
            // desig_article_3_cb
            // 
            this.desig_article_3_cb.Font = new System.Drawing.Font("Candara", 9.75F);
            this.desig_article_3_cb.FormattingEnabled = true;
            this.desig_article_3_cb.Location = new System.Drawing.Point(246, 102);
            this.desig_article_3_cb.Name = "desig_article_3_cb";
            this.desig_article_3_cb.Size = new System.Drawing.Size(225, 23);
            this.desig_article_3_cb.TabIndex = 2;
            this.desig_article_3_cb.SelectedIndexChanged += new System.EventHandler(this.desig_article_3_cb_SelectedIndexChanged);
            this.desig_article_3_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.desig_article_3_cb_KeyUp);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(22, 142);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 15);
            this.label22.TabIndex = 0;
            this.label22.Text = "Article 4";
            // 
            // calculerPoids_1
            // 
            this.calculerPoids_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculerPoids_1.Image = global::GestionBascule.Properties.Resources.if_Edit;
            this.calculerPoids_1.Location = new System.Drawing.Point(643, 29);
            this.calculerPoids_1.Name = "calculerPoids_1";
            this.calculerPoids_1.Size = new System.Drawing.Size(25, 22);
            this.calculerPoids_1.TabIndex = 57;
            this.calculerPoids_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.calculerPoids_1.UseVisualStyleBackColor = true;
            this.calculerPoids_1.Click += new System.EventHandler(this.calculerPoids_1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(492, 106);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 15);
            this.label17.TabIndex = 11;
            this.label17.Text = "Qte";
            // 
            // qte_article_2_tb
            // 
            this.qte_article_2_tb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qte_article_2_tb.Location = new System.Drawing.Point(534, 66);
            this.qte_article_2_tb.Name = "qte_article_2_tb";
            this.qte_article_2_tb.Size = new System.Drawing.Size(87, 22);
            this.qte_article_2_tb.TabIndex = 3;
            // 
            // num_article_3_cb
            // 
            this.num_article_3_cb.Font = new System.Drawing.Font("Candara", 9.75F);
            this.num_article_3_cb.FormattingEnabled = true;
            this.num_article_3_cb.Location = new System.Drawing.Point(106, 102);
            this.num_article_3_cb.Name = "num_article_3_cb";
            this.num_article_3_cb.Size = new System.Drawing.Size(127, 23);
            this.num_article_3_cb.TabIndex = 1;
            this.num_article_3_cb.SelectedIndexChanged += new System.EventHandler(this.num_article_3_cb_SelectedIndexChanged);
            this.num_article_3_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.num_article_3_cb_KeyUp);
            // 
            // desig_article_2_cb
            // 
            this.desig_article_2_cb.Font = new System.Drawing.Font("Candara", 9.75F);
            this.desig_article_2_cb.FormattingEnabled = true;
            this.desig_article_2_cb.Location = new System.Drawing.Point(246, 66);
            this.desig_article_2_cb.Name = "desig_article_2_cb";
            this.desig_article_2_cb.Size = new System.Drawing.Size(225, 23);
            this.desig_article_2_cb.TabIndex = 2;
            this.desig_article_2_cb.SelectedIndexChanged += new System.EventHandler(this.desig_article_2_cb_SelectedIndexChanged);
            this.desig_article_2_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.desig_article_2_cb_KeyUp);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(22, 106);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 15);
            this.label19.TabIndex = 0;
            this.label19.Text = "Article 3";
            // 
            // qte_article_1_tb
            // 
            this.qte_article_1_tb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qte_article_1_tb.Location = new System.Drawing.Point(534, 29);
            this.qte_article_1_tb.Name = "qte_article_1_tb";
            this.qte_article_1_tb.Size = new System.Drawing.Size(87, 22);
            this.qte_article_1_tb.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(492, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "Qte";
            // 
            // desig_article_1_cb
            // 
            this.desig_article_1_cb.Font = new System.Drawing.Font("Candara", 9.75F);
            this.desig_article_1_cb.FormattingEnabled = true;
            this.desig_article_1_cb.Location = new System.Drawing.Point(246, 29);
            this.desig_article_1_cb.Name = "desig_article_1_cb";
            this.desig_article_1_cb.Size = new System.Drawing.Size(225, 23);
            this.desig_article_1_cb.TabIndex = 2;
            this.desig_article_1_cb.SelectedIndexChanged += new System.EventHandler(this.desig_article_1_cb_SelectedIndexChanged);
            this.desig_article_1_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.desig_article_1_cb_KeyUp);
            // 
            // num_article_2_cb
            // 
            this.num_article_2_cb.Font = new System.Drawing.Font("Candara", 9.75F);
            this.num_article_2_cb.FormattingEnabled = true;
            this.num_article_2_cb.Location = new System.Drawing.Point(106, 66);
            this.num_article_2_cb.Name = "num_article_2_cb";
            this.num_article_2_cb.Size = new System.Drawing.Size(127, 23);
            this.num_article_2_cb.TabIndex = 1;
            this.num_article_2_cb.SelectedIndexChanged += new System.EventHandler(this.num_article_2_cb_SelectedIndexChanged);
            this.num_article_2_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.num_article_2_cb_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(492, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Qte";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(22, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "Article 2";
            // 
            // num_article_1_cb
            // 
            this.num_article_1_cb.Font = new System.Drawing.Font("Candara", 9.75F);
            this.num_article_1_cb.FormattingEnabled = true;
            this.num_article_1_cb.Location = new System.Drawing.Point(106, 29);
            this.num_article_1_cb.Name = "num_article_1_cb";
            this.num_article_1_cb.Size = new System.Drawing.Size(127, 23);
            this.num_article_1_cb.TabIndex = 1;
            this.num_article_1_cb.SelectedIndexChanged += new System.EventHandler(this.num_article_1_cb_SelectedIndexChanged);
            this.num_article_1_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.num_article_1_cb_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(22, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Article 1";
            // 
            // LineFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(767, 432);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.quitter_but);
            this.Controls.Add(this.enregistrer_but);
            this.Name = "LineFournisseur";
            this.Text = "Bon livraison fournisseur";
            this.Load += new System.EventHandler(this.Pesage1Entree_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker date_entree_dtp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox code_frn_cb;
        private System.Windows.Forms.ComboBox nom_frn_cb;
        private System.Windows.Forms.Button enregistrer_but;
        private System.Windows.Forms.Button quitter_but;
        private System.Windows.Forms.Panel tabControl1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button calculerPoids_5;
        private System.Windows.Forms.Button calculerPoids_4;
        private USER_CONTROLS.TNumEditBox qte_article_5_tb;
        private System.Windows.Forms.Button calculerPoids_3;
        private System.Windows.Forms.ComboBox desig_article_5_cb;
        private USER_CONTROLS.TNumEditBox qte_article_4_tb;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox desig_article_4_cb;
        private System.Windows.Forms.ComboBox num_article_5_cb;
        private System.Windows.Forms.Button calculerPoids_2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label20;
        private USER_CONTROLS.TNumEditBox qte_article_3_tb;
        private System.Windows.Forms.ComboBox num_article_4_cb;
        private System.Windows.Forms.ComboBox desig_article_3_cb;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button calculerPoids_1;
        private System.Windows.Forms.Label label17;
        private USER_CONTROLS.TNumEditBox qte_article_2_tb;
        private System.Windows.Forms.ComboBox num_article_3_cb;
        private System.Windows.Forms.ComboBox desig_article_2_cb;
        private System.Windows.Forms.Label label19;
        private USER_CONTROLS.TNumEditBox qte_article_1_tb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox desig_article_1_cb;
        private System.Windows.Forms.ComboBox num_article_2_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox num_article_1_cb;
        private System.Windows.Forms.Label label8;
        private Presentation.Components.SwitchDBComp switchDBComp1;
        private Presentation.Components.SelectBLFrn selectBLFrn1;
    }
}
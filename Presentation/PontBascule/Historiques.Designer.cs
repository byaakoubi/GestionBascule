namespace GestionBascule
{
    partial class Historiques
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historiques));
            this.STOCK_DGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.produit_cb = new USER_CONTROLS.MaskedTextBox();
            this.date_cb = new System.Windows.Forms.ComboBox();
            this.DataGridView_Header = new System.Windows.Forms.DataGridView();
            this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NBL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operation_tb = new USER_CONTROLS.MaskedTextBox();
            this.NBL_tb = new USER_CONTROLS.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.quitter_but = new System.Windows.Forms.Button();
            this.supprimer_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.STOCK_DGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Header)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // STOCK_DGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.STOCK_DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.STOCK_DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.STOCK_DGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.STOCK_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.STOCK_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.STOCK_DGV.GridColor = System.Drawing.Color.White;
            this.STOCK_DGV.Location = new System.Drawing.Point(0, 72);
            this.STOCK_DGV.Name = "STOCK_DGV";
            this.STOCK_DGV.Size = new System.Drawing.Size(1276, 578);
            this.STOCK_DGV.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.produit_cb);
            this.panel1.Controls.Add(this.date_cb);
            this.panel1.Controls.Add(this.DataGridView_Header);
            this.panel1.Controls.Add(this.operation_tb);
            this.panel1.Controls.Add(this.NBL_tb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 73);
            this.panel1.TabIndex = 1;
            // 
            // produit_cb
            // 
            this.produit_cb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.produit_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produit_cb.Location = new System.Drawing.Point(357, 31);
            this.produit_cb.Masked = USER_CONTROLS.Mask.None;
            this.produit_cb.Name = "produit_cb";
            this.produit_cb.Size = new System.Drawing.Size(100, 21);
            this.produit_cb.TabIndex = 62;
            this.produit_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.produit_cb_KeyUp);
            // 
            // date_cb
            // 
            this.date_cb.DropDownWidth = 100;
            this.date_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_cb.FormattingEnabled = true;
            this.date_cb.IntegralHeight = false;
            this.date_cb.Items.AddRange(new object[] {
            "Tous",
            "Dp 1 jour",
            "Dp 1 semaine",
            "Dp 1 mois",
            "Dp 1 ans"});
            this.date_cb.Location = new System.Drawing.Point(257, 31);
            this.date_cb.Name = "date_cb";
            this.date_cb.Size = new System.Drawing.Size(100, 21);
            this.date_cb.TabIndex = 61;
            this.date_cb.SelectedIndexChanged += new System.EventHandler(this.date_cb_SelectedIndexChanged);
            // 
            // DataGridView_Header
            // 
            this.DataGridView_Header.AllowUserToResizeColumns = false;
            this.DataGridView_Header.AllowUserToResizeRows = false;
            this.DataGridView_Header.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridView_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView_Header.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridView_Header.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Header.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_Header.ColumnHeadersHeight = 20;
            this.DataGridView_Header.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Operation,
            this.NBL,
            this.date,
            this.nom_produit});
            this.DataGridView_Header.Location = new System.Drawing.Point(57, 11);
            this.DataGridView_Header.Name = "DataGridView_Header";
            this.DataGridView_Header.RowHeadersVisible = false;
            this.DataGridView_Header.Size = new System.Drawing.Size(401, 20);
            this.DataGridView_Header.TabIndex = 57;
            // 
            // Operation
            // 
            this.Operation.HeaderText = "Opération";
            this.Operation.Name = "Operation";
            // 
            // NBL
            // 
            this.NBL.HeaderText = "NBL";
            this.NBL.Name = "NBL";
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nom_produit
            // 
            this.nom_produit.HeaderText = "Produit";
            this.nom_produit.Name = "nom_produit";
            // 
            // operation_tb
            // 
            this.operation_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.operation_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operation_tb.Location = new System.Drawing.Point(57, 31);
            this.operation_tb.Masked = USER_CONTROLS.Mask.None;
            this.operation_tb.Name = "operation_tb";
            this.operation_tb.Size = new System.Drawing.Size(100, 21);
            this.operation_tb.TabIndex = 1;
            // 
            // NBL_tb
            // 
            this.NBL_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NBL_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NBL_tb.Location = new System.Drawing.Point(157, 31);
            this.NBL_tb.Masked = USER_CONTROLS.Mask.None;
            this.NBL_tb.Name = "NBL_tb";
            this.NBL_tb.Size = new System.Drawing.Size(100, 21);
            this.NBL_tb.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.quitter_but);
            this.panel2.Controls.Add(this.supprimer_but);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 652);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1276, 98);
            this.panel2.TabIndex = 30;
            // 
            // quitter_but
            // 
            this.quitter_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.quitter_but.Image = ((System.Drawing.Image)(resources.GetObject("quitter_but.Image")));
            this.quitter_but.Location = new System.Drawing.Point(143, 25);
            this.quitter_but.Name = "quitter_but";
            this.quitter_but.Size = new System.Drawing.Size(107, 33);
            this.quitter_but.TabIndex = 66;
            this.quitter_but.Text = "   Quitter";
            this.quitter_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.quitter_but.UseVisualStyleBackColor = true;
            this.quitter_but.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // supprimer_but
            // 
            this.supprimer_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.supprimer_but.Image = ((System.Drawing.Image)(resources.GetObject("supprimer_but.Image")));
            this.supprimer_but.Location = new System.Drawing.Point(12, 25);
            this.supprimer_but.Name = "supprimer_but";
            this.supprimer_but.Size = new System.Drawing.Size(107, 33);
            this.supprimer_but.TabIndex = 65;
            this.supprimer_but.Text = "   Supprimer";
            this.supprimer_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.supprimer_but.UseVisualStyleBackColor = true;
            this.supprimer_but.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // Historiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1276, 750);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.STOCK_DGV);
            this.Name = "Historiques";
            this.Text = "Suivie_Stock";
            this.Activated += new System.EventHandler(this.Suivie_Stock_Activated);
            this.Load += new System.EventHandler(this.Suivie_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.STOCK_DGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Header)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView STOCK_DGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DataGridView_Header;
        private USER_CONTROLS.MaskedTextBox operation_tb;
        private USER_CONTROLS.MaskedTextBox NBL_tb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox date_cb;
        private USER_CONTROLS.MaskedTextBox produit_cb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn NBL;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_produit;
        private System.Windows.Forms.Button quitter_but;
        private System.Windows.Forms.Button supprimer_but;
    }
}
namespace GestionBascule
{
    partial class GetPoids
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
            this.unite_cb = new System.Windows.Forms.ComboBox();
            this.qte_tb = new USER_CONTROLS.TNumEditBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.poids_tb = new USER_CONTROLS.TNumEditBox();
            this.label3 = new System.Windows.Forms.Label();
            this.annuler_but = new System.Windows.Forms.Button();
            this.valider_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unite_cb
            // 
            this.unite_cb.FormattingEnabled = true;
            this.unite_cb.Items.AddRange(new object[] {
            "Sac 10 Kg",
            "Sac 20 Kg",
            "Sac 30 Kg",
            "Sac 40 Kg",
            "Sac 50 Kg",
            "Sac 100 Kg",
            "Tonne 1000 Kg"});
            this.unite_cb.Location = new System.Drawing.Point(21, 47);
            this.unite_cb.Name = "unite_cb";
            this.unite_cb.Size = new System.Drawing.Size(121, 21);
            this.unite_cb.TabIndex = 1;
            this.unite_cb.SelectedIndexChanged += new System.EventHandler(this.unite_cb_SelectedIndexChanged);
            // 
            // qte_tb
            // 
            this.qte_tb.Location = new System.Drawing.Point(164, 47);
            this.qte_tb.Name = "qte_tb";
            this.qte_tb.Size = new System.Drawing.Size(45, 20);
            this.qte_tb.TabIndex = 2;
            this.qte_tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.qte_tb_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selectionner unité";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Qte";
            // 
            // poids_tb
            // 
            this.poids_tb.Location = new System.Drawing.Point(21, 116);
            this.poids_tb.Name = "poids_tb";
            this.poids_tb.ReadOnly = true;
            this.poids_tb.Size = new System.Drawing.Size(121, 20);
            this.poids_tb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Poids calculé";
            // 
            // annuler_but
            // 
            this.annuler_but.Image = global::GestionBascule.Properties.Resources.if_Delete;
            this.annuler_but.Location = new System.Drawing.Point(152, 167);
            this.annuler_but.Name = "annuler_but";
            this.annuler_but.Size = new System.Drawing.Size(107, 33);
            this.annuler_but.TabIndex = 56;
            this.annuler_but.Text = "   Annuler";
            this.annuler_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.annuler_but.UseVisualStyleBackColor = true;
            // 
            // valider_but
            // 
            this.valider_but.Image = global::GestionBascule.Properties.Resources.if_Accept;
            this.valider_but.Location = new System.Drawing.Point(21, 167);
            this.valider_but.Name = "valider_but";
            this.valider_but.Size = new System.Drawing.Size(107, 33);
            this.valider_but.TabIndex = 55;
            this.valider_but.Text = "   Valider";
            this.valider_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.valider_but.UseVisualStyleBackColor = true;
            this.valider_but.Click += new System.EventHandler(this.valider_but_Click);
            // 
            // GetPoids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(374, 212);
            this.ControlBox = false;
            this.Controls.Add(this.annuler_but);
            this.Controls.Add(this.valider_but);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.poids_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qte_tb);
            this.Controls.Add(this.unite_cb);
            this.Name = "GetPoids";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox unite_cb;
        private USER_CONTROLS.TNumEditBox qte_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private USER_CONTROLS.TNumEditBox poids_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button annuler_but;
        private System.Windows.Forms.Button valider_but;
    }
}
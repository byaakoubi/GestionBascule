namespace GestionBascule
{
    partial class ConfigBascule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigBascule));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.setupTabPage = new System.Windows.Forms.TabPage();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.virtualTabPage = new System.Windows.Forms.TabPage();
            this.propertyGrid2 = new System.Windows.Forms.PropertyGrid();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enum_but = new System.Windows.Forms.Button();
            this.connect_but = new System.Windows.Forms.Button();
            this.connect_vir_but = new System.Windows.Forms.Button();
            this.send_but = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.setupTabPage.SuspendLayout();
            this.virtualTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.setupTabPage);
            this.tabControl1.Controls.Add(this.virtualTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(670, 373);
            this.tabControl1.TabIndex = 1;
            // 
            // setupTabPage
            // 
            this.setupTabPage.Controls.Add(this.connect_but);
            this.setupTabPage.Controls.Add(this.enum_but);
            this.setupTabPage.Controls.Add(this.propertyGrid1);
            this.setupTabPage.Location = new System.Drawing.Point(4, 22);
            this.setupTabPage.Name = "setupTabPage";
            this.setupTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.setupTabPage.Size = new System.Drawing.Size(662, 347);
            this.setupTabPage.TabIndex = 1;
            this.setupTabPage.Text = "Setup";
            this.setupTabPage.UseVisualStyleBackColor = true;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyGrid1.LineColor = System.Drawing.SystemColors.ControlDark;
            this.propertyGrid1.Location = new System.Drawing.Point(10, 71);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(652, 268);
            this.propertyGrid1.TabIndex = 4;
            // 
            // virtualTabPage
            // 
            this.virtualTabPage.Controls.Add(this.connect_vir_but);
            this.virtualTabPage.Controls.Add(this.send_but);
            this.virtualTabPage.Controls.Add(this.propertyGrid2);
            this.virtualTabPage.Location = new System.Drawing.Point(4, 22);
            this.virtualTabPage.Name = "virtualTabPage";
            this.virtualTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.virtualTabPage.Size = new System.Drawing.Size(662, 347);
            this.virtualTabPage.TabIndex = 3;
            this.virtualTabPage.Text = "Simulation";
            this.virtualTabPage.UseVisualStyleBackColor = true;
            // 
            // propertyGrid2
            // 
            this.propertyGrid2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyGrid2.LineColor = System.Drawing.SystemColors.ControlDark;
            this.propertyGrid2.Location = new System.Drawing.Point(10, 71);
            this.propertyGrid2.Name = "propertyGrid2";
            this.propertyGrid2.Size = new System.Drawing.Size(652, 268);
            this.propertyGrid2.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Poids Entré";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // enum_but
            // 
            this.enum_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.enum_but.Image = ((System.Drawing.Image)(resources.GetObject("enum_but.Image")));
            this.enum_but.Location = new System.Drawing.Point(135, 17);
            this.enum_but.Name = "enum_but";
            this.enum_but.Size = new System.Drawing.Size(107, 33);
            this.enum_but.TabIndex = 95;
            this.enum_but.Text = "   Enum. Ports";
            this.enum_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.enum_but.UseVisualStyleBackColor = true;
            this.enum_but.Click += new System.EventHandler(this.EnumerateComPorts_Click);
            // 
            // connect_but
            // 
            this.connect_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.connect_but.Image = ((System.Drawing.Image)(resources.GetObject("connect_but.Image")));
            this.connect_but.Location = new System.Drawing.Point(10, 17);
            this.connect_but.Name = "connect_but";
            this.connect_but.Size = new System.Drawing.Size(107, 33);
            this.connect_but.TabIndex = 96;
            this.connect_but.Text = "   Connect";
            this.connect_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.connect_but.UseVisualStyleBackColor = true;
            this.connect_but.Click += new System.EventHandler(this.Connect_Click);
            // 
            // connect_vir_but
            // 
            this.connect_vir_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.connect_vir_but.Image = ((System.Drawing.Image)(resources.GetObject("connect_vir_but.Image")));
            this.connect_vir_but.Location = new System.Drawing.Point(10, 17);
            this.connect_vir_but.Name = "connect_vir_but";
            this.connect_vir_but.Size = new System.Drawing.Size(107, 33);
            this.connect_vir_but.TabIndex = 98;
            this.connect_vir_but.Text = "   Connect Vir";
            this.connect_vir_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.connect_vir_but.UseVisualStyleBackColor = true;
            this.connect_vir_but.Click += new System.EventHandler(this.Connect_Vir_Com_handler);
            // 
            // send_but
            // 
            this.send_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.send_but.Image = ((System.Drawing.Image)(resources.GetObject("send_but.Image")));
            this.send_but.Location = new System.Drawing.Point(135, 17);
            this.send_but.Name = "send_but";
            this.send_but.Size = new System.Drawing.Size(107, 33);
            this.send_but.TabIndex = 97;
            this.send_but.Text = "   Send Weight";
            this.send_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.send_but.UseVisualStyleBackColor = true;
            this.send_but.Click += new System.EventHandler(this.Send_Poids_Click);
            // 
            // ConfigBascule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(670, 373);
            this.Controls.Add(this.tabControl1);
            this.Name = "ConfigBascule";
            this.Text = "Setup Bascule";
            this.tabControl1.ResumeLayout(false);
            this.setupTabPage.ResumeLayout(false);
            this.virtualTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage setupTabPage;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TabPage virtualTabPage;
        private System.Windows.Forms.PropertyGrid propertyGrid2;
        private System.Windows.Forms.Button connect_but;
        private System.Windows.Forms.Button enum_but;
        private System.Windows.Forms.Button connect_vir_but;
        private System.Windows.Forms.Button send_but;
	}
}


using System.Windows.Forms;
namespace GestionBascule.Presentation.Components
{
    partial class SwitchDBComp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.switchSomepaDB_rb = new System.Windows.Forms.RadioButton();
            this.switchNewDB_rb = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // switchSomepaDB_rb
            // 
            this.switchSomepaDB_rb.AutoSize = true;
            this.switchSomepaDB_rb.Checked = true;
            this.switchSomepaDB_rb.Location = new System.Drawing.Point(7, 6);
            this.switchSomepaDB_rb.Name = "switchSomepaDB_rb";
            this.switchSomepaDB_rb.Size = new System.Drawing.Size(82, 17);
            this.switchSomepaDB_rb.TabIndex = 7;
            this.switchSomepaDB_rb.TabStop = true;
            this.switchSomepaDB_rb.Text = "Somepa DB";
            this.switchSomepaDB_rb.UseVisualStyleBackColor = true;
            this.switchSomepaDB_rb.CheckedChanged += new System.EventHandler(this.switchSomepaDB_rb_CheckedChanged);
            // 
            // switchNewDB_rb
            // 
            this.switchNewDB_rb.AutoSize = true;
            this.switchNewDB_rb.Location = new System.Drawing.Point(7, 33);
            this.switchNewDB_rb.Name = "switchNewDB_rb";
            this.switchNewDB_rb.Size = new System.Drawing.Size(65, 17);
            this.switchNewDB_rb.TabIndex = 8;
            this.switchNewDB_rb.Text = "New DB";
            this.switchNewDB_rb.UseVisualStyleBackColor = true;
            this.switchNewDB_rb.CheckedChanged += new System.EventHandler(this.switchNewDB_rb_CheckedChanged);
            // 
            // SwitchDBComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.switchSomepaDB_rb);
            this.Controls.Add(this.switchNewDB_rb);
            this.Name = "SwitchDBComp";
            this.Size = new System.Drawing.Size(90, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public RadioButton switchSomepaDB_rb;
        public RadioButton switchNewDB_rb;

    }
}

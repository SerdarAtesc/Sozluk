namespace Sozluk
{
    partial class Hatirlatma
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.sorulbl = new MetroFramework.Controls.MetroLabel();
            this.btniki = new MetroFramework.Controls.MetroButton();
            this.btnbir = new MetroFramework.Controls.MetroButton();
            this.btnuc = new MetroFramework.Controls.MetroButton();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.ssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(152, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Kelime";
            // 
            // sorulbl
            // 
            this.sorulbl.AutoSize = true;
            this.sorulbl.Location = new System.Drawing.Point(304, 84);
            this.sorulbl.Name = "sorulbl";
            this.sorulbl.Size = new System.Drawing.Size(0, 0);
            this.sorulbl.TabIndex = 0;
            // 
            // btniki
            // 
            this.btniki.Location = new System.Drawing.Point(267, 156);
            this.btniki.Name = "btniki";
            this.btniki.Size = new System.Drawing.Size(75, 23);
            this.btniki.TabIndex = 1;
            this.btniki.Text = "metroButton1";
            this.btniki.UseSelectable = true;
            this.btniki.Click += new System.EventHandler(this.btniki_Click);
            // 
            // btnbir
            // 
            this.btnbir.Location = new System.Drawing.Point(152, 156);
            this.btnbir.Name = "btnbir";
            this.btnbir.Size = new System.Drawing.Size(75, 23);
            this.btnbir.TabIndex = 2;
            this.btnbir.Text = "metroButton2";
            this.btnbir.UseSelectable = true;
            this.btnbir.Click += new System.EventHandler(this.btnbir_Click);
            // 
            // btnuc
            // 
            this.btnuc.Location = new System.Drawing.Point(385, 156);
            this.btnuc.Name = "btnuc";
            this.btnuc.Size = new System.Drawing.Size(75, 23);
            this.btnuc.TabIndex = 3;
            this.btnuc.Text = "metroButton1";
            this.btnuc.UseSelectable = true;
            this.btnuc.Click += new System.EventHandler(this.btnuc_Click);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(85, 26);
            // 
            // ssToolStripMenuItem
            // 
            this.ssToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssToolStripMenuItem1});
            this.ssToolStripMenuItem.Name = "ssToolStripMenuItem";
            this.ssToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.ssToolStripMenuItem.Text = "ss";
            // 
            // ssToolStripMenuItem1
            // 
            this.ssToolStripMenuItem1.Name = "ssToolStripMenuItem1";
            this.ssToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ssToolStripMenuItem1.Text = "ss";
            // 
            // Hatirlatma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 269);
            this.Controls.Add(this.btnuc);
            this.Controls.Add(this.btnbir);
            this.Controls.Add(this.btniki);
            this.Controls.Add(this.sorulbl);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Hatirlatma";
            this.Text = "Hatirlatma";
            this.Load += new System.EventHandler(this.Hatirlatma_Load);
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel sorulbl;
        private MetroFramework.Controls.MetroButton btniki;
        private MetroFramework.Controls.MetroButton btnbir;
        private MetroFramework.Controls.MetroButton btnuc;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem ssToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ssToolStripMenuItem1;
    }
}
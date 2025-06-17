namespace LineasCicunferencias
{
    partial class FrmHome
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
            mnStrp = new MenuStrip();
            dDAToolStripMenuItem = new ToolStripMenuItem();
            bresenhamToolStripMenuItem = new ToolStripMenuItem();
            bresenhamCircunferenciaToolStripMenuItem = new ToolStripMenuItem();
            rellenoInundaciónToolStripMenuItem = new ToolStripMenuItem();
            mnStrp.SuspendLayout();
            SuspendLayout();
            // 
            // mnStrp
            // 
            mnStrp.BackColor = Color.FromArgb(0, 100, 180);
            mnStrp.Dock = DockStyle.Left;
            mnStrp.Font = new Font("Yu Gothic UI", 12F);
            mnStrp.ImageScalingSize = new Size(20, 20);
            mnStrp.Items.AddRange(new ToolStripItem[] { dDAToolStripMenuItem, bresenhamToolStripMenuItem, bresenhamCircunferenciaToolStripMenuItem, rellenoInundaciónToolStripMenuItem });
            mnStrp.Location = new Point(0, 0);
            mnStrp.Name = "mnStrp";
            mnStrp.Size = new Size(255, 659);
            mnStrp.TabIndex = 1;
            mnStrp.Text = "menuStrip1";
            // 
            // dDAToolStripMenuItem
            // 
            dDAToolStripMenuItem.BackColor = Color.FromArgb(0, 100, 180);
            dDAToolStripMenuItem.Font = new Font("Yu Gothic UI", 12F);
            dDAToolStripMenuItem.Margin = new Padding(0, 10, 0, 10);
            dDAToolStripMenuItem.Name = "dDAToolStripMenuItem";
            dDAToolStripMenuItem.Padding = new Padding(5, 10, 5, 10);
            dDAToolStripMenuItem.Size = new Size(242, 52);
            dDAToolStripMenuItem.Text = "DDA";
            dDAToolStripMenuItem.Click += dDAToolStripMenuItem_Click;
            dDAToolStripMenuItem.MouseLeave += dDAToolStripMenuItem_MouseLeave;
            dDAToolStripMenuItem.MouseHover += dDAToolStripMenuItem_MouseHover;
            // 
            // bresenhamToolStripMenuItem
            // 
            bresenhamToolStripMenuItem.BackColor = Color.FromArgb(0, 100, 180);
            bresenhamToolStripMenuItem.Font = new Font("Yu Gothic UI", 12F);
            bresenhamToolStripMenuItem.Margin = new Padding(0, 10, 0, 10);
            bresenhamToolStripMenuItem.Name = "bresenhamToolStripMenuItem";
            bresenhamToolStripMenuItem.Padding = new Padding(5, 10, 5, 10);
            bresenhamToolStripMenuItem.Size = new Size(242, 52);
            bresenhamToolStripMenuItem.Text = "Bresenham";
            bresenhamToolStripMenuItem.Click += bresenhamToolStripMenuItem_Click;
            // 
            // bresenhamCircunferenciaToolStripMenuItem
            // 
            bresenhamCircunferenciaToolStripMenuItem.BackColor = Color.FromArgb(0, 100, 180);
            bresenhamCircunferenciaToolStripMenuItem.Font = new Font("Yu Gothic UI", 12F);
            bresenhamCircunferenciaToolStripMenuItem.Margin = new Padding(0, 10, 0, 10);
            bresenhamCircunferenciaToolStripMenuItem.Name = "bresenhamCircunferenciaToolStripMenuItem";
            bresenhamCircunferenciaToolStripMenuItem.Padding = new Padding(5, 10, 5, 10);
            bresenhamCircunferenciaToolStripMenuItem.Size = new Size(242, 52);
            bresenhamCircunferenciaToolStripMenuItem.Text = "Bresenham Circunferencia";
            bresenhamCircunferenciaToolStripMenuItem.Click += bresenhamCircunferenciaToolStripMenuItem_Click;
            // 
            // rellenoInundaciónToolStripMenuItem
            // 
            rellenoInundaciónToolStripMenuItem.BackColor = Color.FromArgb(0, 100, 180);
            rellenoInundaciónToolStripMenuItem.Font = new Font("Yu Gothic UI", 12F);
            rellenoInundaciónToolStripMenuItem.Margin = new Padding(0, 10, 0, 10);
            rellenoInundaciónToolStripMenuItem.Name = "rellenoInundaciónToolStripMenuItem";
            rellenoInundaciónToolStripMenuItem.Padding = new Padding(5, 10, 5, 10);
            rellenoInundaciónToolStripMenuItem.Size = new Size(242, 52);
            rellenoInundaciónToolStripMenuItem.Text = "Relleno Inundación";
            rellenoInundaciónToolStripMenuItem.Click += rellenoInundaciónToolStripMenuItem_Click;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 659);
            Controls.Add(mnStrp);
            IsMdiContainer = true;
            MainMenuStrip = mnStrp;
            Name = "FrmHome";
            Text = "FrmHome";
            Load += FrmHome_Load;
            mnStrp.ResumeLayout(false);
            mnStrp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnStrp;
        private ToolStripMenuItem dDAToolStripMenuItem;
        private ToolStripMenuItem bresenhamToolStripMenuItem;
        private ToolStripMenuItem bresenhamCircunferenciaToolStripMenuItem;
        private ToolStripMenuItem rellenoInundaciónToolStripMenuItem;
    }
}
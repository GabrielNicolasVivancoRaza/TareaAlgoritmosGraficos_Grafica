namespace LineasCicunferencias
{
    partial class FrmWelcome
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
            lblWelcome = new Label();
            lblChoose = new Label();
            lblDatos = new Label();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline);
            lblWelcome.Location = new Point(174, 196);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(714, 38);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Bienvenido al sistema de algoritmos gráficos básicos.";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblChoose
            // 
            lblChoose.AutoSize = true;
            lblChoose.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline);
            lblChoose.Location = new Point(228, 234);
            lblChoose.Name = "lblChoose";
            lblChoose.Size = new Size(548, 38);
            lblChoose.TabIndex = 1;
            lblChoose.Text = "Elija una opción del menú para empezar.";
            lblChoose.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline);
            lblDatos.Location = new Point(228, 357);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(384, 38);
            lblDatos.TabIndex = 2;
            lblDatos.Text = "Gabriel Vivanco NRC: 22419";
            // 
            // FrmWelcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1127, 659);
            Controls.Add(lblDatos);
            Controls.Add(lblChoose);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmWelcome";
            Text = "FrmWelcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblChoose;
        private Label lblDatos;
    }
}
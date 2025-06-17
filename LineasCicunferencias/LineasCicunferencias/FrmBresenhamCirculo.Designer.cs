namespace LineasCicunferencias
{
    partial class FrmBresenhamCirculo
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
            gbrCanvas = new GroupBox();
            picCanvas = new PictureBox();
            grbProcess = new GroupBox();
            btnExit = new Button();
            btnReset = new Button();
            btnCalculate = new Button();
            grbInputs = new GroupBox();
            lblRadio = new Label();
            txtRadius = new TextBox();
            gbrCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            grbProcess.SuspendLayout();
            grbInputs.SuspendLayout();
            SuspendLayout();
            // 
            // gbrCanvas
            // 
            gbrCanvas.Controls.Add(picCanvas);
            gbrCanvas.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbrCanvas.Location = new Point(390, 27);
            gbrCanvas.Margin = new Padding(3, 4, 3, 4);
            gbrCanvas.Name = "gbrCanvas";
            gbrCanvas.Padding = new Padding(3, 4, 3, 4);
            gbrCanvas.Size = new Size(724, 605);
            gbrCanvas.TabIndex = 13;
            gbrCanvas.TabStop = false;
            gbrCanvas.Text = "Gráfico";
            // 
            // picCanvas
            // 
            picCanvas.Location = new Point(7, 28);
            picCanvas.Margin = new Padding(3, 4, 3, 4);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(711, 570);
            picCanvas.TabIndex = 0;
            picCanvas.TabStop = false;
            // 
            // grbProcess
            // 
            grbProcess.Controls.Add(btnExit);
            grbProcess.Controls.Add(btnReset);
            grbProcess.Controls.Add(btnCalculate);
            grbProcess.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbProcess.Location = new Point(12, 454);
            grbProcess.Margin = new Padding(3, 4, 3, 4);
            grbProcess.Name = "grbProcess";
            grbProcess.Padding = new Padding(3, 4, 3, 4);
            grbProcess.Size = new Size(348, 101);
            grbProcess.TabIndex = 12;
            grbProcess.TabStop = false;
            grbProcess.Text = "Proceso";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.MediumSeaGreen;
            btnExit.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(240, 39);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(84, 41);
            btnExit.TabIndex = 2;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.MediumSeaGreen;
            btnReset.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(120, 39);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(89, 41);
            btnReset.TabIndex = 1;
            btnReset.Text = "Resetear";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.MediumSeaGreen;
            btnCalculate.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(15, 39);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(84, 41);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // grbInputs
            // 
            grbInputs.Controls.Add(lblRadio);
            grbInputs.Controls.Add(txtRadius);
            grbInputs.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbInputs.Location = new Point(12, 169);
            grbInputs.Margin = new Padding(3, 4, 3, 4);
            grbInputs.Name = "grbInputs";
            grbInputs.Padding = new Padding(3, 4, 3, 4);
            grbInputs.Size = new Size(349, 214);
            grbInputs.TabIndex = 11;
            grbInputs.TabStop = false;
            grbInputs.Text = "Entradas";
            // 
            // lblRadio
            // 
            lblRadio.AutoSize = true;
            lblRadio.Location = new Point(31, 63);
            lblRadio.Name = "lblRadio";
            lblRadio.Size = new Size(53, 16);
            lblRadio.TabIndex = 4;
            lblRadio.Text = "Radio:";
            // 
            // txtRadius
            // 
            txtRadius.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRadius.Location = new Point(90, 53);
            txtRadius.Margin = new Padding(3, 4, 3, 4);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(88, 30);
            txtRadius.TabIndex = 2;
            // 
            // FrmBresenhamCirculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1127, 659);
            Controls.Add(gbrCanvas);
            Controls.Add(grbProcess);
            Controls.Add(grbInputs);
            Name = "FrmBresenhamCirculo";
            Text = "FrmBresenhamCirculo";
            gbrCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            grbProcess.ResumeLayout(false);
            grbInputs.ResumeLayout(false);
            grbInputs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbrCanvas;
        private PictureBox picCanvas;
        private GroupBox grbProcess;
        private Button btnExit;
        private Button btnReset;
        private Button btnCalculate;
        private GroupBox grbInputs;
        private Label lblRadio;
        private TextBox txtRadius;
    }
}
namespace LineasCicunferencias {
    partial class FrmSquare
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
            grbInputs = new GroupBox();
            txtSide = new TextBox();
            lblSide = new Label();
            grbProcess = new GroupBox();
            btnExit = new Button();
            btnReset = new Button();
            btnCalculate = new Button();
            gbrCanvas = new GroupBox();
            picCanvas = new PictureBox();
            grbInputs.SuspendLayout();
            grbProcess.SuspendLayout();
            gbrCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            SuspendLayout();
            // 
            // grbInputs
            // 
            grbInputs.Controls.Add(txtSide);
            grbInputs.Controls.Add(lblSide);
            grbInputs.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbInputs.Location = new Point(11, 217);
            grbInputs.Margin = new Padding(3, 4, 3, 4);
            grbInputs.Name = "grbInputs";
            grbInputs.Padding = new Padding(3, 4, 3, 4);
            grbInputs.Size = new Size(349, 105);
            grbInputs.TabIndex = 0;
            grbInputs.TabStop = false;
            grbInputs.Text = "Entradas";
            // 
            // txtSide
            // 
            txtSide.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSide.Location = new Point(133, 28);
            txtSide.Margin = new Padding(3, 4, 3, 4);
            txtSide.Name = "txtSide";
            txtSide.Size = new Size(182, 30);
            txtSide.TabIndex = 2;
            // 
            // lblSide
            // 
            lblSide.AutoSize = true;
            lblSide.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSide.Location = new Point(49, 40);
            lblSide.Name = "lblSide";
            lblSide.Size = new Size(51, 20);
            lblSide.TabIndex = 0;
            lblSide.Text = "Lado:";
            // 
            // grbProcess
            // 
            grbProcess.Controls.Add(btnExit);
            grbProcess.Controls.Add(btnReset);
            grbProcess.Controls.Add(btnCalculate);
            grbProcess.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbProcess.Location = new Point(12, 402);
            grbProcess.Margin = new Padding(3, 4, 3, 4);
            grbProcess.Name = "grbProcess";
            grbProcess.Padding = new Padding(3, 4, 3, 4);
            grbProcess.Size = new Size(348, 102);
            grbProcess.TabIndex = 2;
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
            // gbrCanvas
            // 
            gbrCanvas.Controls.Add(picCanvas);
            gbrCanvas.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbrCanvas.Location = new Point(391, 15);
            gbrCanvas.Margin = new Padding(3, 4, 3, 4);
            gbrCanvas.Name = "gbrCanvas";
            gbrCanvas.Padding = new Padding(3, 4, 3, 4);
            gbrCanvas.Size = new Size(724, 605);
            gbrCanvas.TabIndex = 3;
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
            picCanvas.MouseClick += picCanvas_MouseClick;
            // 
            // FrmSquare
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1127, 659);
            Controls.Add(gbrCanvas);
            Controls.Add(grbProcess);
            Controls.Add(grbInputs);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmSquare";
            Text = "FrmSquare";
            Load += FrmSquare_Load;
            grbInputs.ResumeLayout(false);
            grbInputs.PerformLayout();
            grbProcess.ResumeLayout(false);
            gbrCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox txtSide;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.GroupBox grbOutputs;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.GroupBox gbrCanvas;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.TrackBar tkbEscala;
        private System.Windows.Forms.Button btnHorario;
        private System.Windows.Forms.Button btnAntihorario;
    }
}
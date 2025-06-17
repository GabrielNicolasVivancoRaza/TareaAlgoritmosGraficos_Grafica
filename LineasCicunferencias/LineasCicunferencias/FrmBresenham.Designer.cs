namespace LineasCicunferencias
{
    partial class FrmBresenham
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
            lblFinalY = new Label();
            txtFinalY = new TextBox();
            lblFinalX = new Label();
            txtFinalX = new TextBox();
            lblFinal = new Label();
            lblInitialY = new Label();
            txtInitialY = new TextBox();
            lblInitialX = new Label();
            txtInitialX = new TextBox();
            lblInitial = new Label();
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
            gbrCanvas.TabIndex = 10;
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
            grbProcess.TabIndex = 9;
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
            btnExit.Click += btnExit_Click_1;
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
            btnReset.Click += btnReset_Click_1;
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
            grbInputs.Controls.Add(lblFinalY);
            grbInputs.Controls.Add(txtFinalY);
            grbInputs.Controls.Add(lblFinalX);
            grbInputs.Controls.Add(txtFinalX);
            grbInputs.Controls.Add(lblFinal);
            grbInputs.Controls.Add(lblInitialY);
            grbInputs.Controls.Add(txtInitialY);
            grbInputs.Controls.Add(lblInitialX);
            grbInputs.Controls.Add(txtInitialX);
            grbInputs.Controls.Add(lblInitial);
            grbInputs.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbInputs.Location = new Point(12, 169);
            grbInputs.Margin = new Padding(3, 4, 3, 4);
            grbInputs.Name = "grbInputs";
            grbInputs.Padding = new Padding(3, 4, 3, 4);
            grbInputs.Size = new Size(349, 214);
            grbInputs.TabIndex = 8;
            grbInputs.TabStop = false;
            grbInputs.Text = "Entradas";
            // 
            // lblFinalY
            // 
            lblFinalY.AutoSize = true;
            lblFinalY.Location = new Point(165, 151);
            lblFinalY.Name = "lblFinalY";
            lblFinalY.Size = new Size(19, 16);
            lblFinalY.TabIndex = 11;
            lblFinalY.Text = "y:";
            // 
            // txtFinalY
            // 
            txtFinalY.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFinalY.Location = new Point(189, 141);
            txtFinalY.Margin = new Padding(3, 4, 3, 4);
            txtFinalY.Name = "txtFinalY";
            txtFinalY.Size = new Size(88, 30);
            txtFinalY.TabIndex = 10;
            // 
            // lblFinalX
            // 
            lblFinalX.AutoSize = true;
            lblFinalX.Location = new Point(31, 151);
            lblFinalX.Name = "lblFinalX";
            lblFinalX.Size = new Size(18, 16);
            lblFinalX.TabIndex = 9;
            lblFinalX.Text = "x:";
            // 
            // txtFinalX
            // 
            txtFinalX.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFinalX.Location = new Point(55, 141);
            txtFinalX.Margin = new Padding(3, 4, 3, 4);
            txtFinalX.Name = "txtFinalX";
            txtFinalX.Size = new Size(88, 30);
            txtFinalX.TabIndex = 8;
            // 
            // lblFinal
            // 
            lblFinal.AutoSize = true;
            lblFinal.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFinal.Location = new Point(27, 118);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(98, 20);
            lblFinal.TabIndex = 7;
            lblFinal.Text = "Punto Final:";
            // 
            // lblInitialY
            // 
            lblInitialY.AutoSize = true;
            lblInitialY.Location = new Point(165, 62);
            lblInitialY.Name = "lblInitialY";
            lblInitialY.Size = new Size(19, 16);
            lblInitialY.TabIndex = 6;
            lblInitialY.Text = "y:";
            // 
            // txtInitialY
            // 
            txtInitialY.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInitialY.Location = new Point(189, 52);
            txtInitialY.Margin = new Padding(3, 4, 3, 4);
            txtInitialY.Name = "txtInitialY";
            txtInitialY.Size = new Size(88, 30);
            txtInitialY.TabIndex = 5;
            // 
            // lblInitialX
            // 
            lblInitialX.AutoSize = true;
            lblInitialX.Location = new Point(31, 62);
            lblInitialX.Name = "lblInitialX";
            lblInitialX.Size = new Size(18, 16);
            lblInitialX.TabIndex = 4;
            lblInitialX.Text = "x:";
            // 
            // txtInitialX
            // 
            txtInitialX.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInitialX.Location = new Point(55, 52);
            txtInitialX.Margin = new Padding(3, 4, 3, 4);
            txtInitialX.Name = "txtInitialX";
            txtInitialX.Size = new Size(88, 30);
            txtInitialX.TabIndex = 2;
            // 
            // lblInitial
            // 
            lblInitial.AutoSize = true;
            lblInitial.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInitial.Location = new Point(27, 29);
            lblInitial.Name = "lblInitial";
            lblInitial.Size = new Size(105, 20);
            lblInitial.TabIndex = 0;
            lblInitial.Text = "Punto Inicial:";
            // 
            // FrmBresenham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1127, 659);
            Controls.Add(gbrCanvas);
            Controls.Add(grbProcess);
            Controls.Add(grbInputs);
            Name = "FrmBresenham";
            Text = "FrmBresenham";
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
        private Label lblFinalY;
        private TextBox txtFinalY;
        private Label lblFinalX;
        private TextBox txtFinalX;
        public Label lblFinal;
        private Label lblInitialY;
        private TextBox txtInitialY;
        private Label lblInitialX;
        private TextBox txtInitialX;
        public Label lblInitial;
    }
}
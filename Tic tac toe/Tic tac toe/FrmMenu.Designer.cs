namespace Tic_tac_toe
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.elipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnClose = new Guna.UI.WinForms.GunaControlBox();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.btnCasilla0 = new Guna.UI.WinForms.GunaGradientButton();
            this.pictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnCPUvsCPU = new Guna.UI.WinForms.GunaGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse
            // 
            this.elipse.Radius = 10;
            this.elipse.TargetControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconSize = 100F;
            this.btnClose.Location = new System.Drawing.Point(593, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnClose.OnHoverIconColor = System.Drawing.Color.White;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(41, 34);
            this.btnClose.TabIndex = 1;
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(33)))), ((int)(((byte)(108)))));
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.Teal;
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton1.Image")));
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.gunaGradientButton1.Location = new System.Drawing.Point(428, 249);
            this.gunaGradientButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(197)))), ((int)(((byte)(203)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(17)))), ((int)(((byte)(57)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Radius = 4;
            this.gunaGradientButton1.Size = new System.Drawing.Size(171, 47);
            this.gunaGradientButton1.TabIndex = 3;
            this.gunaGradientButton1.Text = "J vs CPU";
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // btnCasilla0
            // 
            this.btnCasilla0.AnimationHoverSpeed = 0.07F;
            this.btnCasilla0.AnimationSpeed = 0.03F;
            this.btnCasilla0.BackColor = System.Drawing.Color.Transparent;
            this.btnCasilla0.BaseColor1 = System.Drawing.Color.Teal;
            this.btnCasilla0.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(33)))), ((int)(((byte)(108)))));
            this.btnCasilla0.BorderColor = System.Drawing.Color.Black;
            this.btnCasilla0.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCasilla0.FocusedColor = System.Drawing.Color.Empty;
            this.btnCasilla0.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCasilla0.ForeColor = System.Drawing.Color.White;
            this.btnCasilla0.Image = global::Tic_tac_toe.Properties.Resources.gato4;
            this.btnCasilla0.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCasilla0.Location = new System.Drawing.Point(25, 249);
            this.btnCasilla0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCasilla0.Name = "btnCasilla0";
            this.btnCasilla0.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(17)))), ((int)(((byte)(57)))));
            this.btnCasilla0.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(197)))), ((int)(((byte)(203)))));
            this.btnCasilla0.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCasilla0.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCasilla0.OnHoverImage = null;
            this.btnCasilla0.OnPressedColor = System.Drawing.Color.Black;
            this.btnCasilla0.Radius = 4;
            this.btnCasilla0.Size = new System.Drawing.Size(145, 47);
            this.btnCasilla0.TabIndex = 2;
            this.btnCasilla0.Text = "J vs J";
            this.btnCasilla0.Click += new System.EventHandler(this.btnCasilla0_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BaseColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Tic_tac_toe.Properties.Resources.Tic_tac_toe_Title;
            this.pictureBox1.Location = new System.Drawing.Point(1, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCPUvsCPU
            // 
            this.btnCPUvsCPU.AnimationHoverSpeed = 0.07F;
            this.btnCPUvsCPU.AnimationSpeed = 0.03F;
            this.btnCPUvsCPU.BackColor = System.Drawing.Color.Transparent;
            this.btnCPUvsCPU.BaseColor1 = System.Drawing.Color.Teal;
            this.btnCPUvsCPU.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(33)))), ((int)(((byte)(108)))));
            this.btnCPUvsCPU.BorderColor = System.Drawing.Color.Black;
            this.btnCPUvsCPU.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCPUvsCPU.FocusedColor = System.Drawing.Color.Empty;
            this.btnCPUvsCPU.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPUvsCPU.ForeColor = System.Drawing.Color.White;
            this.btnCPUvsCPU.Image = global::Tic_tac_toe.Properties.Resources.gato4;
            this.btnCPUvsCPU.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCPUvsCPU.Location = new System.Drawing.Point(201, 249);
            this.btnCPUvsCPU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCPUvsCPU.Name = "btnCPUvsCPU";
            this.btnCPUvsCPU.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(17)))), ((int)(((byte)(57)))));
            this.btnCPUvsCPU.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(197)))), ((int)(((byte)(203)))));
            this.btnCPUvsCPU.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCPUvsCPU.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCPUvsCPU.OnHoverImage = null;
            this.btnCPUvsCPU.OnPressedColor = System.Drawing.Color.Black;
            this.btnCPUvsCPU.Radius = 4;
            this.btnCPUvsCPU.Size = new System.Drawing.Size(199, 47);
            this.btnCPUvsCPU.TabIndex = 4;
            this.btnCPUvsCPU.Text = "CPU vs CPU";
            this.btnCPUvsCPU.Click += new System.EventHandler(this.btnCPUvsCPU_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(71)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(635, 366);
            this.Controls.Add(this.btnCPUvsCPU);
            this.Controls.Add(this.gunaGradientButton1);
            this.Controls.Add(this.btnCasilla0);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse elipse;
        private Guna.UI.WinForms.GunaPictureBox pictureBox1;
        private Guna.UI.WinForms.GunaControlBox btnClose;
        private Guna.UI.WinForms.GunaGradientButton btnCasilla0;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private Guna.UI.WinForms.GunaGradientButton btnCPUvsCPU;
    }
}
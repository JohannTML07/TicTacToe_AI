using Guna;

namespace Tic_tac_toe
{
    partial class FrmBoard
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.pbCasilla8 = new System.Windows.Forms.PictureBox();
            this.pbCasilla7 = new System.Windows.Forms.PictureBox();
            this.pbCasilla6 = new System.Windows.Forms.PictureBox();
            this.pbCasilla5 = new System.Windows.Forms.PictureBox();
            this.pbCasilla4 = new System.Windows.Forms.PictureBox();
            this.pbCasilla3 = new System.Windows.Forms.PictureBox();
            this.pbCasilla2 = new System.Windows.Forms.PictureBox();
            this.pbCasilla1 = new System.Windows.Forms.PictureBox();
            this.pbCasilla0 = new System.Windows.Forms.PictureBox();
            this.btnCasilla8 = new Guna.UI.WinForms.GunaGradientButton();
            this.btnCasilla7 = new Guna.UI.WinForms.GunaGradientButton();
            this.btnCasilla6 = new Guna.UI.WinForms.GunaGradientButton();
            this.btnCasilla5 = new Guna.UI.WinForms.GunaGradientButton();
            this.btnCasilla4 = new Guna.UI.WinForms.GunaGradientButton();
            this.btnCasilla3 = new Guna.UI.WinForms.GunaGradientButton();
            this.btnCasilla2 = new Guna.UI.WinForms.GunaGradientButton();
            this.btnCasilla1 = new Guna.UI.WinForms.GunaGradientButton();
            this.btnCasilla0 = new Guna.UI.WinForms.GunaGradientButton();
            this.lbTitle = new Guna.UI.WinForms.GunaLabel();
            this.btnClose = new Guna.UI.WinForms.GunaControlBox();
            this.elipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCasilla8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCasilla7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCasilla6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCasilla5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCasilla4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCasilla3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCasilla2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCasilla1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCasilla0)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.gunaGradientButton1);
            this.panel1.Controls.Add(this.pbCasilla8);
            this.panel1.Controls.Add(this.pbCasilla7);
            this.panel1.Controls.Add(this.pbCasilla6);
            this.panel1.Controls.Add(this.pbCasilla5);
            this.panel1.Controls.Add(this.pbCasilla4);
            this.panel1.Controls.Add(this.pbCasilla3);
            this.panel1.Controls.Add(this.pbCasilla2);
            this.panel1.Controls.Add(this.pbCasilla1);
            this.panel1.Controls.Add(this.pbCasilla0);
            this.panel1.Controls.Add(this.btnCasilla8);
            this.panel1.Controls.Add(this.btnCasilla7);
            this.panel1.Controls.Add(this.btnCasilla6);
            this.panel1.Controls.Add(this.btnCasilla5);
            this.panel1.Controls.Add(this.btnCasilla4);
            this.panel1.Controls.Add(this.btnCasilla3);
            this.panel1.Controls.Add(this.btnCasilla2);
            this.panel1.Controls.Add(this.btnCasilla1);
            this.panel1.Controls.Add(this.btnCasilla0);
            this.panel1.Location = new System.Drawing.Point(59, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 402);
            this.panel1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.AnimationHoverSpeed = 0.07F;
            this.btnStart.AnimationSpeed = 0.03F;
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(33)))), ((int)(((byte)(108)))));
            this.btnStart.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(64)))), ((int)(((byte)(63)))));
            this.btnStart.BorderColor = System.Drawing.Color.Black;
            this.btnStart.BorderSize = 3;
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStart.FocusedColor = System.Drawing.Color.Empty;
            this.btnStart.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Image = null;
            this.btnStart.ImageSize = new System.Drawing.Size(50, 50);
            this.btnStart.Location = new System.Drawing.Point(78, 166);
            this.btnStart.Name = "btnStart";
            this.btnStart.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(197)))), ((int)(((byte)(203)))));
            this.btnStart.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(17)))), ((int)(((byte)(57)))));
            this.btnStart.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStart.OnHoverForeColor = System.Drawing.Color.White;
            this.btnStart.OnHoverImage = null;
            this.btnStart.OnPressedColor = System.Drawing.Color.Black;
            this.btnStart.Radius = 4;
            this.btnStart.Size = new System.Drawing.Size(289, 68);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "Comenzar";
            this.btnStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStart.UseTransfarantBackground = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(33)))), ((int)(((byte)(108)))));
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(64)))), ((int)(((byte)(63)))));
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.BorderSize = 3;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.Image = null;
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.gunaGradientButton1.Location = new System.Drawing.Point(78, 166);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(197)))), ((int)(((byte)(203)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(17)))), ((int)(((byte)(57)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Radius = 4;
            this.gunaGradientButton1.Size = new System.Drawing.Size(289, 68);
            this.gunaGradientButton1.TabIndex = 4;
            this.gunaGradientButton1.Text = "Volver a jugar";
            this.gunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton1.UseTransfarantBackground = true;
            this.gunaGradientButton1.Visible = false;
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // pbCasilla8
            // 
            this.pbCasilla8.BackColor = System.Drawing.Color.Teal;
            this.pbCasilla8.Location = new System.Drawing.Point(300, 274);
            this.pbCasilla8.Name = "pbCasilla8";
            this.pbCasilla8.Size = new System.Drawing.Size(138, 127);
            this.pbCasilla8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCasilla8.TabIndex = 16;
            this.pbCasilla8.TabStop = false;
            this.pbCasilla8.Visible = false;
            // 
            // pbCasilla7
            // 
            this.pbCasilla7.BackColor = System.Drawing.Color.Teal;
            this.pbCasilla7.Location = new System.Drawing.Point(151, 274);
            this.pbCasilla7.Name = "pbCasilla7";
            this.pbCasilla7.Size = new System.Drawing.Size(138, 127);
            this.pbCasilla7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCasilla7.TabIndex = 15;
            this.pbCasilla7.TabStop = false;
            this.pbCasilla7.Visible = false;
            // 
            // pbCasilla6
            // 
            this.pbCasilla6.BackColor = System.Drawing.Color.Teal;
            this.pbCasilla6.Location = new System.Drawing.Point(3, 274);
            this.pbCasilla6.Name = "pbCasilla6";
            this.pbCasilla6.Size = new System.Drawing.Size(138, 127);
            this.pbCasilla6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCasilla6.TabIndex = 14;
            this.pbCasilla6.TabStop = false;
            this.pbCasilla6.Visible = false;
            // 
            // pbCasilla5
            // 
            this.pbCasilla5.BackColor = System.Drawing.Color.Teal;
            this.pbCasilla5.Location = new System.Drawing.Point(299, 138);
            this.pbCasilla5.Name = "pbCasilla5";
            this.pbCasilla5.Size = new System.Drawing.Size(138, 127);
            this.pbCasilla5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCasilla5.TabIndex = 13;
            this.pbCasilla5.TabStop = false;
            this.pbCasilla5.Visible = false;
            // 
            // pbCasilla4
            // 
            this.pbCasilla4.BackColor = System.Drawing.Color.Teal;
            this.pbCasilla4.Location = new System.Drawing.Point(151, 138);
            this.pbCasilla4.Name = "pbCasilla4";
            this.pbCasilla4.Size = new System.Drawing.Size(138, 127);
            this.pbCasilla4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCasilla4.TabIndex = 12;
            this.pbCasilla4.TabStop = false;
            this.pbCasilla4.Visible = false;
            // 
            // pbCasilla3
            // 
            this.pbCasilla3.BackColor = System.Drawing.Color.Teal;
            this.pbCasilla3.Location = new System.Drawing.Point(3, 138);
            this.pbCasilla3.Name = "pbCasilla3";
            this.pbCasilla3.Size = new System.Drawing.Size(138, 127);
            this.pbCasilla3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCasilla3.TabIndex = 11;
            this.pbCasilla3.TabStop = false;
            this.pbCasilla3.Visible = false;
            // 
            // pbCasilla2
            // 
            this.pbCasilla2.BackColor = System.Drawing.Color.Teal;
            this.pbCasilla2.Location = new System.Drawing.Point(299, 2);
            this.pbCasilla2.Name = "pbCasilla2";
            this.pbCasilla2.Size = new System.Drawing.Size(138, 127);
            this.pbCasilla2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCasilla2.TabIndex = 10;
            this.pbCasilla2.TabStop = false;
            this.pbCasilla2.Visible = false;
            // 
            // pbCasilla1
            // 
            this.pbCasilla1.BackColor = System.Drawing.Color.Teal;
            this.pbCasilla1.Location = new System.Drawing.Point(151, 2);
            this.pbCasilla1.Name = "pbCasilla1";
            this.pbCasilla1.Size = new System.Drawing.Size(138, 127);
            this.pbCasilla1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCasilla1.TabIndex = 9;
            this.pbCasilla1.TabStop = false;
            this.pbCasilla1.Visible = false;
            // 
            // pbCasilla0
            // 
            this.pbCasilla0.BackColor = System.Drawing.Color.Teal;
            this.pbCasilla0.Location = new System.Drawing.Point(3, 2);
            this.pbCasilla0.Name = "pbCasilla0";
            this.pbCasilla0.Size = new System.Drawing.Size(138, 127);
            this.pbCasilla0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCasilla0.TabIndex = 2;
            this.pbCasilla0.TabStop = false;
            this.pbCasilla0.Visible = false;
            // 
            // btnCasilla8
            // 
            this.btnCasilla8.AnimationHoverSpeed = 0.07F;
            this.btnCasilla8.AnimationSpeed = 0.03F;
            this.btnCasilla8.BackColor = System.Drawing.Color.Transparent;
            this.btnCasilla8.BaseColor1 = System.Drawing.Color.Teal;
            this.btnCasilla8.BaseColor2 = System.Drawing.Color.Teal;
            this.btnCasilla8.BorderColor = System.Drawing.Color.Black;
            this.btnCasilla8.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCasilla8.FocusedColor = System.Drawing.Color.Empty;
            this.btnCasilla8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCasilla8.ForeColor = System.Drawing.Color.White;
            this.btnCasilla8.Image = global::Tic_tac_toe.Properties.Resources.gato4;
            this.btnCasilla8.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCasilla8.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCasilla8.Location = new System.Drawing.Point(297, 272);
            this.btnCasilla8.Name = "btnCasilla8";
            this.btnCasilla8.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnCasilla8.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnCasilla8.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCasilla8.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCasilla8.OnHoverImage = null;
            this.btnCasilla8.OnPressedColor = System.Drawing.Color.Black;
            this.btnCasilla8.Radius = 4;
            this.btnCasilla8.Size = new System.Drawing.Size(143, 130);
            this.btnCasilla8.TabIndex = 8;
            this.btnCasilla8.Click += new System.EventHandler(this.btnCasilla8_Click);
            // 
            // btnCasilla7
            // 
            this.btnCasilla7.AnimationHoverSpeed = 0.07F;
            this.btnCasilla7.AnimationSpeed = 0.03F;
            this.btnCasilla7.BackColor = System.Drawing.Color.Transparent;
            this.btnCasilla7.BaseColor1 = System.Drawing.Color.Teal;
            this.btnCasilla7.BaseColor2 = System.Drawing.Color.Teal;
            this.btnCasilla7.BorderColor = System.Drawing.Color.Black;
            this.btnCasilla7.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCasilla7.FocusedColor = System.Drawing.Color.Empty;
            this.btnCasilla7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCasilla7.ForeColor = System.Drawing.Color.White;
            this.btnCasilla7.Image = global::Tic_tac_toe.Properties.Resources.gato4;
            this.btnCasilla7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCasilla7.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCasilla7.Location = new System.Drawing.Point(148, 272);
            this.btnCasilla7.Name = "btnCasilla7";
            this.btnCasilla7.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnCasilla7.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnCasilla7.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCasilla7.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCasilla7.OnHoverImage = null;
            this.btnCasilla7.OnPressedColor = System.Drawing.Color.Black;
            this.btnCasilla7.Radius = 4;
            this.btnCasilla7.Size = new System.Drawing.Size(143, 130);
            this.btnCasilla7.TabIndex = 7;
            this.btnCasilla7.Click += new System.EventHandler(this.btnCasilla7_Click);
            // 
            // btnCasilla6
            // 
            this.btnCasilla6.AnimationHoverSpeed = 0.07F;
            this.btnCasilla6.AnimationSpeed = 0.03F;
            this.btnCasilla6.BackColor = System.Drawing.Color.Transparent;
            this.btnCasilla6.BaseColor1 = System.Drawing.Color.Teal;
            this.btnCasilla6.BaseColor2 = System.Drawing.Color.Teal;
            this.btnCasilla6.BorderColor = System.Drawing.Color.Black;
            this.btnCasilla6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCasilla6.FocusedColor = System.Drawing.Color.Empty;
            this.btnCasilla6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCasilla6.ForeColor = System.Drawing.Color.White;
            this.btnCasilla6.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnCasilla6.Image = global::Tic_tac_toe.Properties.Resources.gato4;
            this.btnCasilla6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCasilla6.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCasilla6.Location = new System.Drawing.Point(0, 272);
            this.btnCasilla6.Name = "btnCasilla6";
            this.btnCasilla6.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnCasilla6.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnCasilla6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCasilla6.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCasilla6.OnHoverImage = null;
            this.btnCasilla6.OnPressedColor = System.Drawing.Color.Black;
            this.btnCasilla6.Radius = 4;
            this.btnCasilla6.Size = new System.Drawing.Size(143, 130);
            this.btnCasilla6.TabIndex = 6;
            this.btnCasilla6.Click += new System.EventHandler(this.btnCasilla6_Click);
            // 
            // btnCasilla5
            // 
            this.btnCasilla5.AnimationHoverSpeed = 0.07F;
            this.btnCasilla5.AnimationSpeed = 0.03F;
            this.btnCasilla5.BackColor = System.Drawing.Color.Transparent;
            this.btnCasilla5.BaseColor1 = System.Drawing.Color.Teal;
            this.btnCasilla5.BaseColor2 = System.Drawing.Color.Teal;
            this.btnCasilla5.BorderColor = System.Drawing.Color.Black;
            this.btnCasilla5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCasilla5.FocusedColor = System.Drawing.Color.Empty;
            this.btnCasilla5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCasilla5.ForeColor = System.Drawing.Color.White;
            this.btnCasilla5.Image = global::Tic_tac_toe.Properties.Resources.gato4;
            this.btnCasilla5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCasilla5.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCasilla5.Location = new System.Drawing.Point(297, 136);
            this.btnCasilla5.Name = "btnCasilla5";
            this.btnCasilla5.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnCasilla5.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnCasilla5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCasilla5.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCasilla5.OnHoverImage = null;
            this.btnCasilla5.OnPressedColor = System.Drawing.Color.Black;
            this.btnCasilla5.Radius = 4;
            this.btnCasilla5.Size = new System.Drawing.Size(143, 130);
            this.btnCasilla5.TabIndex = 5;
            this.btnCasilla5.Click += new System.EventHandler(this.btnCasilla5_Click);
            // 
            // btnCasilla4
            // 
            this.btnCasilla4.AnimationHoverSpeed = 0.07F;
            this.btnCasilla4.AnimationSpeed = 0.03F;
            this.btnCasilla4.BackColor = System.Drawing.Color.Transparent;
            this.btnCasilla4.BaseColor1 = System.Drawing.Color.Teal;
            this.btnCasilla4.BaseColor2 = System.Drawing.Color.Teal;
            this.btnCasilla4.BorderColor = System.Drawing.Color.Black;
            this.btnCasilla4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCasilla4.FocusedColor = System.Drawing.Color.Empty;
            this.btnCasilla4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCasilla4.ForeColor = System.Drawing.Color.White;
            this.btnCasilla4.Image = global::Tic_tac_toe.Properties.Resources.gato4;
            this.btnCasilla4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCasilla4.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCasilla4.Location = new System.Drawing.Point(148, 136);
            this.btnCasilla4.Name = "btnCasilla4";
            this.btnCasilla4.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnCasilla4.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnCasilla4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCasilla4.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCasilla4.OnHoverImage = null;
            this.btnCasilla4.OnPressedColor = System.Drawing.Color.Black;
            this.btnCasilla4.Radius = 4;
            this.btnCasilla4.Size = new System.Drawing.Size(143, 130);
            this.btnCasilla4.TabIndex = 4;
            this.btnCasilla4.Click += new System.EventHandler(this.btnCasilla4_Click);
            // 
            // btnCasilla3
            // 
            this.btnCasilla3.AnimationHoverSpeed = 0.07F;
            this.btnCasilla3.AnimationSpeed = 0.03F;
            this.btnCasilla3.BackColor = System.Drawing.Color.Transparent;
            this.btnCasilla3.BaseColor1 = System.Drawing.Color.Teal;
            this.btnCasilla3.BaseColor2 = System.Drawing.Color.Teal;
            this.btnCasilla3.BorderColor = System.Drawing.Color.Black;
            this.btnCasilla3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCasilla3.FocusedColor = System.Drawing.Color.Empty;
            this.btnCasilla3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCasilla3.ForeColor = System.Drawing.Color.White;
            this.btnCasilla3.Image = global::Tic_tac_toe.Properties.Resources.gato4;
            this.btnCasilla3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCasilla3.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCasilla3.Location = new System.Drawing.Point(0, 136);
            this.btnCasilla3.Name = "btnCasilla3";
            this.btnCasilla3.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnCasilla3.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnCasilla3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCasilla3.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCasilla3.OnHoverImage = null;
            this.btnCasilla3.OnPressedColor = System.Drawing.Color.Black;
            this.btnCasilla3.Radius = 4;
            this.btnCasilla3.Size = new System.Drawing.Size(143, 130);
            this.btnCasilla3.TabIndex = 3;
            this.btnCasilla3.Click += new System.EventHandler(this.btnCasilla3_Click);
            // 
            // btnCasilla2
            // 
            this.btnCasilla2.AnimationHoverSpeed = 0.07F;
            this.btnCasilla2.AnimationSpeed = 0.03F;
            this.btnCasilla2.BackColor = System.Drawing.Color.Transparent;
            this.btnCasilla2.BaseColor1 = System.Drawing.Color.Teal;
            this.btnCasilla2.BaseColor2 = System.Drawing.Color.Teal;
            this.btnCasilla2.BorderColor = System.Drawing.Color.Black;
            this.btnCasilla2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCasilla2.FocusedColor = System.Drawing.Color.Empty;
            this.btnCasilla2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCasilla2.ForeColor = System.Drawing.Color.White;
            this.btnCasilla2.Image = global::Tic_tac_toe.Properties.Resources.gato4;
            this.btnCasilla2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCasilla2.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCasilla2.Location = new System.Drawing.Point(297, 0);
            this.btnCasilla2.Name = "btnCasilla2";
            this.btnCasilla2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnCasilla2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnCasilla2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCasilla2.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCasilla2.OnHoverImage = null;
            this.btnCasilla2.OnPressedColor = System.Drawing.Color.Black;
            this.btnCasilla2.Radius = 4;
            this.btnCasilla2.Size = new System.Drawing.Size(143, 130);
            this.btnCasilla2.TabIndex = 2;
            this.btnCasilla2.Click += new System.EventHandler(this.btnCasilla2_Click);
            // 
            // btnCasilla1
            // 
            this.btnCasilla1.AnimationHoverSpeed = 0.07F;
            this.btnCasilla1.AnimationSpeed = 0.03F;
            this.btnCasilla1.BackColor = System.Drawing.Color.Transparent;
            this.btnCasilla1.BaseColor1 = System.Drawing.Color.Teal;
            this.btnCasilla1.BaseColor2 = System.Drawing.Color.Teal;
            this.btnCasilla1.BorderColor = System.Drawing.Color.Black;
            this.btnCasilla1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCasilla1.FocusedColor = System.Drawing.Color.Empty;
            this.btnCasilla1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCasilla1.ForeColor = System.Drawing.Color.White;
            this.btnCasilla1.Image = global::Tic_tac_toe.Properties.Resources.gato4;
            this.btnCasilla1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCasilla1.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCasilla1.Location = new System.Drawing.Point(148, 0);
            this.btnCasilla1.Name = "btnCasilla1";
            this.btnCasilla1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnCasilla1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnCasilla1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCasilla1.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCasilla1.OnHoverImage = null;
            this.btnCasilla1.OnPressedColor = System.Drawing.Color.Black;
            this.btnCasilla1.Radius = 4;
            this.btnCasilla1.Size = new System.Drawing.Size(143, 130);
            this.btnCasilla1.TabIndex = 1;
            this.btnCasilla1.Click += new System.EventHandler(this.btnCasilla1_Click);
            // 
            // btnCasilla0
            // 
            this.btnCasilla0.AnimationHoverSpeed = 0.07F;
            this.btnCasilla0.AnimationSpeed = 0.03F;
            this.btnCasilla0.BackColor = System.Drawing.Color.Transparent;
            this.btnCasilla0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCasilla0.BaseColor1 = System.Drawing.Color.Teal;
            this.btnCasilla0.BaseColor2 = System.Drawing.Color.Teal;
            this.btnCasilla0.BorderColor = System.Drawing.Color.Black;
            this.btnCasilla0.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCasilla0.FocusedColor = System.Drawing.Color.Empty;
            this.btnCasilla0.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCasilla0.ForeColor = System.Drawing.Color.White;
            this.btnCasilla0.Image = global::Tic_tac_toe.Properties.Resources.gato4;
            this.btnCasilla0.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCasilla0.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCasilla0.Location = new System.Drawing.Point(0, 0);
            this.btnCasilla0.Name = "btnCasilla0";
            this.btnCasilla0.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnCasilla0.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnCasilla0.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCasilla0.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCasilla0.OnHoverImage = null;
            this.btnCasilla0.OnPressedColor = System.Drawing.Color.Black;
            this.btnCasilla0.Radius = 4;
            this.btnCasilla0.Size = new System.Drawing.Size(143, 130);
            this.btnCasilla0.TabIndex = 0;
            this.btnCasilla0.Click += new System.EventHandler(this.btnCasilla0_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.lbTitle.Location = new System.Drawing.Point(63, 54);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(437, 23);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Jugador VS CPU";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconSize = 100F;
            this.btnClose.Location = new System.Drawing.Point(506, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnClose.OnHoverIconColor = System.Drawing.Color.White;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(55, 42);
            this.btnClose.TabIndex = 0;
            // 
            // elipse
            // 
            this.elipse.Radius = 10;
            this.elipse.TargetControl = this;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this.panel1;
            // 
            // FrmBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(64)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(560, 548);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlArrastrar_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlArrastrar_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlArrastrar_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCasilla8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCasilla7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCasilla6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCasilla5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCasilla4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCasilla3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCasilla2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCasilla1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCasilla0)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel lbTitle;
        private Guna.UI.WinForms.GunaGradientButton btnCasilla0;
        private Guna.UI.WinForms.GunaGradientButton btnCasilla8;
        private Guna.UI.WinForms.GunaGradientButton btnCasilla7;
        private Guna.UI.WinForms.GunaGradientButton btnCasilla6;
        private Guna.UI.WinForms.GunaGradientButton btnCasilla5;
        private Guna.UI.WinForms.GunaGradientButton btnCasilla4;
        private Guna.UI.WinForms.GunaGradientButton btnCasilla3;
        private Guna.UI.WinForms.GunaGradientButton btnCasilla2;
        private Guna.UI.WinForms.GunaGradientButton btnCasilla1;
        private Guna.UI.WinForms.GunaControlBox btnClose;
        private Guna.UI.WinForms.GunaElipse elipse;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.PictureBox pbCasilla0;
        private System.Windows.Forms.PictureBox pbCasilla8;
        private System.Windows.Forms.PictureBox pbCasilla7;
        private System.Windows.Forms.PictureBox pbCasilla6;
        private System.Windows.Forms.PictureBox pbCasilla5;
        private System.Windows.Forms.PictureBox pbCasilla4;
        private System.Windows.Forms.PictureBox pbCasilla3;
        private System.Windows.Forms.PictureBox pbCasilla2;
        private System.Windows.Forms.PictureBox pbCasilla1;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private Guna.UI.WinForms.GunaGradientButton btnStart;
    }
}


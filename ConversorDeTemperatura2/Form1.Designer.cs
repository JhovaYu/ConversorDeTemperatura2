namespace ConversorDeTemperatura2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_Close = new System.Windows.Forms.PictureBox();
            this.LB_Titulo = new System.Windows.Forms.Label();
            this.TB_GradosCelsius = new System.Windows.Forms.TextBox();
            this.TB_GradosFarenheit = new System.Windows.Forms.TextBox();
            this.Img_Farenheit = new System.Windows.Forms.PictureBox();
            this.Img_Celsius = new System.Windows.Forms.PictureBox();
            this.Img_Clean = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Farenheit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Celsius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Clean)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Close
            // 
            this.Btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Close.Image")));
            this.Btn_Close.Location = new System.Drawing.Point(917, 12);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(56, 57);
            this.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Close.TabIndex = 0;
            this.Btn_Close.TabStop = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // LB_Titulo
            // 
            this.LB_Titulo.AutoSize = true;
            this.LB_Titulo.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Titulo.ForeColor = System.Drawing.Color.IndianRed;
            this.LB_Titulo.Location = new System.Drawing.Point(208, 61);
            this.LB_Titulo.Name = "LB_Titulo";
            this.LB_Titulo.Size = new System.Drawing.Size(549, 45);
            this.LB_Titulo.TabIndex = 1;
            this.LB_Titulo.Text = "CONVERSOR DE TEMPERATURA";
            this.LB_Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // TB_GradosCelsius
            // 
            this.TB_GradosCelsius.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_GradosCelsius.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_GradosCelsius.Location = new System.Drawing.Point(108, 311);
            this.TB_GradosCelsius.Name = "TB_GradosCelsius";
            this.TB_GradosCelsius.Size = new System.Drawing.Size(264, 25);
            this.TB_GradosCelsius.TabIndex = 2;
            this.TB_GradosCelsius.Text = "Ingrese grados Celsius";
            this.TB_GradosCelsius.Click += new System.EventHandler(this.TB_GradosCelsius_Click);
            this.TB_GradosCelsius.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_GradosCelsius_KeyDown);
            this.TB_GradosCelsius.Leave += new System.EventHandler(this.TB_GradosCelsius_Leave);
            // 
            // TB_GradosFarenheit
            // 
            this.TB_GradosFarenheit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_GradosFarenheit.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_GradosFarenheit.Location = new System.Drawing.Point(577, 311);
            this.TB_GradosFarenheit.Name = "TB_GradosFarenheit";
            this.TB_GradosFarenheit.Size = new System.Drawing.Size(323, 25);
            this.TB_GradosFarenheit.TabIndex = 3;
            this.TB_GradosFarenheit.Text = "Ingrese grados Farenheit";
            this.TB_GradosFarenheit.Click += new System.EventHandler(this.TB_GradosFarenheit_Click);
            this.TB_GradosFarenheit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_GradosFarenheit_KeyDown);
            this.TB_GradosFarenheit.Leave += new System.EventHandler(this.TB_GradosFarenheit_Leave);
            // 
            // Img_Farenheit
            // 
            this.Img_Farenheit.Image = ((System.Drawing.Image)(resources.GetObject("Img_Farenheit.Image")));
            this.Img_Farenheit.Location = new System.Drawing.Point(696, 199);
            this.Img_Farenheit.Name = "Img_Farenheit";
            this.Img_Farenheit.Size = new System.Drawing.Size(107, 97);
            this.Img_Farenheit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_Farenheit.TabIndex = 4;
            this.Img_Farenheit.TabStop = false;
            // 
            // Img_Celsius
            // 
            this.Img_Celsius.Image = ((System.Drawing.Image)(resources.GetObject("Img_Celsius.Image")));
            this.Img_Celsius.Location = new System.Drawing.Point(187, 199);
            this.Img_Celsius.Name = "Img_Celsius";
            this.Img_Celsius.Size = new System.Drawing.Size(94, 97);
            this.Img_Celsius.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_Celsius.TabIndex = 5;
            this.Img_Celsius.TabStop = false;
            // 
            // Img_Clean
            // 
            this.Img_Clean.Image = ((System.Drawing.Image)(resources.GetObject("Img_Clean.Image")));
            this.Img_Clean.Location = new System.Drawing.Point(431, 264);
            this.Img_Clean.Name = "Img_Clean";
            this.Img_Clean.Size = new System.Drawing.Size(96, 99);
            this.Img_Clean.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_Clean.TabIndex = 6;
            this.Img_Clean.TabStop = false;
            this.Img_Clean.Click += new System.EventHandler(this.Img_Clean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.Img_Clean);
            this.Controls.Add(this.Img_Celsius);
            this.Controls.Add(this.Img_Farenheit);
            this.Controls.Add(this.TB_GradosFarenheit);
            this.Controls.Add(this.TB_GradosCelsius);
            this.Controls.Add(this.LB_Titulo);
            this.Controls.Add(this.Btn_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Farenheit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Celsius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Clean)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Btn_Close;
        private System.Windows.Forms.Label LB_Titulo;
        private System.Windows.Forms.TextBox TB_GradosCelsius;
        private System.Windows.Forms.TextBox TB_GradosFarenheit;
        private System.Windows.Forms.PictureBox Img_Farenheit;
        private System.Windows.Forms.PictureBox Img_Celsius;
        private System.Windows.Forms.PictureBox Img_Clean;
    }
}


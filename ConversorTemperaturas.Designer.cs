namespace ProjetoFinal_InêsPires
{
    partial class ConversorTemperaturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversorTemperaturas));
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblGrausCel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnFahrenheit = new System.Windows.Forms.RadioButton();
            this.rbtnKelvin = new System.Windows.Forms.RadioButton();
            this.txtGraus = new System.Windows.Forms.TextBox();
            this.lblGraus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHoras = new System.Windows.Forms.Label();
            this.btnConverter = new System.Windows.Forms.Button();
            this.picTemp = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(59, 322);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(125, 46);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSair.Location = new System.Drawing.Point(190, 322);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(125, 46);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblGrausCel
            // 
            this.lblGrausCel.AutoSize = true;
            this.lblGrausCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrausCel.Location = new System.Drawing.Point(65, 56);
            this.lblGrausCel.Name = "lblGrausCel";
            this.lblGrausCel.Size = new System.Drawing.Size(135, 20);
            this.lblGrausCel.TabIndex = 2;
            this.lblGrausCel.Text = "Graus em celsius:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnFahrenheit);
            this.groupBox1.Controls.Add(this.rbtnKelvin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(68, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 91);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Converter para:";
            // 
            // rbtnFahrenheit
            // 
            this.rbtnFahrenheit.AutoSize = true;
            this.rbtnFahrenheit.Location = new System.Drawing.Point(15, 65);
            this.rbtnFahrenheit.Name = "rbtnFahrenheit";
            this.rbtnFahrenheit.Size = new System.Drawing.Size(108, 24);
            this.rbtnFahrenheit.TabIndex = 1;
            this.rbtnFahrenheit.TabStop = true;
            this.rbtnFahrenheit.Text = "Fahrenheit ";
            this.rbtnFahrenheit.UseVisualStyleBackColor = true;
            this.rbtnFahrenheit.CheckedChanged += new System.EventHandler(this.rbtnFahrenheit_CheckedChanged);
            // 
            // rbtnKelvin
            // 
            this.rbtnKelvin.AutoSize = true;
            this.rbtnKelvin.Location = new System.Drawing.Point(15, 35);
            this.rbtnKelvin.Name = "rbtnKelvin";
            this.rbtnKelvin.Size = new System.Drawing.Size(68, 24);
            this.rbtnKelvin.TabIndex = 0;
            this.rbtnKelvin.TabStop = true;
            this.rbtnKelvin.Text = "Kelvin";
            this.rbtnKelvin.UseVisualStyleBackColor = true;
            this.rbtnKelvin.CheckedChanged += new System.EventHandler(this.rbtnKelvin_CheckedChanged);
            // 
            // txtGraus
            // 
            this.txtGraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGraus.Location = new System.Drawing.Point(68, 83);
            this.txtGraus.Name = "txtGraus";
            this.txtGraus.Size = new System.Drawing.Size(96, 26);
            this.txtGraus.TabIndex = 4;
            this.txtGraus.TextChanged += new System.EventHandler(this.txtGraus_TextChanged);
            // 
            // lblGraus
            // 
            this.lblGraus.AutoSize = true;
            this.lblGraus.BackColor = System.Drawing.SystemColors.Control;
            this.lblGraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGraus.Location = new System.Drawing.Point(79, 288);
            this.lblGraus.Name = "lblGraus";
            this.lblGraus.Size = new System.Drawing.Size(0, 18);
            this.lblGraus.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.ForeColor = System.Drawing.Color.Red;
            this.lblHoras.Location = new System.Drawing.Point(389, 33);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(0, 20);
            this.lblHoras.TabIndex = 7;
            this.lblHoras.Visible = false;
            this.lblHoras.Click += new System.EventHandler(this.lblHoras_Click);
            // 
            // btnConverter
            // 
            this.btnConverter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConverter.Location = new System.Drawing.Point(59, 248);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(256, 33);
            this.btnConverter.TabIndex = 9;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = false;
            this.btnConverter.Click += new System.EventHandler(this.button1_Click);
            // 
            // picTemp
            // 
            this.picTemp.Image = global::ProjetoFinal_InêsPires.Properties.Resources.globofrio;
            this.picTemp.Location = new System.Drawing.Point(363, 56);
            this.picTemp.Name = "picTemp";
            this.picTemp.Size = new System.Drawing.Size(195, 173);
            this.picTemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTemp.TabIndex = 5;
            this.picTemp.TabStop = false;
            this.picTemp.Click += new System.EventHandler(this.picTemp_Click);
            // 
            // ConversorTemperaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblGraus);
            this.Controls.Add(this.picTemp);
            this.Controls.Add(this.txtGraus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblGrausCel);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConversorTemperaturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConversorTemperaturas";
            this.Load += new System.EventHandler(this.ConversorTemperaturas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblGrausCel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnFahrenheit;
        private System.Windows.Forms.RadioButton rbtnKelvin;
        private System.Windows.Forms.TextBox txtGraus;
        private System.Windows.Forms.PictureBox picTemp;
        private System.Windows.Forms.Label lblGraus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Button btnConverter;
    }
}
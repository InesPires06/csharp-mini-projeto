namespace ProjetoFinal_InêsPires
{
    partial class Dificuldade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dificuldade));
            this.btnfacil = new System.Windows.Forms.Button();
            this.btnmédio = new System.Windows.Forms.Button();
            this.btndificil = new System.Windows.Forms.Button();
            this.lblNivel = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnRegras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfacil
            // 
            this.btnfacil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnfacil.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfacil.Location = new System.Drawing.Point(105, 151);
            this.btnfacil.Name = "btnfacil";
            this.btnfacil.Size = new System.Drawing.Size(173, 78);
            this.btnfacil.TabIndex = 0;
            this.btnfacil.Text = "Fácil";
            this.btnfacil.UseVisualStyleBackColor = false;
            this.btnfacil.Click += new System.EventHandler(this.btnfacil_Click);
            // 
            // btnmédio
            // 
            this.btnmédio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnmédio.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmédio.Location = new System.Drawing.Point(284, 151);
            this.btnmédio.Name = "btnmédio";
            this.btnmédio.Size = new System.Drawing.Size(173, 78);
            this.btnmédio.TabIndex = 1;
            this.btnmédio.Text = "Médio";
            this.btnmédio.UseVisualStyleBackColor = false;
            this.btnmédio.Click += new System.EventHandler(this.btnmédio_Click);
            // 
            // btndificil
            // 
            this.btndificil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btndificil.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndificil.Location = new System.Drawing.Point(463, 151);
            this.btndificil.Name = "btndificil";
            this.btndificil.Size = new System.Drawing.Size(173, 78);
            this.btndificil.TabIndex = 2;
            this.btndificil.Text = "Difícil";
            this.btndificil.UseVisualStyleBackColor = false;
            this.btndificil.Click += new System.EventHandler(this.btndificil_Click);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel.Font = new System.Drawing.Font("Gill Sans MT Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(244, 97);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(263, 36);
            this.lblNivel.TabIndex = 3;
            this.lblNivel.Text = "Escolha um nível para jogar:";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSair.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(669, 408);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(119, 30);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnRegras
            // 
            this.btnRegras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegras.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegras.Location = new System.Drawing.Point(669, 372);
            this.btnRegras.Name = "btnRegras";
            this.btnRegras.Size = new System.Drawing.Size(119, 30);
            this.btnRegras.TabIndex = 5;
            this.btnRegras.Text = "Como Jogar?";
            this.btnRegras.UseVisualStyleBackColor = false;
            this.btnRegras.Click += new System.EventHandler(this.btnRegras_Click);
            // 
            // Dificuldade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegras);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.btndificil);
            this.Controls.Add(this.btnmédio);
            this.Controls.Add(this.btnfacil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dificuldade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da memória";
            this.Load += new System.EventHandler(this.fmr2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfacil;
        private System.Windows.Forms.Button btnmédio;
        private System.Windows.Forms.Button btndificil;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnRegras;
    }
}
namespace Conversores_no_WFA
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabConversor = new System.Windows.Forms.TabPage();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtQuilos = new System.Windows.Forms.TextBox();
            this.lblQuilos = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLimparLibra = new System.Windows.Forms.Button();
            this.txtLibraResultado = new System.Windows.Forms.TextBox();
            this.btnCalcularLibra = new System.Windows.Forms.Button();
            this.txtLibras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabConversor.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabConversor);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(565, 259);
            this.tabControl1.TabIndex = 0;
            // 
            // tabConversor
            // 
            this.tabConversor.BackColor = System.Drawing.Color.MistyRose;
            this.tabConversor.Controls.Add(this.btnLimpar);
            this.tabConversor.Controls.Add(this.txtResultado);
            this.tabConversor.Controls.Add(this.btnCalcular);
            this.tabConversor.Controls.Add(this.txtQuilos);
            this.tabConversor.Controls.Add(this.lblQuilos);
            this.tabConversor.Location = new System.Drawing.Point(4, 22);
            this.tabConversor.Name = "tabConversor";
            this.tabConversor.Padding = new System.Windows.Forms.Padding(3);
            this.tabConversor.Size = new System.Drawing.Size(557, 233);
            this.tabConversor.TabIndex = 0;
            this.tabConversor.Text = "Conversor de Libras";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(173, 189);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(196, 30);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.Red;
            this.txtResultado.Location = new System.Drawing.Point(173, 116);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(195, 66);
            this.txtResultado.TabIndex = 5;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(173, 80);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(196, 30);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtQuilos
            // 
            this.txtQuilos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuilos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtQuilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuilos.ForeColor = System.Drawing.Color.Red;
            this.txtQuilos.Location = new System.Drawing.Point(173, 48);
            this.txtQuilos.Multiline = true;
            this.txtQuilos.Name = "txtQuilos";
            this.txtQuilos.Size = new System.Drawing.Size(195, 26);
            this.txtQuilos.TabIndex = 1;
            this.txtQuilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuilos
            // 
            this.lblQuilos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuilos.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuilos.Location = new System.Drawing.Point(55, 3);
            this.lblQuilos.Name = "lblQuilos";
            this.lblQuilos.Size = new System.Drawing.Size(432, 54);
            this.lblQuilos.TabIndex = 0;
            this.lblQuilos.Text = "Digite o Seu Peso";
            this.lblQuilos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Wheat;
            this.tabPage2.Controls.Add(this.btnLimparLibra);
            this.tabPage2.Controls.Add(this.txtLibraResultado);
            this.tabPage2.Controls.Add(this.btnCalcularLibra);
            this.tabPage2.Controls.Add(this.txtLibras);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(557, 233);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conversor de Quilos ";
            // 
            // btnLimparLibra
            // 
            this.btnLimparLibra.Location = new System.Drawing.Point(168, 173);
            this.btnLimparLibra.Name = "btnLimparLibra";
            this.btnLimparLibra.Size = new System.Drawing.Size(202, 23);
            this.btnLimparLibra.TabIndex = 4;
            this.btnLimparLibra.Text = "Limpar";
            this.btnLimparLibra.UseVisualStyleBackColor = true;
            this.btnLimparLibra.Click += new System.EventHandler(this.btnLimparLibra_Click);
            // 
            // txtLibraResultado
            // 
            this.txtLibraResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibraResultado.ForeColor = System.Drawing.Color.Red;
            this.txtLibraResultado.Location = new System.Drawing.Point(168, 110);
            this.txtLibraResultado.Multiline = true;
            this.txtLibraResultado.Name = "txtLibraResultado";
            this.txtLibraResultado.Size = new System.Drawing.Size(201, 56);
            this.txtLibraResultado.TabIndex = 3;
            this.txtLibraResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcularLibra
            // 
            this.btnCalcularLibra.Location = new System.Drawing.Point(168, 80);
            this.btnCalcularLibra.Name = "btnCalcularLibra";
            this.btnCalcularLibra.Size = new System.Drawing.Size(202, 23);
            this.btnCalcularLibra.TabIndex = 2;
            this.btnCalcularLibra.Text = "Calcular";
            this.btnCalcularLibra.UseVisualStyleBackColor = true;
            this.btnCalcularLibra.Click += new System.EventHandler(this.btnCalcularLibra_Click);
            // 
            // txtLibras
            // 
            this.txtLibras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibras.ForeColor = System.Drawing.Color.Red;
            this.txtLibras.Location = new System.Drawing.Point(168, 54);
            this.txtLibras.Name = "txtLibras";
            this.txtLibras.Size = new System.Drawing.Size(201, 22);
            this.txtLibras.TabIndex = 1;
            this.txtLibras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Seu Peso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 259);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.tabControl1.ResumeLayout(false);
            this.tabConversor.ResumeLayout(false);
            this.tabConversor.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConversor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtQuilos;
        private System.Windows.Forms.Label lblQuilos;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnLimparLibra;
        private System.Windows.Forms.TextBox txtLibraResultado;
        private System.Windows.Forms.Button btnCalcularLibra;
        private System.Windows.Forms.TextBox txtLibras;
        private System.Windows.Forms.Label label1;
    }
}


namespace CadastroDeViagens
{
    partial class RegistrarObras
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
            this.textBoxObra = new System.Windows.Forms.TextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.labelObra = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caminhaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selecaoCaminhao = new System.Windows.Forms.ListBox();
            this.caminhaoServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caminhaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caminhaoServiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxObra
            // 
            this.textBoxObra.Location = new System.Drawing.Point(436, 137);
            this.textBoxObra.Multiline = true;
            this.textBoxObra.Name = "textBoxObra";
            this.textBoxObra.Size = new System.Drawing.Size(196, 32);
            this.textBoxObra.TabIndex = 0;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(436, 246);
            this.textBoxValor.Multiline = true;
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(196, 32);
            this.textBoxValor.TabIndex = 1;
            this.textBoxValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // labelObra
            // 
            this.labelObra.AutoSize = true;
            this.labelObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObra.Location = new System.Drawing.Point(496, 102);
            this.labelObra.Name = "labelObra";
            this.labelObra.Size = new System.Drawing.Size(77, 32);
            this.labelObra.TabIndex = 2;
            this.labelObra.Text = "Obra";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.Location = new System.Drawing.Point(401, 211);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(287, 32);
            this.labelValor.TabIndex = 3;
            this.labelValor.Text = "Valor por Viagem(R$)";
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(CadastroDeViagens.Form1);
            // 
            // caminhaoBindingSource
            // 
            this.caminhaoBindingSource.DataSource = typeof(CadastroDeViagens.Caminhao);
            // 
            // selecaoCaminhao
            // 
            this.selecaoCaminhao.DataSource = this.caminhaoServiceBindingSource;
            this.selecaoCaminhao.FormattingEnabled = true;
            this.selecaoCaminhao.ItemHeight = 16;
            this.selecaoCaminhao.Location = new System.Drawing.Point(436, 338);
            this.selecaoCaminhao.Name = "selecaoCaminhao";
            this.selecaoCaminhao.Size = new System.Drawing.Size(196, 84);
            this.selecaoCaminhao.TabIndex = 4;
            // 
            // caminhaoServiceBindingSource
            // 
            this.caminhaoServiceBindingSource.DataSource = typeof(CadastroDeViagens.Services.CaminhaoService);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(466, 443);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(142, 42);
            this.buttonSalvar.TabIndex = 5;
            this.buttonSalvar.Text = "Salvar Obra";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 69);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cadastro de Obras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Caminhões disponíveis";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 557);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 46);
            this.button2.TabIndex = 10;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegistrarObras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1120, 615);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.selecaoCaminhao);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelObra);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.textBoxObra);
            this.Name = "RegistrarObras";
            this.Text = "RegistrarObras";
            this.Load += new System.EventHandler(this.RegistrarObras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caminhaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caminhaoServiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxObra;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label labelObra;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource caminhaoBindingSource;
        private System.Windows.Forms.ListBox selecaoCaminhao;
        private System.Windows.Forms.BindingSource caminhaoServiceBindingSource;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}
namespace CadastroDeViagens
{
    partial class ListaViagens
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
            this.dataViagens = new System.Windows.Forms.DataGridView();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.textTituloValor = new System.Windows.Forms.Label();
            this.textvalor = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataViagens)).BeginInit();
            this.SuspendLayout();
            // 
            // dataViagens
            // 
            this.dataViagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViagens.Location = new System.Drawing.Point(379, 76);
            this.dataViagens.Name = "dataViagens";
            this.dataViagens.RowHeadersWidth = 51;
            this.dataViagens.RowTemplate.Height = 24;
            this.dataViagens.Size = new System.Drawing.Size(568, 484);
            this.dataViagens.TabIndex = 0;
            this.dataViagens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(1032, 268);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(143, 53);
            this.buttonRemover.TabIndex = 1;
            this.buttonRemover.Text = "Remover Viagem";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // textTituloValor
            // 
            this.textTituloValor.AutoSize = true;
            this.textTituloValor.Location = new System.Drawing.Point(1040, 76);
            this.textTituloValor.Name = "textTituloValor";
            this.textTituloValor.Size = new System.Drawing.Size(119, 16);
            this.textTituloValor.TabIndex = 2;
            this.textTituloValor.Text = "Valor do mês atual";
            // 
            // textvalor
            // 
            this.textvalor.AutoSize = true;
            this.textvalor.Location = new System.Drawing.Point(1081, 103);
            this.textvalor.Name = "textvalor";
            this.textvalor.Size = new System.Drawing.Size(48, 16);
            this.textvalor.TabIndex = 3;
            this.textvalor.Text = "R$0,00";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 46);
            this.button2.TabIndex = 10;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListaViagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1263, 572);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textvalor);
            this.Controls.Add(this.textTituloValor);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.dataViagens);
            this.Name = "ListaViagens";
            this.Text = "ListaViagens";
            this.Load += new System.EventHandler(this.ListaViagens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataViagens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataViagens;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Label textTituloValor;
        private System.Windows.Forms.Label textvalor;
        private System.Windows.Forms.Button button2;
    }
}
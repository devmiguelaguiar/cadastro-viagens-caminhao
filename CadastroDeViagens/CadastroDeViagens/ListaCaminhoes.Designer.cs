namespace CadastroDeViagens
{
    partial class ListaCaminhoes
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
            this.dataCaminhao = new System.Windows.Forms.DataGridView();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCaminhao)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCaminhao
            // 
            this.dataCaminhao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCaminhao.Location = new System.Drawing.Point(481, 111);
            this.dataCaminhao.Name = "dataCaminhao";
            this.dataCaminhao.RowHeadersWidth = 51;
            this.dataCaminhao.RowTemplate.Height = 24;
            this.dataCaminhao.Size = new System.Drawing.Size(443, 417);
            this.dataCaminhao.TabIndex = 0;
            // 
            // buttonRemover
            // 
            this.buttonRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemover.Location = new System.Drawing.Point(1073, 260);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(152, 67);
            this.buttonRemover.TabIndex = 1;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(21, 513);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 46);
            this.button2.TabIndex = 9;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListaCaminhoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1339, 613);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.dataCaminhao);
            this.Name = "ListaCaminhoes";
            this.Text = "ListaCaminhoes";
            this.Load += new System.EventHandler(this.ListaCaminhoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCaminhao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCaminhao;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button button2;
    }
}
namespace CadastroDeViagens
{
    partial class Menu
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
            this.buttonCaminhao = new System.Windows.Forms.Button();
            this.buttonObra = new System.Windows.Forms.Button();
            this.buttonViagem = new System.Windows.Forms.Button();
            this.buttonListV = new System.Windows.Forms.Button();
            this.buttonListO = new System.Windows.Forms.Button();
            this.buttonListC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCaminhao
            // 
            this.buttonCaminhao.Location = new System.Drawing.Point(328, 129);
            this.buttonCaminhao.Name = "buttonCaminhao";
            this.buttonCaminhao.Size = new System.Drawing.Size(133, 52);
            this.buttonCaminhao.TabIndex = 0;
            this.buttonCaminhao.Text = "Registrar caminhão";
            this.buttonCaminhao.UseVisualStyleBackColor = true;
            this.buttonCaminhao.Click += new System.EventHandler(this.buttonCaminhao_Click);
            // 
            // buttonObra
            // 
            this.buttonObra.Location = new System.Drawing.Point(546, 129);
            this.buttonObra.Name = "buttonObra";
            this.buttonObra.Size = new System.Drawing.Size(133, 52);
            this.buttonObra.TabIndex = 1;
            this.buttonObra.Text = "Registrar obra";
            this.buttonObra.UseVisualStyleBackColor = true;
            this.buttonObra.Click += new System.EventHandler(this.buttonObra_Click);
            // 
            // buttonViagem
            // 
            this.buttonViagem.Location = new System.Drawing.Point(775, 129);
            this.buttonViagem.Name = "buttonViagem";
            this.buttonViagem.Size = new System.Drawing.Size(133, 52);
            this.buttonViagem.TabIndex = 2;
            this.buttonViagem.Text = "Registrar viagem";
            this.buttonViagem.UseVisualStyleBackColor = true;
            this.buttonViagem.Click += new System.EventHandler(this.buttonViagem_Click);
            // 
            // buttonListV
            // 
            this.buttonListV.Location = new System.Drawing.Point(766, 254);
            this.buttonListV.Name = "buttonListV";
            this.buttonListV.Size = new System.Drawing.Size(133, 52);
            this.buttonListV.TabIndex = 5;
            this.buttonListV.Text = "Lista de viagens";
            this.buttonListV.UseVisualStyleBackColor = true;
            this.buttonListV.Click += new System.EventHandler(this.buttonListV_Click);
            // 
            // buttonListO
            // 
            this.buttonListO.Location = new System.Drawing.Point(546, 254);
            this.buttonListO.Name = "buttonListO";
            this.buttonListO.Size = new System.Drawing.Size(133, 52);
            this.buttonListO.TabIndex = 4;
            this.buttonListO.Text = "Lista de obras";
            this.buttonListO.UseVisualStyleBackColor = true;
            this.buttonListO.Click += new System.EventHandler(this.buttonListO_Click);
            // 
            // buttonListC
            // 
            this.buttonListC.Location = new System.Drawing.Point(328, 254);
            this.buttonListC.Name = "buttonListC";
            this.buttonListC.Size = new System.Drawing.Size(133, 52);
            this.buttonListC.TabIndex = 3;
            this.buttonListC.Text = "Lista de caminhões";
            this.buttonListC.UseVisualStyleBackColor = true;
            this.buttonListC.Click += new System.EventHandler(this.buttonListC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 69);
            this.label1.TabIndex = 6;
            this.label1.Text = "MENU";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1195, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonListV);
            this.Controls.Add(this.buttonListO);
            this.Controls.Add(this.buttonListC);
            this.Controls.Add(this.buttonViagem);
            this.Controls.Add(this.buttonObra);
            this.Controls.Add(this.buttonCaminhao);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCaminhao;
        private System.Windows.Forms.Button buttonObra;
        private System.Windows.Forms.Button buttonViagem;
        private System.Windows.Forms.Button buttonListV;
        private System.Windows.Forms.Button buttonListO;
        private System.Windows.Forms.Button buttonListC;
        private System.Windows.Forms.Label label1;
    }
}
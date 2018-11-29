namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.lblmodelo = new System.Windows.Forms.Label();
            this.lblmarca = new System.Windows.Forms.Label();
            this.lblano = new System.Windows.Forms.Label();
            this.lblcor = new System.Windows.Forms.Label();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtano = new System.Windows.Forms.TextBox();
            this.txtcor = new System.Windows.Forms.TextBox();
            this.btncad = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.dgvCarros = new System.Windows.Forms.DataGridView();
            this.lblcombustivel = new System.Windows.Forms.Label();
            this.combocombustivel = new System.Windows.Forms.ComboBox();
            this.combomarcas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmodelo
            // 
            this.lblmodelo.AutoSize = true;
            this.lblmodelo.Location = new System.Drawing.Point(47, 51);
            this.lblmodelo.Name = "lblmodelo";
            this.lblmodelo.Size = new System.Drawing.Size(42, 13);
            this.lblmodelo.TabIndex = 1;
            this.lblmodelo.Text = "Modelo";
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(47, 132);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(37, 13);
            this.lblmarca.TabIndex = 2;
            this.lblmarca.Text = "Marca";
            // 
            // lblano
            // 
            this.lblano.AutoSize = true;
            this.lblano.Location = new System.Drawing.Point(47, 172);
            this.lblano.Name = "lblano";
            this.lblano.Size = new System.Drawing.Size(26, 13);
            this.lblano.TabIndex = 3;
            this.lblano.Text = "Ano";
            // 
            // lblcor
            // 
            this.lblcor.AutoSize = true;
            this.lblcor.Location = new System.Drawing.Point(47, 97);
            this.lblcor.Name = "lblcor";
            this.lblcor.Size = new System.Drawing.Size(23, 13);
            this.lblcor.TabIndex = 4;
            this.lblcor.Text = "Cor";
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(97, 44);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(170, 20);
            this.txtmodelo.TabIndex = 6;
            // 
            // txtano
            // 
            this.txtano.Location = new System.Drawing.Point(97, 172);
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(170, 20);
            this.txtano.TabIndex = 8;
            // 
            // txtcor
            // 
            this.txtcor.Location = new System.Drawing.Point(97, 94);
            this.txtcor.Name = "txtcor";
            this.txtcor.Size = new System.Drawing.Size(170, 20);
            this.txtcor.TabIndex = 9;
            // 
            // btncad
            // 
            this.btncad.Location = new System.Drawing.Point(335, 149);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(217, 43);
            this.btncad.TabIndex = 10;
            this.btncad.Text = "Cadastrar";
            this.btncad.UseVisualStyleBackColor = true;
            this.btncad.Click += new System.EventHandler(this.btncad_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(335, 94);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(217, 43);
            this.btnlimpar.TabIndex = 11;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // dgvCarros
            // 
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.Location = new System.Drawing.Point(50, 230);
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.Size = new System.Drawing.Size(530, 184);
            this.dgvCarros.TabIndex = 12;
            // 
            // lblcombustivel
            // 
            this.lblcombustivel.AutoSize = true;
            this.lblcombustivel.Location = new System.Drawing.Point(332, 47);
            this.lblcombustivel.Name = "lblcombustivel";
            this.lblcombustivel.Size = new System.Drawing.Size(64, 13);
            this.lblcombustivel.TabIndex = 13;
            this.lblcombustivel.Text = "Combustivel";
            // 
            // combocombustivel
            // 
            this.combocombustivel.FormattingEnabled = true;
            this.combocombustivel.Location = new System.Drawing.Point(402, 43);
            this.combocombustivel.Name = "combocombustivel";
            this.combocombustivel.Size = new System.Drawing.Size(150, 21);
            this.combocombustivel.TabIndex = 14;
            this.combocombustivel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // combomarcas
            // 
            this.combomarcas.FormattingEnabled = true;
            this.combomarcas.Location = new System.Drawing.Point(97, 132);
            this.combomarcas.Name = "combomarcas";
            this.combomarcas.Size = new System.Drawing.Size(170, 21);
            this.combomarcas.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 426);
            this.Controls.Add(this.combomarcas);
            this.Controls.Add(this.combocombustivel);
            this.Controls.Add(this.lblcombustivel);
            this.Controls.Add(this.dgvCarros);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.txtcor);
            this.Controls.Add(this.txtano);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.lblcor);
            this.Controls.Add(this.lblano);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.lblmodelo);
            this.Name = "Form1";
            this.Text = "Cadastro de carro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmodelo;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Label lblano;
        private System.Windows.Forms.Label lblcor;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtano;
        private System.Windows.Forms.TextBox txtcor;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.DataGridView dgvCarros;
        private System.Windows.Forms.Label lblcombustivel;
        private System.Windows.Forms.ComboBox combocombustivel;
        private System.Windows.Forms.ComboBox combomarcas;



        public System.Windows.Forms.DataGridViewCellEventHandler dataGridView1_CellContentClick { get; set; }
    }
}


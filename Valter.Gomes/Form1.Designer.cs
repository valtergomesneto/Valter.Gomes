namespace Valter.Gomes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblCusto = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblCaptura = new System.Windows.Forms.Label();
            this.lblNivelDor = new System.Windows.Forms.Label();
            this.rdButtonSim = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdButtonNao = new System.Windows.Forms.RadioButton();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtNivelDor = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.drGridViemVoo = new System.Windows.Forms.DataGridView();
            this.ID_VOO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_VOO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAPTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIVEL_DOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISTANCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drGridViemVoo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 26);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.drGridViemVoo);
            this.panel2.Location = new System.Drawing.Point(4, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 403);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.lblID);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.btnSalvar);
            this.panel3.Controls.Add(this.txtNivelDor);
            this.panel3.Controls.Add(this.txtDistancia);
            this.panel3.Controls.Add(this.txtCusto);
            this.panel3.Controls.Add(this.txtData);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.lblNivelDor);
            this.panel3.Controls.Add(this.lblCaptura);
            this.panel3.Controls.Add(this.lblDistancia);
            this.panel3.Controls.Add(this.lblCusto);
            this.panel3.Controls.Add(this.lblData);
            this.panel3.Location = new System.Drawing.Point(395, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 359);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnExcluir);
            this.panel4.Controls.Add(this.btnIncluir);
            this.panel4.Location = new System.Drawing.Point(395, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(401, 38);
            this.panel4.TabIndex = 3;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(6, 6);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(116, 23);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(291, 6);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(101, 23);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACME FLIGHT MANAGER";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(12, 46);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(45, 16);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data:";
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusto.Location = new System.Drawing.Point(12, 82);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(51, 16);
            this.lblCusto.TabIndex = 1;
            this.lblCusto.Text = "Custo:";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistancia.Location = new System.Drawing.Point(12, 119);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(77, 16);
            this.lblDistancia.TabIndex = 2;
            this.lblDistancia.Text = "Distância:";
            // 
            // lblCaptura
            // 
            this.lblCaptura.AutoSize = true;
            this.lblCaptura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptura.Location = new System.Drawing.Point(12, 162);
            this.lblCaptura.Name = "lblCaptura";
            this.lblCaptura.Size = new System.Drawing.Size(66, 16);
            this.lblCaptura.TabIndex = 3;
            this.lblCaptura.Text = "Captura:";
            // 
            // lblNivelDor
            // 
            this.lblNivelDor.AutoSize = true;
            this.lblNivelDor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelDor.Location = new System.Drawing.Point(12, 199);
            this.lblNivelDor.Name = "lblNivelDor";
            this.lblNivelDor.Size = new System.Drawing.Size(73, 16);
            this.lblNivelDor.TabIndex = 4;
            this.lblNivelDor.Text = "Nível Dor";
            // 
            // rdButtonSim
            // 
            this.rdButtonSim.AutoSize = true;
            this.rdButtonSim.Location = new System.Drawing.Point(6, 10);
            this.rdButtonSim.Name = "rdButtonSim";
            this.rdButtonSim.Size = new System.Drawing.Size(42, 17);
            this.rdButtonSim.TabIndex = 5;
            this.rdButtonSim.TabStop = true;
            this.rdButtonSim.Text = "Sim";
            this.rdButtonSim.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdButtonNao);
            this.groupBox1.Controls.Add(this.rdButtonSim);
            this.groupBox1.Location = new System.Drawing.Point(95, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 30);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // rdButtonNao
            // 
            this.rdButtonNao.AutoSize = true;
            this.rdButtonNao.Location = new System.Drawing.Point(93, 11);
            this.rdButtonNao.Name = "rdButtonNao";
            this.rdButtonNao.Size = new System.Drawing.Size(45, 17);
            this.rdButtonNao.TabIndex = 6;
            this.rdButtonNao.TabStop = true;
            this.rdButtonNao.Text = "Não";
            this.rdButtonNao.UseVisualStyleBackColor = true;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(95, 46);
            this.txtData.MaxLength = 10;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(297, 20);
            this.txtData.TabIndex = 7;
            this.txtData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtData_KeyPress);
            this.txtData.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtData_KeyUp);
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(94, 78);
            this.txtCusto.MaxLength = 10;
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(298, 20);
            this.txtCusto.TabIndex = 8;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(95, 115);
            this.txtDistancia.MaxLength = 10;
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(297, 20);
            this.txtDistancia.TabIndex = 9;
            // 
            // txtNivelDor
            // 
            this.txtNivelDor.Location = new System.Drawing.Point(94, 199);
            this.txtNivelDor.MaxLength = 2;
            this.txtNivelDor.Name = "txtNivelDor";
            this.txtNivelDor.Size = new System.Drawing.Size(297, 20);
            this.txtNivelDor.TabIndex = 10;
            this.txtNivelDor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNivelDor_KeyUp);
            this.txtNivelDor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNivelDor_KeyPress);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(15, 260);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(107, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(284, 260);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(15, 17);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 16);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(94, 17);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(104, 20);
            this.txtID.TabIndex = 14;
            // 
            // drGridViemVoo
            // 
            this.drGridViemVoo.AllowUserToAddRows = false;
            this.drGridViemVoo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drGridViemVoo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_VOO,
            this.DATA_VOO,
            this.CAPTURA,
            this.NIVEL_DOR,
            this.CUSTO,
            this.DISTANCIA});
            this.drGridViemVoo.Location = new System.Drawing.Point(3, 6);
            this.drGridViemVoo.Name = "drGridViemVoo";
            this.drGridViemVoo.ReadOnly = true;
            this.drGridViemVoo.Size = new System.Drawing.Size(378, 377);
            this.drGridViemVoo.TabIndex = 0;
            this.drGridViemVoo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drGridViemVoo_CellContentClick);
            // 
            // ID_VOO
            // 
            this.ID_VOO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_VOO.HeaderText = "ID_VOO";
            this.ID_VOO.Name = "ID_VOO";
            this.ID_VOO.ReadOnly = true;
            this.ID_VOO.Visible = false;
            this.ID_VOO.Width = 72;
            // 
            // DATA_VOO
            // 
            this.DATA_VOO.HeaderText = "DATA";
            this.DATA_VOO.Name = "DATA_VOO";
            this.DATA_VOO.ReadOnly = true;
            // 
            // CAPTURA
            // 
            this.CAPTURA.HeaderText = "CAPTURA";
            this.CAPTURA.Name = "CAPTURA";
            this.CAPTURA.ReadOnly = true;
            // 
            // NIVEL_DOR
            // 
            this.NIVEL_DOR.HeaderText = "NIVEL DE DOR";
            this.NIVEL_DOR.Name = "NIVEL_DOR";
            this.NIVEL_DOR.ReadOnly = true;
            this.NIVEL_DOR.Width = 140;
            // 
            // CUSTO
            // 
            this.CUSTO.HeaderText = "CUSTO";
            this.CUSTO.Name = "CUSTO";
            this.CUSTO.ReadOnly = true;
            this.CUSTO.Visible = false;
            // 
            // DISTANCIA
            // 
            this.DISTANCIA.HeaderText = "DISTANCIA";
            this.DISTANCIA.Name = "DISTANCIA";
            this.DISTANCIA.ReadOnly = true;
            this.DISTANCIA.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drGridViemVoo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNivelDor;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdButtonNao;
        private System.Windows.Forms.RadioButton rdButtonSim;
        private System.Windows.Forms.Label lblNivelDor;
        private System.Windows.Forms.Label lblCaptura;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.DataGridView drGridViemVoo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_VOO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_VOO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAPTURA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIVEL_DOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISTANCIA;
    }
}


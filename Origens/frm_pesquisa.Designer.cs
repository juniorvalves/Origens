﻿namespace Origens
{
    partial class frm_pesquisa
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPALAVRA_CHAVE = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codcandidatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatoPesquisaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetOrigens = new Origens.DataSetOrigens();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.candidatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.candidatosTableAdapter = new Origens.DataSetOrigensTableAdapters.candidatosTableAdapter();
            this.candidatoPesquisaTableAdapter = new Origens.DataSetOrigensTableAdapters.candidatoPesquisaTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatoPesquisaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrigens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar:";
            // 
            // txtPALAVRA_CHAVE
            // 
            this.txtPALAVRA_CHAVE.Location = new System.Drawing.Point(74, 12);
            this.txtPALAVRA_CHAVE.Name = "txtPALAVRA_CHAVE";
            this.txtPALAVRA_CHAVE.Size = new System.Drawing.Size(413, 20);
            this.txtPALAVRA_CHAVE.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codcandidatoDataGridViewTextBoxColumn,
            this.Nome,
            this.CPF,
            this.Nascimento,
            this.Estado,
            this.Cidade});
            this.dataGridView1.DataSource = this.candidatoPesquisaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(585, 270);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // codcandidatoDataGridViewTextBoxColumn
            // 
            this.codcandidatoDataGridViewTextBoxColumn.DataPropertyName = "cod_candidato";
            this.codcandidatoDataGridViewTextBoxColumn.HeaderText = "cod_candidato";
            this.codcandidatoDataGridViewTextBoxColumn.Name = "codcandidatoDataGridViewTextBoxColumn";
            this.codcandidatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // Nascimento
            // 
            this.Nascimento.DataPropertyName = "Nascimento";
            this.Nascimento.HeaderText = "Nascimento";
            this.Nascimento.Name = "Nascimento";
            this.Nascimento.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "Cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // candidatoPesquisaBindingSource
            // 
            this.candidatoPesquisaBindingSource.DataMember = "candidatoPesquisa";
            this.candidatoPesquisaBindingSource.DataSource = this.dataSetOrigens;
            // 
            // dataSetOrigens
            // 
            this.dataSetOrigens.DataSetName = "DataSetOrigens";
            this.dataSetOrigens.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(408, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Editar o candidato selecionado";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(493, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // candidatosBindingSource
            // 
            this.candidatosBindingSource.DataMember = "candidatos";
            this.candidatosBindingSource.DataSource = this.dataSetOrigens;
            // 
            // candidatosTableAdapter
            // 
            this.candidatosTableAdapter.ClearBeforeFill = true;
            // 
            // candidatoPesquisaTableAdapter
            // 
            this.candidatoPesquisaTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frm_pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 384);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPALAVRA_CHAVE);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_pesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_pesquisa";
            this.Load += new System.EventHandler(this.frm_pesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatoPesquisaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrigens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPALAVRA_CHAVE;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetOrigens dataSetOrigens;
        private System.Windows.Forms.BindingSource candidatosBindingSource;
        private DataSetOrigensTableAdapters.candidatosTableAdapter candidatosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcandidatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.BindingSource candidatoPesquisaBindingSource;
        private DataSetOrigensTableAdapters.candidatoPesquisaTableAdapter candidatoPesquisaTableAdapter;
        private System.Windows.Forms.Button button3;
    }
}
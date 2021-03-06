﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Origens
{
    public partial class frm_atualizar : Form
    {
        public frm_atualizar()
        {
            InitializeComponent();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void frm_atualizar_Load(object sender, EventArgs e) 
        {
            // TODO: This line of code loads data into the 'dataSetOrigens.doencas' table. You can move, or remove it, as needed.
            this.doencasTableAdapter.Fill(this.dataSetOrigens.doencas);
            // TODO: This line of code loads data into the 'dataSetOrigens.escolaridades' table. You can move, or remove it, as needed.
            this.escolaridadesTableAdapter.Fill(this.dataSetOrigens.escolaridades);
            // TODO: This line of code loads data into the 'dataSetOrigens.temperamentos' table. You can move, or remove it, as needed.
            this.temperamentosTableAdapter.Fill(this.dataSetOrigens.temperamentos);
            // TODO: This line of code loads data into the 'dataSetOrigens.view_faixa_altura' table. You can move, or remove it, as needed.
            this.view_faixa_alturaTableAdapter.Fill(this.dataSetOrigens.view_faixa_altura);
            // TODO: This line of code loads data into the 'dataSetOrigens.tipos_cabelo' table. You can move, or remove it, as needed.
            this.tipos_cabeloTableAdapter.Fill(this.dataSetOrigens.tipos_cabelo);
            // TODO: This line of code loads data into the 'dataSetOrigens.cores_pele' table. You can move, or remove it, as needed.
            this.cores_peleTableAdapter.Fill(this.dataSetOrigens.cores_pele);
            // TODO: This line of code loads data into the 'dataSetOrigens.cores_cabelo' table. You can move, or remove it, as needed.
            this.cores_cabeloTableAdapter.Fill(this.dataSetOrigens.cores_cabelo);
            // TODO: This line of code loads data into the 'dataSetOrigens.cores_olho' table. You can move, or remove it, as needed.
            this.cores_olhoTableAdapter.Fill(this.dataSetOrigens.cores_olho);
            // TODO: This line of code loads data into the 'dataSetOrigens.estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.dataSetOrigens.estados);
        }

      

        private System.Nullable<int> obterValorCombo(ComboBox c)
        {
            Int32 valorCombo;
            try
            {
                if (Int32.TryParse(c.SelectedValue.ToString(), out valorCombo))
                {
                    if (valorCombo < 0)
                        return null;
                    else
                        return valorCombo;
                }
                else
                {
                    return Convert.ToInt32(((System.Data.DataRowView)c.SelectedValue).Row[0]);

                }
            }
            catch
            {
                return null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSetOrigensTableAdapters.candidatosTableAdapter adaptador = new DataSetOrigensTableAdapters.candidatosTableAdapter();
            try
            {
                Candidato c = new Candidato()
                {
                    nome = txtNOME.Text,
                    cpf = txtCPF.Text,
                    cep = txtCEP.Text,
                    telefone = txtTELEFONE.Text,
                    dataNascimento = dtpNASCIMENTO.Value,
                    codEstado = this.obterValorCombo(cboESTADO),
                    cidade = txtCIDADE.Text,
                    endereco = txtENDERECO.Text,
                    complemento = txtCOMPLEMENTO.Text,
                    codCorOlho = this.obterValorCombo(cboCOR_OLHOS),
                    corCorCabelo = this.obterValorCombo(cboCOR_CABELO),
                    codCorPele = Convert.ToInt32(cboCOR_PELE.SelectedValue),
                    codTipoCabelo = this.obterValorCombo(cboTIPO_CABELO),
                    codFaixaAltura = this.obterValorCombo(cboFAIXA_ALTURA),
                    codTemperamento = this.obterValorCombo(cboTEMPERAMENTO),
                    codEscolaridade = this.obterValorCombo(cboESCOLARIDADE),
                    codDoenca = this.obterValorCombo(cboDOENCA),
                    praticarEsporte = cboPRATICA_ESPORTE.SelectedText == "Sim",
                    le = cboLE.SelectedText == "Sim"
                };
                adaptador.Update(
                    c.nome, c.cpf, c.dataNascimento, c.telefone, c.codEstado, c.cidade,
                    c.endereco, c.complemento, c.cep, c.codCorOlho, c.corCorCabelo,
                    c.codCorPele, c.codTipoCabelo, c.codFaixaAltura, c.codTemperamento,
                    c.codEscolaridade, c.codDoenca, c.praticarEsporte, c.le, Convert.ToInt32(c.codigo),
                    c.nome, c.cpf, c.dataNascimento, c.telefone, c.codEstado, c.cidade,
                    c.endereco, c.complemento, c.cep, c.codCorOlho, c.corCorCabelo,
                    c.codCorPele, c.codTipoCabelo, c.codFaixaAltura, c.codTemperamento,
                    c.codEscolaridade, c.codDoenca, c.praticarEsporte, c.le, Convert.ToInt32(c.codigo));

                MessageBox.Show("Candidato Cadastrado com sucesso");
                this.Close();
                this.Dispose();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ocorreu um problema ao tentar cadastrar o candidato. Tente novamente mais tarde.");
            }
        }

        public void carregarFormulario(int codigoCandidato)
        {
            try
            {
                Candidato c = new Candidato();
                c.codigo = codigoCandidato;
                DataSetOrigensTableAdapters.candidatosTableAdapter adaptador = new DataSetOrigensTableAdapters.candidatosTableAdapter();
                DataSetOrigens.candidatosDataTable candidatosRows = adaptador.ObterCandidatoPeloCodigo(c.codigo);
                DataSetOrigens.candidatosRow row = candidatosRows[0];

                txtCODIGO.Text = c.codigo.ToString();
                txtNOME.Text = row.nom_candidato;
                txtCPF.Text = row.cpf_candidato;
                dtpNASCIMENTO.Value = row.dat_nascimento_candidato;
                txtTELEFONE.Text = row.tel_candidato;
                cboESTADO.SelectedValue = row.cod_estado;
                txtCIDADE.Text = row.cidade_candidato;
                txtCOMPLEMENTO.Text = row.complemento_candidato;
                txtCEP.Text = row.cep_candidato;
                cboCOR_OLHOS.SelectedValue = row.cod_cor_olho;
                cboCOR_CABELO.SelectedValue = row.cod_cor_cabelo;
                cboCOR_PELE.SelectedValue = row.cod_cor_pele;
                cboTIPO_CABELO.SelectedValue = row.cod_tipo_cabelo;
                cboFAIXA_ALTURA.SelectedValue = row.cod_faixa_altura;
                cboTEMPERAMENTO.SelectedValue = row.cod_temperamento;
                cboESCOLARIDADE.SelectedValue = row.cod_escolaridade;
                cboDOENCA.SelectedValue = row.cod_doenca;



            }
            catch (Exception exc)
            {
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Candidato c = new Candidato();
                c.codigo = 29;
                DataSetOrigensTableAdapters.candidatosTableAdapter adaptador = new DataSetOrigensTableAdapters.candidatosTableAdapter();
                DataSetOrigens.candidatosDataTable candidatosRows =  adaptador.ObterCandidatoPeloCodigo(c.codigo);
                DataSetOrigens.candidatosRow row = candidatosRows[0];

                txtCODIGO.Text = c.codigo.ToString();
                txtNOME.Text = row.nom_candidato;
                txtCPF.Text = row.cpf_candidato;
                dtpNASCIMENTO.Value = row.dat_nascimento_candidato;
                txtTELEFONE.Text = row.tel_candidato;
               

            }
            catch (Exception exc)
            {
            }
        }

        private void frm_atualizar_Shown(object sender, EventArgs e)
        {
            frm_pesquisa pesquisa = new frm_pesquisa();
            pesquisa.formularioAtualizacao = this;
            pesquisa.ShowDialog();
        }
    }
}

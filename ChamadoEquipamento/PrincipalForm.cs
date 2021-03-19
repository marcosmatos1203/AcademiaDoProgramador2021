using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PrincipalForm : Form
    {
        EquipamentoMetodos eqMetodo = new EquipamentoMetodos();
        ChamadoMetodos chMetodo = new ChamadoMetodos();
        private int indexListEquipamento;
        private int indexListChamado;

        public PrincipalForm()
        {
            InitializeComponent();
            carregaListEquipamento();
            carregaListChamado();
            gbxEditarNovoEquipamento.Enabled = false;
            gbxEditarNovoChamado.Enabled = false;
        }
        public void limpaCamposEquipamento()
        {
            dtpEquipamento.Value=DateTime.Today;
            txtFabricanteEquipamento.Clear();
            txtNomeEquipamento.Clear();
            txtSerieEquipamento.Clear();
            txtValorEquipamento.Clear();
            gbxEditarNovoEquipamento.Enabled = false;
        }
        public void limpaCamposChamdo()
        {
            dtpChamado.Value = DateTime.Today;
            txtDescricaoChamado.Clear();
            txtTituloChamado.Clear();
            cbxEquipamentoChamado.Items.Clear();            
            gbxEditarNovoChamado.Enabled = false;
        }
        private void salvarNovoEquipamento()
        {
            eqMetodo.InserirEquipamento(txtNomeEquipamento.Text, txtSerieEquipamento.Text,
                txtFabricanteEquipamento.Text, Convert.ToDecimal(txtValorEquipamento.Text),
                Convert.ToDateTime(dtpEquipamento.Text));
                
        }
        private void salvarNovoChamado()
        {
            
            chMetodo.InserirChamado(txtTituloChamado.Text, txtDescricaoChamado.Text,
                eqMetodo.equipamentoSelecionado(cbxEquipamentoChamado.Text), 
                Convert.ToDateTime(dtpChamado.Text));

        }
        public bool validaNome()
        {
            if (txtNomeEquipamento.Text.Length > 5)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Nome deve ter 6 ou mais caracter");
                txtNomeEquipamento.Focus();
                return false;
            }
            
        }
        private void atualizaEquipamento()
        {
            eqMetodo.alteraEquipamento(indexListEquipamento, txtNomeEquipamento.Text, txtSerieEquipamento.Text, 
                txtFabricanteEquipamento.Text, Convert.ToDecimal(txtValorEquipamento.Text), Convert.ToDateTime(
                    dtpEquipamento.Text));
        }
        private void atualizaChamado()
        {
            chMetodo.alteraChamado(indexListChamado, txtTituloChamado.Text,
                txtDescricaoChamado.Text, eqMetodo.equipamentoSelecionado(cbxEquipamentoChamado.Text),
                 Convert.ToDateTime(dtpChamado.Text));
        }
        public void carregaListChamado()
        {
            lvChamado.Clear();
            lvChamado.Columns.Add("TITULO", 80, HorizontalAlignment.Left);
            lvChamado.Columns.Add("EQUIPAMENTO", 90, HorizontalAlignment.Left);
            lvChamado.Columns.Add("DATA A.", 60, HorizontalAlignment.Left);
            lvChamado.Columns.Add("DIAS A.", 60, HorizontalAlignment.Left);

            foreach (var item in chMetodo.retornaListaChamado())
            {
                lvChamado.Items.Add(new ListViewItem(new string[] { item.Titulo,
                    item.Equipamento.Nome, item.DataAbertura.ToShortDateString(), item.NDias.ToString()}));
            }
        }
        public void carregaListEquipamento()
        {
            lvEquipamento.Clear();
            lvEquipamento.Columns.Add("NOME", 140, HorizontalAlignment.Left);
            lvEquipamento.Columns.Add("N. SERIE", 70, HorizontalAlignment.Left);
            lvEquipamento.Columns.Add("FABRICANTE", 80, HorizontalAlignment.Left);

            foreach (var item in eqMetodo.retornaListaEquipamento())
            {
                lvEquipamento.Items.Add(new ListViewItem(new string[] { item.Nome,
                    item.NumeroSerie, item.Fabricante }));
            }
        }
        private void btnNovoEquipamento_Click(object sender, EventArgs e)
        {
            btnSalvarEquipamento.Text = "Salvar";
            gbxEditarNovoEquipamento.Enabled = true;
            btnExcluirEquipamento.Enabled = false;
            btnEditarEquipamento.Enabled = false;
            btnNovoEquipamento.Enabled = false;
            dtpEquipamento.Value = DateTime.Today;
        }

        private void btnSalvarEquipamento_Click(object sender, EventArgs e)
        {
            if (btnSalvarEquipamento.Text == "Salvar")
            {
                if (validaNome() == true)
                {
                    salvarNovoEquipamento();
                    limpaCamposEquipamento();
                    carregaListEquipamento();
                    MessageBox.Show("Equipamento gravado");
                }
            }
            else
            {
                if (validaNome() == true)
                {
                    atualizaEquipamento();
                    limpaCamposEquipamento();
                    carregaListEquipamento();
                    MessageBox.Show("Equipamento Atualizado");
                }

            }
            btnEditarEquipamento.Enabled = true;
            btnExcluirEquipamento.Enabled = true;
            btnNovoEquipamento.Enabled = true;
        }

        private void btnEditarEquipamento_Click(object sender, EventArgs e)
        {
            if (lvEquipamento.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione item para editar.");
            }
            else
            {
                EquipamentoDados eqD = eqMetodo.equipamentoSelecionado(lvEquipamento.SelectedItems[0].
                    SubItems[0].Text);

                txtNomeEquipamento.Text = eqD.Nome;
                txtSerieEquipamento.Text = eqD.NumeroSerie;
                txtValorEquipamento.Text = eqD.Preco.ToString();
                txtFabricanteEquipamento.Text = eqD.Fabricante;
                dtpEquipamento.Text = eqD.DataFabricacao.ToShortDateString();
                btnSalvarEquipamento.Text = "Atualizar";
                gbxEditarNovoEquipamento.Enabled = true;
            }
        }

        private void btnExcluirEquipamento_Click(object sender, EventArgs e)
        {
            if (lvEquipamento.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione item para Excluir.");
            }
            else
            {
                eqMetodo.deletarEquipamento(lvEquipamento.SelectedItems[0].SubItems[0].Text);
                carregaListEquipamento();
                MessageBox.Show("Equipamento Excluido.");
            }
        }

        public void carregaCbxEquipamento()
        {
            foreach (var item in eqMetodo.retornaListaEquipamento())
            {
                cbxEquipamentoChamado.Items.Add(item.Nome);
            }
        }
        private void btnNovoChamado_Click(object sender, EventArgs e)
        {
            btnSalvarChamado.Text = "Salvar";
            gbxEditarNovoChamado.Enabled = true;
            btnEditarChamado.Enabled = false;
            btnNovoChamado.Enabled = false;
            carregaCbxEquipamento();
            dtpChamado.Value = DateTime.Today;
        }

        private void btnCancelarEquipamento_Click(object sender, EventArgs e)
        {
            limpaCamposEquipamento();
            btnNovoEquipamento.Enabled = true;
            btnEditarEquipamento.Enabled = true;
            btnExcluirEquipamento.Enabled = true;
            gbxEquipamento.Enabled = false;
        }

        private void btnSalvarChamado_Click(object sender, EventArgs e)
        {
            if (btnSalvarChamado.Text == "Salvar")
            {
                salvarNovoChamado();
                limpaCamposChamdo();
                carregaListChamado();
                gbxEditarNovoChamado.Enabled = false;
                btnEditarChamado.Enabled = true;
                btnNovoChamado.Enabled = true;
                MessageBox.Show("Chamado gravado");

            }
            else
            {
                atualizaChamado();
                limpaCamposChamdo();
                carregaListChamado();
                MessageBox.Show("Chamado Atualizado");
            }
            btnEditarEquipamento.Enabled = true;
            btnExcluirEquipamento.Enabled = true;
            btnNovoEquipamento.Enabled = true;
        }

        private void btnCancelarChamado_Click(object sender, EventArgs e)
        {
            limpaCamposChamdo();
            gbxEditarNovoChamado.Enabled = false;
            btnNovoChamado.Enabled = true;
            btnEditarChamado.Enabled = true;
        }

        private void btnEditarChamado_Click(object sender, EventArgs e)
        {
            if (lvChamado.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um chamado para editar.");
            }
            else
            {
                ChamadoDados eqD = chMetodo.chamadoSelecionado(lvChamado.SelectedItems[0].
                    SubItems[0].Text);

                txtTituloChamado.Text = eqD.Titulo;
                dtpChamado.Text = eqD.DataAbertura.ToShortDateString();
                txtDescricaoChamado.Text = eqD.Descricao;
                btnSalvarChamado.Text = "Atualizar";
                gbxEditarNovoChamado.Enabled = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    class EquipamentoMetodos
    {

        public static EquipamentoDados eqDado = new EquipamentoDados();


        public EquipamentoDados equipamentoSelecionado(String nome)
        {
            EquipamentoDados novoEqDado = eqDado.ListaEquipamento.FirstOrDefault(a => a.Nome == nome);
            return novoEqDado;
        }
        


        public void deletarEquipamento(String nome)
        {
            eqDado.ListaEquipamento.RemoveAll(delegate (EquipamentoDados p) { return p.Nome == nome; });
        }
        public void alteraEquipamento(int i,String nome, String serie, String fabricante,
            decimal preco, DateTime data)
        {
            eqDado.ListaEquipamento[i].Nome = nome;
            eqDado.ListaEquipamento[i].NumeroSerie = serie;
            eqDado.ListaEquipamento[i].Fabricante = fabricante;
            eqDado.ListaEquipamento[i].Preco = preco;
            eqDado.ListaEquipamento[i].DataFabricacao = data;
        }

        public void InserirEquipamento(String nome, String serie, String fabricante,
            decimal preco,DateTime data)
        {
            EquipamentoDados eqDado1 = new EquipamentoDados();
            eqDado1.Nome = nome;
            eqDado1.NumeroSerie = serie;
            eqDado1.Fabricante = fabricante;
            eqDado1.Preco = preco;
            eqDado1.DataFabricacao = data;
            eqDado1.IdEquipamento = eqDado.ListaEquipamento.Count + 1;
            eqDado.ListaEquipamento.Add(eqDado1);
        }
        public List<EquipamentoDados> retornaListaEquipamento()
        {
            return eqDado.ListaEquipamento;
        }
       
    }
}

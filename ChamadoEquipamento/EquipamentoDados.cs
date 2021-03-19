using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    class EquipamentoDados
    {
        private String nome, numeroSerie, fabricante;
        private decimal preco;
        private DateTime dataFabricacao;
        private int idEquipamento;

        List<EquipamentoDados> listaEqDados = new List<EquipamentoDados>();

        public EquipamentoDados(){}
        public EquipamentoDados(string nome, string numeroSerie, string fabricante, 
            decimal preco, DateTime dataFabricacao, int idEquipamento)
        {
            this.Nome = nome;
            this.NumeroSerie = numeroSerie;
            this.Fabricante = fabricante;
            this.Preco = preco;
            this.DataFabricacao = dataFabricacao;
            this.IdEquipamento = idEquipamento;
        }

        public string Nome { get => nome; set => nome = value; }
        public string NumeroSerie { get => numeroSerie; set => numeroSerie = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }
        public decimal Preco { get => preco; set => preco = value; }
        public DateTime DataFabricacao { get => dataFabricacao; set => dataFabricacao = value; }
        public int IdEquipamento { get => idEquipamento; set => idEquipamento = value; }
        internal List<EquipamentoDados> ListaEquipamento { get => listaEqDados; set => listaEqDados = value; }
    }
}

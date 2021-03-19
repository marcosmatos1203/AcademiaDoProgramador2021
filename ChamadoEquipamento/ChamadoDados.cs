using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    class ChamadoDados
    {
        private String titulo, descricao;
        private EquipamentoDados equipamento;
        private DateTime dataAbertura;
        private int nDias;
        private List<ChamadoDados> listaChamado = new List<ChamadoDados>();
        public ChamadoDados(string titulo, string descricao, EquipamentoDados equipamento, DateTime dataAbertura, int nDias)
        {
            this.titulo = titulo;
            this.descricao = descricao;
            this.equipamento = equipamento;
            this.dataAbertura = dataAbertura;
            this.NDias = nDias;
        }
        public ChamadoDados(){}
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime DataAbertura { get => dataAbertura; set => dataAbertura = value; }
        public int NDias { get => nDias; set => nDias = value; }
        internal EquipamentoDados Equipamento { get => equipamento; set => equipamento = value; }
        internal List<ChamadoDados> ListaChamado { get => listaChamado; set => listaChamado = value; }
        
    }
}

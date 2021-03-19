using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    class ChamadoMetodos
    {
        public static ChamadoDados chDado = new ChamadoDados();
        public void InserirChamado(String titulo, String descricao, EquipamentoDados equipamento, DateTime data)
        {
            ChamadoDados chDado1 = new ChamadoDados();
            chDado1.Titulo = titulo;
            chDado1.Descricao = descricao;
            chDado1.Equipamento = equipamento;
            chDado1.DataAbertura = data;
            chDado.ListaChamado.Add(chDado1);
        }
        public List<ChamadoDados> retornaListaChamado()
        {
            return chDado.ListaChamado;
        }
        public void alteraChamado(int i, String titulo, String descricao, EquipamentoDados equipamento,
             DateTime data)
        {
            chDado.ListaChamado[i].Titulo = titulo;
            chDado.ListaChamado[i].Descricao = descricao;
            chDado.ListaChamado[i].Equipamento = equipamento;
            chDado.ListaChamado[i].DataAbertura = data;
        }
        public ChamadoDados chamadoSelecionado(String titulo)
        {
            ChamadoDados novochDado = chDado.ListaChamado.FirstOrDefault(a => a.Titulo == titulo);
            return novochDado;
        }
        public int diasAbertoChamado(DateTime dataAbertura)
        {
            int dias = 0;
            DateTime dataAgora = DateTime.Today;
            dias = Convert.ToInt32( dataAgora.Subtract(dataAgora));
            return dias;
        }
        public void alteraChamado(int i, String titulo, String descricao, EquipamentoDados equipamento,
            decimal preco, DateTime data)
        {
            chDado.ListaChamado[i].Titulo = titulo;
            chDado.ListaChamado[i].Descricao = descricao;
            chDado.ListaChamado[i].Equipamento = equipamento;
            chDado.ListaChamado[i].DataAbertura = data;
        }
    }
}

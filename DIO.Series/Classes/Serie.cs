using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        //Atributos

        private Genero Genero { get; set; }
        private string Título { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido {get; set;}

        //Metodos

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.id = id;
            this.Genero = genero;
            this.Título = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.Genero + System.Environment.NewLine;
            retorno += "Titulo: " + this.Título + System.Environment.NewLine;
            retorno += "Descrição " + this.Descricao + System.Environment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Título;
        }
        public int retornaId()
        {
            return this.id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

    }
}
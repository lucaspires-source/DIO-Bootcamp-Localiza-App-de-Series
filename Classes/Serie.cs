using System;

namespace DIO.Series
{
    public class Serie: EntidadeBase
    {

        //Atributos
        private Genero Genero{get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}
        private bool Excluido {get; set;}

        //Metodos

        public Serie (int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        //Transforma os valores em String
        public override string ToString()
        {   

            string retorno = "";

            retorno += "Gênero: " + this.Genero  + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao  + Environment.NewLine;
            retorno += "Ano de lançamento: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;

        }


        //Retorna o Titulo
        public string retornaTitulo()
        {
            return this.Titulo;
        }
        

        //retorna o ID
        public int retornaId()
        {
            return this.Id;
        }

        //Retorna o Excluido
        public bool retornaExcluido()
		{
			return this.Excluido;
		}


        //Exclui
        public void Excluir() {
            this.Excluido = true;
        }
    }
}

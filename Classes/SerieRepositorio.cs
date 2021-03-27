using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        

        public void Atualiza(int id, Serie objeto)
		{
			throw new NotImplementedException();
		}

		public void Exclui(int id)
		{
			throw new NotImplementedException();
		}

		public void Insere(Serie objeto)
		{
		throw new NotImplementedException();
		}

		public List<Serie> Lista()
		{
			throw new NotImplementedException();
		}

		public int ProximoId()
		{
			throw new NotImplementedException();
		}

		public Serie RetornaPorId(int id)
		{
			throw new NotImplementedException();
		}
    }
}
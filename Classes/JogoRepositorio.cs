using System;
using System.Collections.Generic;
using APP_de_cadastro_de_jogos_em_.NET.Interfaces;

namespace APP_de_cadastro_de_jogos_em_.NET
{
    public class JogoRepositorio : IRepositorio<Jogo>
	{
        private List<Jogo> listaJogo = new List<Jogo>();
		public void Atualiza(int id, Jogo objeto)
		{
			listaJogo[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaJogo[id].Excluir();
		}

		public void Insere(Jogo objeto)
		{
			listaJogo.Add(objeto);
		}

		public List<Jogo> Lista()
		{
			return listaJogo;
		}

		public int ProximoId()
		{
			return listaJogo.Count;
		}

		public Jogo RetornaPorId(int id)
		{
			return listaJogo[id];
		}
	}
}
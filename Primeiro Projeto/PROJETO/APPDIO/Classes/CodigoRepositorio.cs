using system;
using system.Collections.Generic;
using APPDIO.Interfaces;

namespace APPDIO
{
    public class CodigoRepositorio : IRepositorio<Codigo>
    {
        private list<Codigo> ListaCodigo = new list<Codigo>();

        public void Atualiza(int ID, Codigo Entidade)
        {
            ListaCodigo [ID] = Entidade;
        }
        
        public void Exclui(int ID)
        {
            ListaCodigo[ID].Excluir();
        }        

        public void Insere(Codigo Entidade)
        {
            ListaCodigo.Add(Entidade);
        }

        public  list<codigo> Lista()
        {
            return ListaCodigo;
        }

        public int ProximoID()
        {
            return ListaCodigo.Count;
        }

        public Codigo RetornaPorID(int ID)
        {
            return ListaCodigo[ID];
        }
    }
}
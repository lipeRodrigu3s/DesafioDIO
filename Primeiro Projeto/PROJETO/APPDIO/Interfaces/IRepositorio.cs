using system.Collections.Generic;

namespace APPDIO.Interfaces
{
    public interface IRepositorio<T>
    {
        list<T> lista();
        T RetornaPorID(int ID);
        void Insere(T Entidade);
        void Exclui(int ID);
        void Atualiza(int ID, T Entidade);
        int ProximoID();

    }
}
using System;

namespace Obligatorio.Clases.Agenda
{
    public interface IConsulta
    {
        string getTipo();
        int Costo();
        string Descripcion();

        DateTime Fecha();

        bool Pagada();
        void setPagada(bool pagada);

        string CedulaFuncionario();

        string CedulaDueño();

        string CedulaMascotra();
    }
}
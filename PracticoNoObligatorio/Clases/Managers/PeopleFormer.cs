using PracticoNoObligatorio.Clases.Persona;

namespace PracticoNoObligatorio.Clases.Managers
{
    public class PeopleFormer
    {
        public IPersona MakeOne(string type, string name)
        {
            IPersona p = null;
            switch (type)
            {
                case TiposPersonas.Cliente:
                    p = new Cliente(name);
                    break;
                case TiposPersonas.Desarrollador:
                    p = new Desarrollador(name);
                    break;
                case TiposPersonas.Administador:
                    p = new Administador(name);
                    break;
            }
            return p;
        }
        
    }
}
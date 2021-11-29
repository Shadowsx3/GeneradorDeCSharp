namespace PracticoNoObligatorio.Clases
{
    public class PeopleFormer
    {
        public IPersona MakeOne(string type, string name)
        {
            IPersona p = null;
            switch (type)
            {
                case "Cliente":
                    p = new Cliente(name);
                    break;
                case "Desarrollador":
                    p = new Desarrollador(name);
                    break;
                case "Administrador":
                    p = new Administador(name);
                    break;
            }
            return p;
        }
        
    }
}
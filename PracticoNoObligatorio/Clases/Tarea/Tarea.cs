namespace PracticoNoObligatorio.Clases
{
    public class Tarea : ITarea
    {
        private Cliente _sugeridaPor;
        private Desarrollador _encargado;
        private bool _aprobada;
        private bool _realizada;
        private string _actividad;

        public Tarea(Cliente sugeridaPor, string actividad)
        {
            _sugeridaPor = sugeridaPor;
            _actividad = actividad;
            _aprobada = false;
            _realizada = false;
        }

        public Cliente SugeridaPor
        {
            get => _sugeridaPor;
            set => _sugeridaPor = value;
        }

        public Desarrollador Encargado
        {
            get => _encargado;
            set => _encargado = value;
        }

        public bool Aprobada
        {
            get => _aprobada;
            set => _aprobada = value;
        }

        public bool Realizada
        {
            get => _realizada;
            set => _realizada = value;
        }

        public string Actividad
        {
            get => _actividad;
            set => _actividad = value;
        }
        
        public void CambiarEstado(bool estado)
        {
            throw new System.NotImplementedException();
        }

        public void Encargar(ITrabajador trabajador)
        {
            throw new System.NotImplementedException();
        }

        public void Realizar()
        {
            throw new System.NotImplementedException();
        }
    }
}
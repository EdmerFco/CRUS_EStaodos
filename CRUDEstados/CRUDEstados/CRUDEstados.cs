using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstados
{

    public class CRUDEstados
    {

        static Dictionary<int, Estados> _Estados = new Dictionary<int, Estados>();
      
        public Dictionary<int, Estados> ConsultarTodos()
        {
            return _Estados;
        }
        public  Estados ConsultarUno(int idEstado)
        {
            Estados _estados = new Estados();

            if (_Estados.ContainsKey(idEstado))
            {
                _estados = _Estados[idEstado];
            }
            return _estados;
        }
        public static void Agregar(Estados estado)
        {

            _Estados.Add(estado.Id,estado);

        }
        public void Actualizar( Estados est )
        {
          //  Estados _estados = new Estados();


            if (_Estados.ContainsKey(est.Id))
            {
                //_estados = _Estados[est.Id];

                _Estados[est.Id] = est;
            }
        }

        public void Elimar(Estados est)
        {
            _Estados.Remove(est.Id);
        }

    }
}

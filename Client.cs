using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DI.Understanding
{
    public class Client
    {
        // crear campos privados q van a guardar la instancia Service1,Service2
        private Service1 _service1;
        private Service2 _service2;

            public Client()

        // en el constructor los vamos a inicializarlos
        {
            this._service1 = new Service1();
            this._service2 = new Service2();

        }

        // crear el ServeMethod q va a utilizar el metodo de cada uno de los servicios
        public void ServeMethod()
        {
            this._service1.Serve();
            this._service2.Serve();
        }

}
}

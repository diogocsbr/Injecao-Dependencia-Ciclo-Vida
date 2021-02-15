using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApplication7.Interface;

namespace WebApplication7.Services
{
    public class ServicosScoped : IServicosScoped
    {
        public int i;
        public Guid Id;

        public ServicosScoped()
        {
            Id = Guid.NewGuid();
            i = 0;
        }

        public Guid Identificador()
        {
            return Id;
        }

        public int SomarUm()
        {
            i++;
            return i;
        }
    }
    public class ServicosTransient : IServicosTransient
    {
        public int i;
        public Guid Id;

        public ServicosTransient()
        {
            Id = Guid.NewGuid();
            i = 0;
        }

        public Guid Identificador()
        {
            return Id;
        }

        public int SomarUm()
        {
            i++;
            return i;
        }
    }
    public class ServicosSingleton : IServicosSingleton
    {
        public int i;
        public Guid Id;

        public ServicosSingleton()
        {
            Id = Guid.NewGuid();
            i = 0;
        }

        public Guid Identificador()
        {
            return Id;
        }

        public int SomarUm()
        {
            i++;
            return i;
        }
    }
}

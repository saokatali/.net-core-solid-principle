using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciple.DIP
{
    public class ServiceLocator
    {
        Dictionary<object, object> services = new Dictionary<object, object>();

        public void Register<T>(Object service)
        {
            this.services[typeof(T)] = service;
        }

        public T Get<T>()
        {
            return (T)this.services[typeof(T)];
        }
    }
}

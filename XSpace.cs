using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class XSpace
    {
        // Bu sınıf şimdilik boş bırakılmıştır.
    }


    // IEats arayüzü, yemek yiyebilen nesneler için bir sözleşme belirtir.
    public interface IEats
    {
        void Eat();
    }

    // ISalary arayüzü, maaş alan nesneler için bir sözleşme belirtir.
    public interface ISalary
    {
        void GetSalary();
    }

    // IWorker arayüzü, işçi nesneleri için bir sözleşme belirtir.
    public interface IWorker
    {
        void Work();
    }

    // Manager sınıfı, IEats, ISalary ve IWorker arayüzlerini uygular ve her bir yöntemi NotImplementedException fırlatır.
    class Manager : IEats, ISalary, IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    // Ceo sınıfı, IEats, ISalary ve IWorker arayüzlerini uygular ve her bir yöntemi NotImplementedException fırlatır.
    class Ceo : IEats, ISalary, IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    // Stajyer sınıfı, IEats ve IWorker arayüzlerini uygular ve her bir yöntemi NotImplementedException fırlatır.
    // Bu sınıf, SOLID prensiplerine uygun olarak, gereksiz yöntemleri uygulamaktan kaçınarak arayüz ayrımı yapar. 
    class Stajyer : IEats, IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    // Robot sınıfı, IWorker arayüzünü uygular ve Work yöntemini NotImplementedException fırlatır.
    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ClienteWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public Cliente GetData(int value)
        {
            var cliente = new Cliente() { ID = 1, Nome = "Danilo", CPF = "48596385242" };
            return cliente;
        }
        public List<Cliente> All()
        {
            var clientes = new List<Cliente>();
            clientes.Add(new Cliente() { ID = 1, Nome = "Danilo", CPF = "4598236541" });
            clientes.Add(new Cliente() { ID = 2, Nome = "Amanda", CPF = "4859634569" });
            clientes.Add(new Cliente() { ID = 3, Nome = "Wanessa", CPF = "9666385242" });
            return clientes;
        }
        public bool Save(string nome, string cpf)
        {
            try 
            {
                bool saved = new Cliente() { ID = 4, Nome = nome, CPF = cpf }.Save();
                return saved;
            }
            catch { return false; }
            
        }


        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}

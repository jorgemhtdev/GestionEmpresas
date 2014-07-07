using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ServicioGestion.Model;
namespace ServicioGestion
{
    
    public class SrvDatos : ISrvDatos
    {
        public bool insertarTel(string value)
        {
            using (GestionEmpresasEntities bd = new GestionEmpresasEntities())
            {
                Sector u = new Sector();
                u.descripcion = "prueba";
                u.Empresa = 
            }
        }

        public string GetData2(int value)
        {
            return string.Format("You entered: {0}", value);
        }


        public string GetData3(int value)
        {
            return string.Format("You entered: {0}", value);
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

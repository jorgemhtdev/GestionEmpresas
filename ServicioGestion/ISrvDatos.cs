using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServicioGestion
{
    [ServiceContract]
    public interface ISrvDatos
    {

        [OperationContract]
        bool insertarTel(string value);
        
    }


    
}

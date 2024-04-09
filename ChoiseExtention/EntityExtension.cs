using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Common;
using LSEXT;
using LSSERVICEPROVIDERLib;

namespace ChoiseExtention
{


    [ComVisible(true)]
    [ProgId("ChoiseExtention.ChoiseExtentioncls")]
    public class ChoiseExtention : LSEXT.IWorkflowChoice
    {   

     
        bool IWorkflowChoice.Execute(ref LSExtensionParameters Parameters)
        {
            var sp = Parameters["SERVICE_PROVIDER"];
            var ntlsCon = Utils.GetNtlsCon(sp);
            Utils.CreateConstring(ntlsCon);

            return true;
        }
       
    }
}


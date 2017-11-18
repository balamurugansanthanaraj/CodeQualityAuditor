using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Webhooks.CrossCutting
{
    public class Enum
    {
        public enum GitEvents
        {
            None=0,
            /// <summary>
            /// Branch or tag created.
            /// </summary>
            [Description("Create")]
            Create =1,     
        }

       
    }
}

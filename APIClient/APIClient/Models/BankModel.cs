using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace APIClient.Models
{
    [DataContract]
    public class Bank
    {
        [DataMember]
        public int BankID { get; set; }
        [DataMember]
        public string BankName { get; set; }
    }
}

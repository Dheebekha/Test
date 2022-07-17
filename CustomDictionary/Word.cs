using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CustomDictionary
{
    [DataContract]
    public class Word
    {
        [DataMember(Name = "Id")]
        public int Id { get; set; }
        [DataMember(Name = "Value")]
        public string Value { get; set; }
    }
}

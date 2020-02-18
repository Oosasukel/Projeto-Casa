

using System.Runtime.Serialization;

namespace ProjetoCasaDeShow.Models
{
    [DataContract]
    public class BaseModel
    {
        [DataMember]
        public int Id{get;set;}
    }
}
using System.Runtime.Serialization;

namespace Model
{
    //1. model add tag
    [DataContract]
    public class UserInfo
    {
        [DataMember]
        public int Id { get; set; }


        [DataMember]
        public string Name { get; set; }
    }
}
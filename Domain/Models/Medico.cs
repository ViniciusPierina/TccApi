using Core.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    [Table("cadprest")]
    public class Medico : BaseModel
    {
        public string codprest { get; set; }
        public string nomeprest { get; set; }
        public string tipoprest { get; set; }
        public string endprest { get; set; }
        public string baiprest { get; set; }
        public string cidprest { get; set; }
        public string categprest { get; set; }
        public string foneprest { get; set; }
        public string codesp { get; set; }
        public long status { get; set; }
        public string conselho { get; set; }
        public string rede { get; set; }
        public string crmprest { get; set; }
    }
}

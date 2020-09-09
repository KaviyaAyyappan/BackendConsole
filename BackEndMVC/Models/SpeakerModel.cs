using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndMVC.Models
{
    public class SpeakerModel
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string Bio { get; set; }
        public string webSite { get; set; }
    }
}

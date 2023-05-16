using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AudMVCBaza.Models
{
    public class ClientMovie
    {
        public int MoiveId { get; set; }
        public int ClientId { get; set; }
        public Movie movie { get; set; }
        public List<Client> clients { get; set; }
    }
}
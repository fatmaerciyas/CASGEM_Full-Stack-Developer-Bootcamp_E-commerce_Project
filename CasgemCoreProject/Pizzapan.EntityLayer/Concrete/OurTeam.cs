﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.EntityLayer.Concrete
{
    public class OurTeam
    {
        public string OurTeamID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string ImageUrl { get; set; }
        public bool Status  { get; set; }
    }
}

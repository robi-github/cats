﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cats.Models
{
    public partial class RegionalRequest
    {
        public RegionalRequest()
        {
            this.RegionalRequestDetails = new List<RegionalRequestDetail>();
        }

        public int RegionalRequestID { get; set; }
        public int RegionID { get; set; }
        public int ProgramId { get; set; }
        public int Round { get; set; }
        public DateTime RequistionDate { get; set; }
        public int Year { get; set; }
        public String ReferenceNumber { get; set; }
        public string Remark { get; set; }
        public int Status { get; set; }

        public virtual ICollection<RegionalRequestDetail> RegionalRequestDetails { get; set; }
        public virtual ICollection<ReliefRequisition> ReliefRequisitions { get; set; }
        public virtual AdminUnit AdminUnit { get; set; }
        public virtual Program Program { get; set; }
       
  
        
    }
}
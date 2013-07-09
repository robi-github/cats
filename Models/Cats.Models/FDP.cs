using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cats.Models
{
    public partial class FDP
    {
        public FDP()
        {
           
            this.DispatchAllocations = new List<DispatchAllocation>();
            this.RegionalRequestDetails = new List<RegionalRequestDetail>();
            this.ReliefRequisitionDetails = new List<ReliefRequisitionDetail>();
            this.TransportOrderDetails = new List<TransportOrderDetail>();
        }

        public int FDPID { get; set; }
        public string Name { get; set; }
        public string NameAM { get; set; }
        public int AdminUnitID { get; set; }
        public virtual AdminUnit AdminUnit { get; set; }
      
        public virtual ICollection<DispatchAllocation> DispatchAllocations { get; set; }
        public virtual ICollection<RegionalRequestDetail> RegionalRequestDetails { get; set; }
        public virtual ICollection<ReliefRequisitionDetail> ReliefRequisitionDetails { get; set; }
        public virtual ICollection<TransportOrderDetail> TransportOrderDetails { get; set; }
  

    }
}
﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Cats.Models;

namespace Cats.Services.EarlyWarning
{
    public interface IReliefRequisitionService
    {

        bool AddReliefRequisition(ReliefRequisition reliefRequisition);
        bool DeleteReliefRequisition(ReliefRequisition reliefRequisition);
        bool DeleteById(int id);
        bool EditReliefRequisition(ReliefRequisition reliefRequisition);
        ReliefRequisition FindById(int id);
        List<ReliefRequisition> GetAllReliefRequisition();
        List<ReliefRequisition> FindBy(Expression<Func<ReliefRequisition, bool>> predicate);
        IEnumerable<ReliefRequisition> Get(
           Expression<Func<ReliefRequisition, bool>> filter = null,
           Func<IQueryable<ReliefRequisition>, IOrderedQueryable<ReliefRequisition>> orderBy = null,
           string includeProperties = "");


    }
}



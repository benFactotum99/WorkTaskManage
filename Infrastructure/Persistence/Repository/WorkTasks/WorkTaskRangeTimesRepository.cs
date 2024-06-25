﻿using EFHelper.Repository.Abstract;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repository.WorkTasks
{
    public class WorkTaskRangeTimesRepository : ContextRepositoryBase<WorkTaskRangeTime, WorkTaskManager>
    {
        public WorkTaskRangeTimesRepository(WorkTaskManager context) : base(context)
        {
        }
    }
}

﻿using BussinessObject;
using DataAccessLayer;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repo
{
    public class ScheduleRepo : IScheduleRepo
    {
        public ScheduleRepo(LumosDBContext context) { }

        public Task<Schedule> AddPartnerScheduleAsync(Schedule schedule) => ScheduleDAO.Instance.AddPartnerScheduleAsync(schedule);

        public Task<List<Schedule>> GetScheduleByPartnerIdAsyn(int id) => ScheduleDAO.Instance.GetScheduleByPartnerIdAsyn(id);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PushNotification.Model;

namespace PushNotification.Interface
{
    public interface ISchedularConfig
    {
        public SchedularList AlertsSchedularGetALL();
        public SchedularList CreateAlertsSchedular(SchedularConfigDTO schedularConfigDTO);

    }
}

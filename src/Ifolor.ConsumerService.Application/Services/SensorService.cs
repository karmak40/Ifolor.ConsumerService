﻿using Ifolor.ConsumerService.Core.Models;
using Ifolor.ConsumerService.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfolorConsumerService.Application.Services
{
    /// <summary>
    /// Proccessing Sensor data and gives response upon success 
    /// todo: mimic failing of proccessing sensor data
    /// </summary>
    public class SensorService : ISensorService
    {
        public SensorEventData ProcessSensorEvent(SensorData eventData)
        {
            var data = new SensorEventData
            {
                Data = eventData,
                ProccessedTime = DateTime.Now,
                Status = SetStatusLogik(eventData),
            };

            return data;
        }

        private SensorEventStatus SetStatusLogik(SensorData eventData)
        {
            return SensorEventStatus.Success;
        }
    }
}

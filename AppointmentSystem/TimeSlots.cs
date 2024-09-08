﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppointmentSystem
{
    public class TimeSlots
    {

        public List<string> GetAvailableTimeSlots()
        {
            var slots = new List<string>
            {
                "09:00 AM - 10:00 AM",
                "10:00 AM - 11:00 AM",
                "11:00 AM - 12:00 PM",
                "01:00 PM - 02:00 PM",
                "02:00 PM - 03:00 PM",
                "03:00 PM - 04:00 PM",
                "04:00 PM - 05:00 PM",
                "05:00 PM - 06:00 PM",
                "06:00 PM - 07:00 PM",
                "07:00 PM - 08:00 PM"
            };

            return slots;
        }
    }
}
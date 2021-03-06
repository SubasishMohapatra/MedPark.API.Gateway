﻿using MedPark.Common.Messages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedPark.API.Gateway.Messages.Commands.BookingService
{
    [MessageNamespace("booking-service")]
    public class AddAppointment : ICommand
    {
        public Guid AppointmentId { get; }
        public Guid PatientId { get; }
        public Guid SpecialistId { get; }
        public DateTime ScheduledDate { get; }
        public bool IsPostponement { get; }
        public string Comment { get; }
        public Guid? MedicalScheme { get; }

        [JsonConstructor]
        public AddAppointment(Guid appointmentId, Guid patientId, Guid specialistId, DateTime scheduledDate, Boolean isPostponement, string comment, Guid? medicalScheme)
        {
            AppointmentId = appointmentId;
            PatientId = patientId;
            SpecialistId = specialistId;
            ScheduledDate = scheduledDate;
            IsPostponement = isPostponement;
            Comment = comment;
            MedicalScheme = medicalScheme;
        }
    }
}

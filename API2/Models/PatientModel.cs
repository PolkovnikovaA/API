using API2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API2.Models
{
    public class PatientModel
    {
        public PatientModel(Patient patient)
        {
            ID = patient.Kod_patient;
            Surname = patient.Surname;
            Name = patient.Name_;
            Middle_name = patient.Middle_name;
            Mail = patient.Mail;
            Sostoyaniye = patient.Sostoyaniye;
            Image = patient.Image;

        }
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middle_name { get; set; }
        public string Mail { get; set; }
        public string Sostoyaniye { get; set; }
        public string Image { get; set; }
    }
}
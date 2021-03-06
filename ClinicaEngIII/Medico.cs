﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaEngIII
{
    public class Medico
    {
        public Medico(string crm, string area, double salario,
            string nome, string cpf, string end, int idade, string sexo, string tel) {
            this.Crm = crm;
            this.Area = area;
            this.Salario = salario;
            this.medico = new Usuario(nome, cpf, end, idade, sexo, tel);
        }

        public string Crm { get => Crm; set => Crm = value; }
        public string Area { get => Area; set => Area = value; }
        public double Salario { get => Salario; set => Salario = value; }
        public int IdMedico { get => IdMedico; set => IdMedico = value; }
        Usuario medico;
    }
}

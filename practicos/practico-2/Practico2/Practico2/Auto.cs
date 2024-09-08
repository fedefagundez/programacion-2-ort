using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    internal class Auto
    {
        private string _marca;
        private string _modelo;
        private bool _exoneraImpuestos;
        private string _matricula;
        private int _anio;

        public Auto(string marca, string modelo, bool exoneraImpuestos, string matricula, int anio)
        {
            _marca = marca;
            _modelo = modelo;
            _exoneraImpuestos = exoneraImpuestos;
            _matricula = matricula;
            _anio = anio;
        }

        private bool ValidarMatricula()
        {
            return _matricula.Length == 7;

        }

        private bool Validar()
        {
            return ValidarMatricula() && !string.IsNullOrEmpty(_marca) && !string.IsNullOrEmpty(_modelo);
        }

        public decimal CalcularPatente()
        {
            decimal patente = 0;

            if (_anio < 2015 && _exoneraImpuestos)
            {
                patente = 10000;
            }else if (_anio < 2015 && !_exoneraImpuestos)
            {
                patente = 12000;
            }
            else
            {
                patente = 17000;
            }
            
            return patente;

        }

        public override string ToString()
        {
            return $"{_marca} - {_modelo} del año {_anio} paga {CalcularPatente()} de patente";
        }

    }

    
}


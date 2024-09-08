using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    internal class Cuenta
    {
        private string _titular;
        private double _saldo;
        private string _tipoDeCuenta;
        private string _moneda;
        private string _numeroDeCuenta;
        private int _retiros;

        public Cuenta(string titular, string tipoDeCuenta, string moneda, string numeroDeCuenta)
        {
            _titular = titular;
            _saldo = 0;
            _tipoDeCuenta = tipoDeCuenta;
            _moneda = moneda;
            _numeroDeCuenta = numeroDeCuenta;
            _retiros = 0;
        }

        private bool ValidarCuenta()
        {
            return !string.IsNullOrEmpty(_numeroDeCuenta) && (_tipoDeCuenta == "CA" || _tipoDeCuenta == "CC");
        }

        private bool ValidarMoneda()
        {
            return !string.IsNullOrEmpty(_moneda) && (_moneda == "$" || _moneda == "U$S");
        }

        public bool Validar()
        {
            return ValidarCuenta() && ValidarMoneda() && !string.IsNullOrEmpty(_titular);
        }

        public bool Retirar(double monto)
        {
            bool exito = false;
            if (_saldo - monto >= 0 && _retiros < 5) 
            {
                _saldo -= monto;
                exito = true;
                _retiros++;
            }
            return exito;
        }

        public bool Deposito(double monto)
        {
            bool exito = false;
            if(_moneda == "$" && monto <= 50000 || _moneda == "U$S" && monto <= 1000)
            {
                _saldo += monto;
                exito = true;
            }
            return exito;
        }

        public  override string ToString()
        {
            return $"Titular: {_titular} - N° de cuenta: {_numeroDeCuenta} - Saldo: {_saldo}";
        }
    }
}

using System;

namespace KDSoft.NetWeeks.API.Business
{
    public class CalculadoraBus
    {
        public int resultado;
        public int numero1;
        public int numero2;

        public void sumar(string num1, string num2)
        {
            try {
                numero1 = int.Parse(num1);
            }
            catch (Exception) {
                numero1 = 0;
            };

            try
            {
                numero2 = int.Parse(num2);
            }
            catch (Exception)
            {
                numero2 = 0;
            };

            resultado = numero1 + numero1;
        }

        public int QuitarNumero(int num1, int num2) {
            int resta;
            if (num1 > num2)
            {
                return num1 - num2;
            }
            else
                return num2 - num1;
        }

        public int Multiplicar(int num1, int num2) {
            // Retorna el producto de los dos números pasados por parámetros
            return num1 * num2;
        }

        public void Dividir(int num1, int num2) {
            try
            {
                resultado = num1 / num2;
            }
            catch (Exception) {
                // TODO: Que onda con la división por cero?
            };
        }

        public string QuitarEsapcios(string texto) {
            if (texto != null) {
                if (texto != "") {
                    return texto.Trim();
                }
            }
        }

        public bool ConvertirBooleano(string texto) {
            var valor = texto == "true";
            if (valor)
                return true;
            else
                return false;
        }
    }
}
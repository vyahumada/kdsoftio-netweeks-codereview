using System;

namespace KDSoft.NetWeeks.CodeReview
{
    public class Calculadora
    {
        public int resultado { get; private set; }
        public int numero1;
        public int numero2;

        //public void sumar(string num1, string num2)
        //{
        //    try {
        //        numero1 = int.Parse(num1);
        //    }
        //    catch (Exception) {
        //        numero1 = 0;
        //    };

        //    try
        //    {
        //        numero2 = int.Parse(num2);
        //    }
        //    catch (Exception)
        //    {
        //        numero2 = 0;
        //    };

        //    resultado = numero1 + numero1; // TODO BUG!
        //}

        public int Sumar(string num1, string num2)
        {
            int sumando1;
            int sumando2;

            bool esNumero1 = int.TryParse(num1, out sumando1);
            bool esNumero2 = int.TryParse(num2, out sumando2);

            if (esNumero1 && esNumero2) {
                return sumando1 + sumando2;
            }
            else {
                throw new ArgumentException("Parámetros con formato inválido");
            }
        }

        //public int QuitarNumero(int num1, int num2) {
        //    int resta;
        //    if (num1 > num2)
        //    {
        //        return num1 - num2;
        //    }
        //    else
        //        return num2 - num1;
        //}

        public int CalcularDiferencia(int num1, int num2)
        {
            return Math.Abs(num1 - num2);
        }

        //public int Multiplicar(int num1, int num2) {
        //    // Retorna el producto de los dos números pasados por parámetros
        //    return num1 * num2;
        //}

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        //public void Dividir(int num1, int num2) {
        //    try
        //    {
        //        resultado = num1 / num2;
        //    }
        //    catch (Exception) {
        //        // TODO: Que onda con la división por cero?
        //    };
        //}

        public int Dividir(int dividendo, int divisor)
        {
            if (divisor == 0) {
                throw new ArgumentException("No es posible realizar una división por cero");
            }

            return dividendo / divisor;
        }

        //public string QuitarEsapcios(string texto) {
        //    if (texto != null) {
        //        if (texto != "") {
        //            return texto.Trim();
        //        }
        //    }
        //}

        // TODO Mover a otra clase. Su comportamiento no es coherente con la clase Calculadora
        public string QuitarEspacios(string texto)
        {
            return string.IsNullOrEmpty(texto) ? texto : texto.Trim();
        }

        //public bool ConvertirBooleano(string texto)
        //{
        //    var value = texto == "true";
        //    if (value == true)
        //        return true;
        //    else
        //        return false;
        //}

        // TODO Mover a otra clase. Su comportamiento no es coherente con la clase Calculadora
        public bool ConvertirBooleano(string texto) {
            return texto.ToLower() == "true";
        }
    }
}
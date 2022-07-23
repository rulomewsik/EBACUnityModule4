using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = System.Random;

namespace Modulo_8.Script
{
    public class EjerciciosVariablesMod8 : MonoBehaviour
    {
        #region Parte 1

        //1)
        private int intCadaUpdate;
        private float floatCadaFixedUpdate = 1;

        //2)
        private float operacionFloat1;
        private float operacionFloat2;
        private int resultadoOperacionInt;

        //4)
        private static Random random = new();

        //5)
        private float resultadoOperacionFloat;

        //6)
        private string miNombreCompleto = "José Raúl Vega Arroyo";

        #endregion

        #region Parte 2

        //1)
        private string num1 = "1234";
        private string num2 = "4321";

        //2)
        private string loremIpsum1 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
        
        //3)
        private string loremIpsum2 = "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";

        #endregion

        void Update()
        {
            //Parte 1

            //1)
            intCadaUpdate += 1;
            Debug.Log($"Int Cada Frame Update -> {intCadaUpdate}");

            //2)
            operacionFloat1 = RandomFloat();
            operacionFloat2 = RandomFloat();
            resultadoOperacionFloat = operacionFloat1 * operacionFloat2;
            resultadoOperacionInt = (int) resultadoOperacionFloat;
            Debug.Log($"Resultado Operación Int -> {resultadoOperacionInt}");

            //5)
            var floatString = resultadoOperacionFloat.ToString().Split('.')[1];
            Debug.Log($"4 Posiciones Float String -> {floatString.Substring(0, 4)}");

            //6)
            var miNombre = miNombreCompleto.Substring(0, 9);
            var miApellidoPaterno = miNombreCompleto.Substring(9, 5);
            var miApellidoMaterno = miNombreCompleto.Substring(15, 6);
            var miNombreList = miNombreCompleto.Split(' ').ToList();

            Debug.Log($"Mi Nombre -> {miNombre}");
            Debug.Log($"Mi Apellido Paterno -> {miApellidoPaterno}");
            Debug.Log($"Mi Apellido Materno -> {miApellidoMaterno}");

            //Parte 2

            //1)
            int.TryParse(num1, out var num1Int);
            int.TryParse(num2, out var num2Int);
            Debug.Log($"Operación TryParse -> {num1Int + num2Int}");

            //2)
            var loremIpsumPares = new List<string>();
            for (var i = 0; i < loremIpsum1.Length; i++)
            {
                if (i % 2 == 0)
                {
                    loremIpsumPares.Add(loremIpsum1[i].ToString());
                }
            }
            
            Debug.Log($"Pares de Frase -> {string.Join(',', loremIpsumPares)}");
            
            //3)
            Debug.Log($"Eliminar Primeros 5 caracteres de Frase -> {loremIpsum2.Substring(5)}");
        }

        private void FixedUpdate()
        {
            floatCadaFixedUpdate *= floatCadaFixedUpdate;
            //Debug.Log($"Float Cada Fixed Update -> {floatCadaFixedUpdate}");

            //3)
            GetComponent<MeshRenderer>().material.color = intCadaUpdate % 2 == 0 ? Color.red : Color.white;

            //4)
            GetComponent<MeshRenderer>().material.color = RandomString() switch
            {
                "A" => Color.green,
                "B" => Color.blue,
                "C" => Color.magenta,
                "D" => Color.yellow,
                _ => Color.white
            };
        }

        private static string RandomString()
        {
            const string chars = "ABCD";
            return new string(Enumerable.Repeat(chars, 1)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private static float RandomFloat()
        {
            return (float) new Random().NextDouble();
        }
    }
}
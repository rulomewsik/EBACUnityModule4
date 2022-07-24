using UnityEngine;

namespace Modulo_9.Script
{
    public class EjerciciosDeCiclosYArreglos : MonoBehaviour
    {
        //1)
        private int[] arr1 = new int[6];
        private int[] arr2 = new int[6];

        //2)
        private string[] arrPalabras = {"Ya", "Quiero", "Que", "Haga", "Frío"};

        //3)
        private int[,] arreglo2D = {{1, 2, 3}, {4, 5, 6}};
        private int[] arreglo1D = {7, 8, 9};

        private void Start()
        {
            //1)
            for (var i = 0; i < 6; i++)
            {
                arr1[i] = Random.Range(1, 40);
                arr2[i] = Random.Range(1, 40);
            }

            Debug.Log("--- Arreglo 1 ---");
            Debug.Log($"[{string.Join(", ", arr1)}]");
            Debug.Log("--- Arreglo 2 ---");
            Debug.Log($"[{string.Join(", ", arr2)}]");

            var arr3 = new int[arr1.Length];

            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = arr1[i] + arr2[i];
            }

            Debug.Log("--- Arreglo 3 ---");
            Debug.Log($"[{string.Join(", ", arr3)}]");

            //2)
            var fraseCompleta = "";
            foreach (var palabra in arrPalabras)
            {
                fraseCompleta += $"{palabra} ";
            }

            Debug.Log("--- Frase Completa ---");
            Debug.Log(fraseCompleta);

            //3)
            var arregloResultado = new int[arreglo2D.GetLength(0)];

            for (var r = 0; r < arreglo2D.GetLength(0); r++)
            {
                for (var c = 0; c < arreglo2D.GetLength(1); c++)
                {
                    arregloResultado[r] += arreglo2D[r, c] * arreglo1D[c];
                }
            }

            Debug.Log("--- Resultado Multiplicación Matriz Por Vector ---");
            Debug.Log($"[{string.Join(", ", arregloResultado)}]");
        }
    }
}
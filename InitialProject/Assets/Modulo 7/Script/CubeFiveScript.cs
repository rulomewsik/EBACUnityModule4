using UnityEngine;

namespace Modulo_7.Script
{
    public class CubeFiveScript : MonoBehaviour
    {
        public GameObject cubeOneGo;
        public GameObject cubeTwoGo;
        public GameObject cubeThreeGo;
        public GameObject cubeFourGo;

        private bool _firstBooleanColor;
        private bool _secondBooleanColor;

        private void FixedUpdate()
        {
            _firstBooleanColor = cubeOneGo.GetComponent<CubeOneScript>().booleanColor &&
                                 cubeTwoGo.GetComponent<CubeTwoScript>().booleanColor;
            _secondBooleanColor = cubeThreeGo.GetComponent<CubeThreeScript>().booleanColor ||
                                  cubeFourGo.GetComponent<CubeFourScript>().booleanColor;

            if (_firstBooleanColor && _secondBooleanColor)
            {
                GetComponent<MeshRenderer>().material.color = Color.white;
            }
            else if (_firstBooleanColor || !_secondBooleanColor)
            {
                GetComponent<MeshRenderer>().material.color = Color.white;
            }
            else
            {
                GetComponent<MeshRenderer>().material.color = Color.black;
            }
        }
    }
}
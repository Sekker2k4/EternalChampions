// Jorge Ivorra Agulló //
// Eternal Champions ////
/////////////////////////

using UnityEngine;


namespace Invector.vCharacterController.AI
{
    namespace Invector
    {

        public class GameRules : MonoBehaviour
        {
            public vUICounter counter;  //Muestra las muertes en el canvas de WaveStatus.
            public GameObject salida;   //Activa El trigger para pasar de escena.
            public int muertesMaximas ; //Nº de muertes para acabar la partida en esta escena
            public GameObject  portal1; //Prefab del portal
            public GameObject  portal2; //Prefab del portal
            public GameObject vfx;      //VFX

            void Update()
            {
                RulesManager();
            }
            public void RulesManager()
            {
                if (counter.currentCounter >= muertesMaximas)
                {
                    // Logica de condicion.
                    portal1.SetActive(false);
                    portal2.SetActive(false);
                    salida.SetActive(true);
                    vfx.SetActive(true);
                }
            }
        }
    }
}
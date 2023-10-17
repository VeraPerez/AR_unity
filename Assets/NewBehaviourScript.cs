using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //otras funciones que realizan nuevas acciones
    void interacciones()
    {
        //Obtiene el número de la escena donde se obtiene el código
        int numeroescena = gameObject.scene.buildIndex;
        SceneManager.LoadScene(numeroescena + 1);
    }
        private void OnCollisionEnter(Collision collision)
    {
            interacciones();

    }
}


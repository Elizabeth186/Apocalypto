using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class llave : MonoBehaviour
{

    [SerializeField] private int cantidadEnemigos;
    [SerializeField] private int  cantidadEnemigosEliminados;

   
    // Start is called before the first frame update
    void Start()
    {
        cantidadEnemigos = GameObject.FindGameObjectsWithTag("enemigo").Length;

    }

    // Update is called once per frame
    private void eliminados(){
        cantidadEnemigosEliminados += 1;
}

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "personaje"){
          SceneManager.LoadScene(3);
        }
    }
}
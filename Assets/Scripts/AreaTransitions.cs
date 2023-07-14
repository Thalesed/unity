using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaTransitions : MonoBehaviour{
    private CameraController cam;
    public Vector2 newMinPosition;
    public Vector2 newMaxPosition;
    public Vector3 movePlayer; //adicionado para mudarmos para a área certa

    void Start(){
        cam = Camera.main.GetComponent<CameraController>();
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Player"){
            cam.minPosition = newMinPosition;
            cam.maxPosition = newMaxPosition;
            other.transform.position += movePlayer; //adicionado para mudarmos para a área certa

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private GameObject LeftDoor;
    private GameObject RightDoor;

    void Start()
    {
        this.LeftDoor = GameObject.Find("Door_Left");
        this.RightDoor = GameObject.Find("Door_Right");
    }

    void Update()
    {
        // Le code de mise à jour peut être ajouté ici si nécessaire
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(OpenDoorAfterDelay(5f)); // Attendre 5 secondes avant d'ouvrir la porte
    }

    IEnumerator OpenDoorAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // Ouvrir la porte après l'attente de 5 secondes
        this.LeftDoor.transform.position = new Vector3(0, 0, 20);
        this.RightDoor.transform.position = new Vector3(0, 0, -20);
    }
}
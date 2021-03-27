using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZabor : MonoBehaviour {
    public Renderer Location6,ThisLocation;
    public Material EndMat;
    public GameManager Gm;
    public GameObject Player, Location6Collider;
    public GameObject[] DestroyObjects;
    public GameObject Comix;
    public bool Ended;
    public void End()
    {
        Comix.SetActive(true);
        Location6.material = EndMat;
        Gm.StartLocation.transform.gameObject.SetActive(true);
        Player.transform.position = new Vector2(Gm.StartLocation.transform.position.x, 3.91f);
        Location6.gameObject.SetActive(false);
        StartCoroutine(Wait());

    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(4);
        Comix.SetActive(false);
        Destroy(Location6Collider);
        ThisLocation.gameObject.SetActive(false);
        for(int i = 0; i < DestroyObjects.Length; i++)
        {
            Destroy(DestroyObjects[i].gameObject);
        }
        Ended = true;
    }
}

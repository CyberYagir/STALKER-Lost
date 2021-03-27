using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading : MonoBehaviour {
    public GameObject Manu;
    public int Waited;
    public Transform Quad;
    public float Add;
    public void Start()
    {
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        for(int i = 0; i < Waited; i++)
        {
            if (Input.GetKey(KeyCode.F1))
            {
                i = Waited-1;
            }
            print(i);
            Quad.transform.localScale = new Vector3(Quad.transform.localScale.x + Add, Quad.transform.localScale.y,1);
            yield return new WaitForSeconds(1f);
            
        }
        Manu.SetActive(true);
        Quad.parent.transform.gameObject.SetActive(false);
    }
}

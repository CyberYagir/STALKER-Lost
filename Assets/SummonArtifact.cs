using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonArtifact : MonoBehaviour {
    public GameObject ArtifactPrefab,Artifact;
    void Start()
    {
        GameObject f = Instantiate(ArtifactPrefab, new Vector2(Random.Range(transform.position.x - 0.18f, transform.position.x + 0.18f), Random.Range(transform.position.y - 0.18f, transform.position.y + 0.18f)), Quaternion.identity, transform);
        Artifact = f;
    }
    public void FixedUpdate()
    {
        if (Artifact == null)
        {
            StartCoroutine(WaitForArtifact());
        }
        else
        {
            StopAllCoroutines();
        }
    }
    IEnumerator WaitForArtifact()
    {
        yield return new WaitForSeconds(30);
        GameObject f = Instantiate(ArtifactPrefab, new Vector2(Random.Range(transform.position.x - 0.18f, transform.position.x + 0.18f), Random.Range(transform.position.y- 0.18f, transform.position.y+0.18f)), Quaternion.identity,transform);
        Artifact = f;
        StopAllCoroutines();    
    }
}

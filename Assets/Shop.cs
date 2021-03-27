using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shop : MonoBehaviour {
    public GameObject Conserva;
    public GameObject Aptechka;
    public GameObject Antiradin;
    public GameObject Dinamite;
    public GameObject Artifact;
    public GameObject Voter;
    [Space]
    public bool artifactSelled;

    public Inventory Inv;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Conserva.SetActive(Inv.Conserva);
        Aptechka.SetActive(Inv.Aptechka);
        Antiradin.SetActive(Inv.Antiradin);
        Dinamite.SetActive(Inv.Dinamite);
        Artifact.SetActive(Inv.Artifact);
        Voter.SetActive(Inv.Voter);
    }
}

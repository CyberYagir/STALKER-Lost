using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookUI : MonoBehaviour {
    public void OC(GameObject f)
    {
        f.SetActive(!f.active);
    }
}

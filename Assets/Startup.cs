using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Startup : MonoBehaviour {
    int[] Code = new int[5];

    void Start () {
        
        for (int x = 1; x < 5; x++)
        {
            Code[x] = Random.Range(1, 5);
            print(Code[x]);
        };
        
    

    }

    // Update is called once per frame
    void Update () {
		
	}
}
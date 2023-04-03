using UnityEngine;

public class BloxxSpawnerHome_Script : MonoBehaviour {
    
    public GameObject bloxx_prefab;

    public void SpawnBloxx() {
        GameObject bloxx_obj = Instantiate(bloxx_prefab);

        Vector3 temp = transform.position;
        temp.z = 0.0f;

        bloxx_obj.transform.position = temp;
    } //-- Spawn Bloxx function
} //-- End


/*

Made by : Rey M. Oronos, Jr.
Project : Color Bloxx

*/
using UnityEngine;

public class BloxxSpawnerHome_Script : MonoBehaviour {
    
    public GameObject bloxxHome_prefab;
    private float min_X = -3.0f, max_X = 3.0f;

    public void SpawnHomeBloxx() {
        GameObject bloxx_obj = Instantiate(bloxxHome_prefab);

        Vector3 temp = transform.position;
        temp.x = Random.Range(min_X, max_X);
        temp.z = 0.0f;

        bloxx_obj.transform.position = temp;
    } //-- Spawn Bloxx function
} //-- End


/*

Made by : Rey M. Oronos, Jr.
Project : Color Bloxx

*/
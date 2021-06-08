using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVehicle : MonoBehaviour
{

 [SerializeField] private float speed = 10.0f;


 // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemyVehicle());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));
    }

    IEnumerator SpawnEnemyVehicle()
    {
        yield return new WaitForSeconds(3.0f);
        var randomX = Random.Range(-7.2f, 7.2f);
        
        var positionToSpawn = new Vector3(randomX,0,162.642502f);
        Instantiate(this, positionToSpawn , Quaternion.Euler(0, -179.032f, 0));
        
        yield return new WaitForSeconds(4.0f);
    }
}

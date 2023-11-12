using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nepis : MonoBehaviour
{
    // Lenin settings
    public int healtf = 100;

    public int speedoz = 25;

    public int level = 80;
    // Start is called before the first frame update
    void Start()
    {
        healtf += level;
        print("здоровье:");
        print(healtf);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;

        newPosition.z += speedoz * Time.deltaTime;

        transform.position = newPosition;
    }
}

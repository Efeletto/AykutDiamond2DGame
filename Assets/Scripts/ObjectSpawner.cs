using System;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class ObjectSpawner : MonoBehaviour
{
    // Aslýnda daha sonradan düþündüðümde bu metodun gereksiz olduðunu düþündüm ama silmedim
    public float RndNumberCreater ( float number1 = -9.2f , float number2 = 9.2f)
    {
        return UnityEngine.Random.Range(number1 , number2);
    }
    
    float time = 0f;
    float time2 = 0f;

    // spawnerý kapatan bool deðiþkeni
    public bool OnOff = true;

    public GameObject foods;
    public GameObject poops;

    // Gameobjectlerin position deðerini tutan vectorler
    Vector3 foods_position = new Vector3(0f,7f,0f);
    Vector3 poops_position = new Vector3(0f,8f,0f);
    

    private void Update()
    {
        if (OnOff) {
          time += Time.deltaTime;
          time2 += Time.deltaTime;
            if (time >= UnityEngine.Random.Range(1f,2f))
            {
                foods_position.x = RndNumberCreater();
                Instantiate(foods, foods_position , Quaternion.identity);
                time = 0f;
            }
            if(time2 >= UnityEngine.Random.Range(1f, 2f))
            {
                poops_position.x = RndNumberCreater();
                Instantiate(poops, poops_position , Quaternion.identity);
                time2 = 0f;
            }

        }
    }

}

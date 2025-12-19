using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
public class ObjectSpawner : MonoBehaviour
{
    // Zorluðu zamanla arttýrmak için ayrý bir time deðiþkeni
    float timeDifficulty = 0f;
    float altLimit = 1.4f;
    float ustLimit = 2.4f;
    int sayac = 1;

    //objectPool Food
    public int FoodPoolSize = 10;
    public GameObject FoodPrefab;
    private List<GameObject> FoodPool = new List<GameObject>();
    
    //objectPool Poop
    public int PoopPoolSize = 10;
    public GameObject PoopPrefab;
    private List<GameObject> PoopPool = new List<GameObject>();
    //Listleri doldurduðumuz kýsým
    private void Start()
    {
        for (int i = 0; i < FoodPoolSize; i++)
        {
            GameObject obj = Instantiate(FoodPrefab);
            obj.SetActive(false);
            FoodPool.Add(obj);
        }
        for(int i = 0;i < PoopPoolSize; i++)
        {
            GameObject obj = Instantiate(PoopPrefab);
            obj.SetActive(false);
            PoopPool.Add(obj);
        }
    }

    //objectPool'dan obje çekem ve eðer yeterli sayýda object yoksa yeni obje üreten fonksiyonumuz
    GameObject GetObect(List<GameObject> pool , GameObject prefab)
    {
        foreach (GameObject obj in pool) {
            if (!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj;
            }
            
        }
        GameObject newGameObject = Instantiate(prefab);
        newGameObject.SetActive(true);
        pool.Add(newGameObject);
        return newGameObject;
     }

    // Aslýnda daha sonradan düþündüðümde bu metodun gereksiz olduðunu düþündüm ama silmedim
    public float RndNumberCreater ( float number1 = -9.2f , float number2 = 9.2f)
    {
        return UnityEngine.Random.Range(number1 , number2);
    }

    //zaman ayarlarý
    float time = 0f;
    float time2 = 0f;

    // spawnerý kapatan bool deðiþkeni
    public bool OnOff = true;

    // Gameobjectlerin position deðerini tutan vectorler
    Vector3 foods_position = new Vector3(0f,7f,0f);
    Vector3 poops_position = new Vector3(0f,8f,0f);
    

    private void Update()
    {
        timeDifficulty += Time.deltaTime;
        difficultChanger();
        if (OnOff) {
          time += Time.deltaTime;
          time2 += Time.deltaTime;
            if (time >= UnityEngine.Random.Range(altLimit, ustLimit))
            {
                foods_position.x = RndNumberCreater();
                GameObject obj = GetObect(FoodPool,FoodPrefab);
                obj.transform.position = foods_position;
                time = 0f;
            }
            if(time2 >= UnityEngine.Random.Range(altLimit + 0.2f,ustLimit + 0.2f))
            {
                poops_position.x = RndNumberCreater();
                GameObject obj2 = GetObect(PoopPool,PoopPrefab);
                obj2.transform.position = poops_position;
                time2 = 0f;
            }

        }
        
    }

    void difficultChanger()
    {
        if (altLimit > 0.6f)
        {
            if (sayac <= Mathf.FloorToInt(timeDifficulty / 10))
            {
                sayac += 1;
                altLimit -= 0.1f;
                ustLimit -= 0.1f;
                //  Debug.Log($"Alt : {altLimit}   Ust : {ustLimit}");
            }
        }
        else
        {
            return;
        }
    }
}

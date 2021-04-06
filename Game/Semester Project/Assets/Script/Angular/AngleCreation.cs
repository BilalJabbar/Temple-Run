using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleCreation : MonoBehaviour
{

    [SerializeField]
    private GameObject[] go;

    private List<GameObject> goListsi = new List<GameObject>();


    void Awake()
    {
        AngleBuild();
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RandomAngleBuild());
    }


    public void AngleBuild()
    {
        int number = 0;
        Vector3 location = new Vector3(transform.position.x, transform.position.y, -2);
        for(int i = 0; i < go.Length*3; i++)
        {
            GameObject obj = Instantiate(go[number], location, Quaternion.identity) as GameObject;
            goListsi.Add(obj);
            goListsi[i].SetActive(false);
            number++;
            if (number == go.Length)
            {
                number = 0;
            }


        }
    }

    public void Mix()
    {
        for(int i = 0; i < goListsi.Count; i++)
        {
            GameObject temp = goListsi[i];
            int random = Random.Range(i, goListsi.Count);
            goListsi[i] = goListsi[random];
            goListsi[random] = temp;
        }
    }

    IEnumerator RandomAngleBuild()
    {
        yield return new WaitForSeconds(RandomAngleBuild.Range(1.5f, 4.5f));
        int number = Random.Range(0, goListsi.Count);
        while (true)
        {
            if (!goListsi[number].activeInHierarchy)
            {
                goListsi[number].SetActive(true);
                goListsi[number].transform.position = new Vector3(transform.position.x, transform.position.y, -2);
                break;
            }
            else
            {
                number = Random.Range(0, goListsi.Count);
            }
        }

        StartCoroutine(RandomAngleBuild());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

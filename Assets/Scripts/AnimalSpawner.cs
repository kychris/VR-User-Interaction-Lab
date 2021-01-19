using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    public GameObject animal1;
    public GameObject animal2;
    public GameObject animal3;

    private GameObject[] animals;

    // Start is called before the first frame update
    void Start()
    {
        animal1.SetActive(false);
        animal2.SetActive(false);
        animal3.SetActive(false);

        animals = new GameObject[] { animal1, animal2, animal3 };
    }

    public void SpawnAnimal(int num)
    {
        animal1.SetActive(false);
        animal2.SetActive(false);
        animal3.SetActive(false);

        animals[num].SetActive(true);
    }
}

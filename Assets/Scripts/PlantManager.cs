using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantManager : Singleton<PlantManager>
{
    public List<Plant> m_plantList = new List<Plant>();
    public Plant m_testPlant;

    // Update is called once per frame
    void Update()
    {

    }

    public void setPlant(Vector3 pos, Plant plant)
    {
        if (!isPlantOnPosition(pos))
        {
            m_plantList.Add(Instantiate(plant, pos, Quaternion.identity, gameObject.transform));
        }
    }

    public bool isPlantOnPosition(Vector3 pos)
    {
        bool check = false;

        foreach (Plant plant in m_plantList)
        {
            if (plant.transform.position == pos) check = true;
        }

        return check;
    }
}

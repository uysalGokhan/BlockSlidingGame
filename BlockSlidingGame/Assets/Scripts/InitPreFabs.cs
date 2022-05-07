using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitPreFabs : MonoBehaviour
{
    public GameObject CubePrefab;
    public TextAsset textJSON;

    [System.Serializable]
    public class Cube
    {
        public int x;
        public int y;
        public int z;
        public int x_scale;
        public int y_scale;
        public int z_scale;
        public int x_direction;
        public int y_direction;
        public int z_direction;
        public int score;
    }

    [System.Serializable]
    public class CubeList
    {
        public Cube[] cube;
    }

    public CubeList cubeList = new CubeList();

    // Start is called before the first frame update
    void Start()
    {
        cubeList = JsonUtility.FromJson<CubeList>(textJSON.text);
        for (int i = 0; i < cubeList.cube.Length; i++)
        {
            Cube c = cubeList.cube[i];
            Instantiate(CubePrefab, new Vector3(c.x, c.y, c.z), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

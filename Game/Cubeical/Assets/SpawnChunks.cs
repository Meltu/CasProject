using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChunks : MonoBehaviour
{
   public GameObject block;
   public int columnLength, rowLength;
   public float x_space, z_space;

   void Start()
   {
       for (int i = 0; i < columnLength * rowLength; i++)
       {
           Instantiate(block, new Vector3(x_space *(i %columnLength), 0, z_space * (i /columnLength)), Quaternion.identity);
       }
   }
}

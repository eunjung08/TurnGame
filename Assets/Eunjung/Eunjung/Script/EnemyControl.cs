using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Eunjung
{
    public class EnemyControl : MonoBehaviour
    {
        void Start()
        {
        }
        public void CreateEnemy(int num)
        {
            for (int i = 0; i < num; i++)
            {
                GameObject objEnemy = GameObject.CreatePrimitive(PrimitiveType.Cube);
                objEnemy.name = "Enemy " + i.ToString();
                objEnemy.tag = "Enemy";
                objEnemy.AddComponent<Unit>().unitName = "E" + i;
                objEnemy.transform.position = new Vector3((i * 1.5f), -2, 0);
            }
        }
    }
}

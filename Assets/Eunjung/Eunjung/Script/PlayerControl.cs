using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Eunjung
{
    public class PlayerControl : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        }
        public void CreatePlayers(int num)
        {
            for(int i = 0; i < num; i++)
            {
                GameObject objPlayer = GameObject.CreatePrimitive(PrimitiveType.Cube);
                objPlayer.name = "Player " + i.ToString();
                objPlayer.tag = "Player";
                objPlayer.AddComponent<Unit>().unitName = "P" + i;
                objPlayer.transform.position = new Vector3(-3 + (i * 1.5f), 0, 0);
            }
        }
    }
}

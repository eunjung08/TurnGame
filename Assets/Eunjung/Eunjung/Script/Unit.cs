using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Eunjung
{
    public class Unit : MonoBehaviour
    {
        /// <summary>
        /// UI에 표시될 유닛 이름
        /// </summary>
        public string unitName;
        /// <summary>
        /// 최대 체력
        /// </summary>
        public int maxHP;
        /// <summary>
        /// 현재 체력
        /// </summary>
        public int currentHP;
        /// <summary>
        /// 현재 공격력
        /// </summary>
        public int attackDmg;
        /// <summary>
        /// 현재 스킬 공격력
        /// </summary>
        public int skillDmg;
        /// <summary>
        /// 턴 순서에 영향을 미치는 속도
        /// </summary>
        public int speed;
        // Start is called before the first frame update
        void Start()
        {
            currentHP = maxHP;
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public bool Damage(int damage)
        {
            currentHP -= damage;
            if(currentHP <= maxHP)
            {
                currentHP = 0;
                return true;
            }
            return false;
        }
    }
}

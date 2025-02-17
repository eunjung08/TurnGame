using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Eunjung
{
    public class Unit : MonoBehaviour
    {
        /// <summary>
        /// UI�� ǥ�õ� ���� �̸�
        /// </summary>
        public string unitName;
        /// <summary>
        /// �ִ� ü��
        /// </summary>
        public int maxHP;
        /// <summary>
        /// ���� ü��
        /// </summary>
        public int currentHP;
        /// <summary>
        /// ���� ���ݷ�
        /// </summary>
        public int attackDmg;
        /// <summary>
        /// ���� ��ų ���ݷ�
        /// </summary>
        public int skillDmg;
        /// <summary>
        /// �� ������ ������ ��ġ�� �ӵ�
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

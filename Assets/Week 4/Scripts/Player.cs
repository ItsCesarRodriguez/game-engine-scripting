using System.Collections;
using System.Collections.Generic;
using UnityEngine;




namespace Week4
{
    public class Player : MonoBehaviour
    {
       

        int health = 10;
        [SerializeField] private int helath = 10;

        public void Damage(int amt)
        {
            health -= amt;
        }

        

        public Enemy FindNewTarget()
        {
            /*Enemy[] enemies = GameObject.FindObjectsByType<Enemy>(FindObjectsSortMode.None);
            int randomInex = Random.Range(0, enemies.Length);
            return enemies[randomInex];*/
            

            GameObject enemyObj = GameObject.Find("Enemy");
            Enemy enemyComp = enemyObj.GetComponent<Enemy>();
            return enemyComp;
        }

        public int GetHeakth()
        {
            return health;
        }

        [ContextMenu("Attack")]
        void Attack()
        {

            Enemy target = FindNewTarget();
            target.Damage(3);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        /*
        int num = 10;

        // varに代入する値を条件によって変える(三項演算子)
        int var;
        var = (num == 0) ? 100 : num;
        Debug.Log(var);
        */

        /*
        int[] points = new int[5];

        points[0] = 10;
        points[1] = 20;
        points[2] = 30;
        points[3] = 40;
        points[4] = 50;

        for (int i = 0; i < points.Length; i++)
            Debug.Log(points[i]);
        */

        Boss boss = new  Boss();

        boss.Attack();
        boss.Defence(10);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class Boss
{
    private int hp = 100;
    private int power = 20;

    public  void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence( int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

}
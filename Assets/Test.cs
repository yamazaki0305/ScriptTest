using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        int []array = new int[5];
        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        for (int i = 0; i < array.Length; i++)
            Debug.Log("配列の中身:" + array[i]);


        for (int i = 0; i < array.Length; i++)
            Debug.Log("配列の中身(逆順):" + array[array.Length-1-i]);


        /*
        int num = 10;

        // varに代入する値を条件によって変える(三項演算子)
        int var;
        var = (num == 0) ? 100 : num;
        Debug.Log(var);
        */
        
        Boss boss = new  Boss();

        boss.Attack();
        boss.Defence(10);

        for (int i = 0; i < 15; i++)
            boss.Magic();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class Boss
{
    private int hp = 100;
    private int power = 20;
    private int mp = 53;

    public  void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence( int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    public void Magic()
    {
        int mpcost = 5;

        if( this.mp >= mpcost )
        {
            this.mp -= mpcost;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
        else
            Debug.Log("MPが足りないため魔法が使えない。");
    }

}
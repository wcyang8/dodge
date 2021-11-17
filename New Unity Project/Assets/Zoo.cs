using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animal tom = new Animal();
        tom.name = "tom";
        tom.sound = "meow!";

        Animal jerry = new Animal();
        jerry.name = "jerry";
        jerry.sound = "zzick zzick!";

        tom.PlaySound();
        jerry.PlaySound();
    }
}

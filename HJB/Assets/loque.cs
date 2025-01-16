using UnityEngine;

public class loque : MonoBehaviour
{
    void Update()
    {
        CalcIf(Random.Range(0, 9999));
        CalcSwitch(Random.Range(0, 9999));
    }

    void CalcIf(int num)
    {
        string returned = "";

        if (num % 3 == 0) returned += "Fizz";
        if (num % 5 == 0) returned += "Buzz";

        Debug.Log(num + " " + returned);
    }

    void CalcSwitch(int num)
    {
        string returned = "";

        switch (num % 3 == 0)
        {
            case true: returned += "Fizz"; break;
        }
        switch (num % 5 == 0)
        {
            case true: returned += "Buzz"; break;
        }

        Debug.Log(num + " " + returned);
    }
}

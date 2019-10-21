using UnityEngine;
using UnityEngine.UI;
using System;

public class MostFrequentChar : MonoBehaviour
{
    [SerializeField]
    private InputField _UserString = null;
    [SerializeField]
    private Text character = null;
    [SerializeField]
    private Text numberOfOccurences = null;
    private char[] tab;
    private int[] occurances;
    private int max;


    public void PrintString()
    {
        string s = _UserString.text.Replace(" ", "");
        tab = s.ToCharArray();
        occurances = new int[tab.Length];
        character.text = "The most frequent char is: " + tab[FindMostFrequentChar()];
        numberOfOccurences.text = "Number of occurences: " + max;
    }

    public int FindMostFrequentChar()
    {
        for(int i = 0; i<tab.Length; i++)
        {
            for(int j = 0; j<tab.Length; j++)
            {
                if(tab[i] == tab[j])
                {
                    occurances[i]++;
                }
            }
        }
        max = occurances[0];
        for(int i = 0; i < occurances.Length; i++)
        {
            if(occurances[i] > max)
            {
                max = occurances[i];
            }
        }
        return Array.IndexOf(occurances, max);
    }

}

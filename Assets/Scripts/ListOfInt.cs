using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class ListOfInt : MonoBehaviour
{
    private List<int> list = new List<int>();
    [SerializeField]
    private Text _ListText;
    [SerializeField]
    private Text _Minimum;
    [SerializeField]
    private Text _Maximum;
    [SerializeField]
    private Text _Average;
    [SerializeField]
    private InputField _UserInt;
    [SerializeField]
    private Text _InvalidInt;
    private string _ListString;

    public void AddInList()
    {
        try
        {
            list.Add(Int32.Parse(_UserInt.text));
            _InvalidInt.text = "";
            _ListString += _UserInt.text + "; ";
        }
        catch (FormatException e)
        {
            _InvalidInt.text = e.Message;
        }
        finally
        {
            _UserInt.text = null;
        }
    }

    public void PrintInfos()
    {
        _ListText.text = "List: " + _ListString;
        _Minimum.text = "Minimum: " + list.Min().ToString();
        _Maximum.text = "Maximum: " + list.Max().ToString();
        _Average.text = "Average: " + list.Average().ToString();
    }

    public void ClearList()
    {
        list.Clear();
        _ListString = "";
        _ListText.text = "List: ";
        _Minimum.text = "Minimum: ";
        _Maximum.text = "Maximum: ";
        _Average.text = "Average: ";
    }
}
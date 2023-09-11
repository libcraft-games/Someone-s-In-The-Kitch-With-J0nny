using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using TMPro;

/// <summary>
/// Represents a quantity of a given resource type, for example 5 money.
/// </summary>
public class Resource : MonoBehaviour
{
    public ResourceDef Def { get; set; }
    public string Name => Def.Name;
    public string TextIcon => Def.TextIcon;
    public TextMeshProUGUI TextMesh => gameObject.GetComponent<TextMeshProUGUI>();
    [SerializeField]
    private float _quantity;
    public float Quantity
    {
        get => _quantity;
        set
        {
            _quantity = value;
            TextMesh.text = ToString();
        }
    }
    public void Start()
    {
        Quantity = 0;
    }
    public override string ToString() => $"{TextIcon} {Quantity}";
}
using System;

namespace testFirst_gherkin_cshrp;

public class Produit
{
    public Produit(string type)
    {
        _type = type;
    }

    private string _type;
    
    private bool desireDuSucre;

    public bool DesireSucre
    {
        get => desireDuSucre;
        set => desireDuSucre = true;
    }

    public string TypeBoisson    // the Name property
    {
        get => _type;
        set => _type = value;
    }
}
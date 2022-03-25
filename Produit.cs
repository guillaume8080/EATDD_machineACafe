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

    private int volumeSucre;

    public int VolumeSucre
    {
        get => this.volumeSucre;
        set => volumeSucre = value;

    }

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
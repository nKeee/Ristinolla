public class Pelaaja //Tehtävän 5 tyylillä
{
    public string nimi;
    public int voitot;
    public int haviot;
    public int tasurit;
    public bool ai;
    public string Nimi
    {
        get
        {
            return nimi;
        }
    }
    public int Voitot
    {
        get
        {
            return voitot;
        }
        set
        {
            voitot = value;
        }
    }
    public int Haviot
    {
        get
        {
            return haviot;
        }
        set
        {
            haviot = value;
        }
    }
    public int Tasurit
    {
        get
        {
            return tasurit;
        }
        set
        {
            tasurit = value;
        }
    }
    public bool AI
    {
        get
        {
            return ai;
        }
        set
        {
            ai = value;
        }
    }
}
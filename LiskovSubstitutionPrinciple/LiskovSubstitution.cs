public interface IGrow {
    string Grow();
}

public interface IEatsFlees{
    string AttractFlee();
    string EatFlea();

}

public class Tree : IGrow
{
    public  string Grow()
    {
        return "The tree grows";
    }
}

public class FleaEater : IGrow , IEatsFlees
{
    public string Grow()
    {
        return "The flower grows";
    }

    public string AttractFlee(){
        return "Come here little flea";
    }

    public string EatFlea(){
        return "Womp Womp Womp";
    }

}
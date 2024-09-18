public class Bakery {

    public int Id{get; set;}
    public string Name{get; set;}

    public Address ShopAddress{get; set;}

    public string PhoneNumber{get; set;}

    public dateTime CreateDate{get; set;}

    public string Owner{get; set;}

    public dateTime LastUpdated{get; set;}

    public int lastUpdatedById{get; set;}

}

public class SneakerStore : IHasAllInfoDB{
    public int Id{get; set;}

    public string Name{get; set;}

    public string Brand{get; set;}

    public int numbersMade{get; set;}

    public dateTime CreateDate{get; set;}

    public dateTime LastUpdated{get; set;}

    public int lastUpdatedById{get; set;}

}



public interface HasId{

    int Id{get; set;}

}

public interface HasCreateDate{
    dateTime CreateDate{get; set;}
}

public interface HasOwner{

    string Owner{get; set;}

}

public interface HasUpdateInfo{

    dateTime LastUpdated{get; set;}

    int lastUpdatedById{get; set;}
}
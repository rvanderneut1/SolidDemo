class car {

    private string model;
    private string color;
    private int year;

    public string Model {get{return model}; set {model = value;}};
    public string Color {get; set{
        if (value == "red" || value == "blue" || value == "green"){
            color = value;
        }
    }};
    public int Year {get; set;}; 
}
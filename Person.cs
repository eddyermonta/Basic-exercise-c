class Person{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public Person(){
        Name = "";
        LastName = "";
        Address = "";
        Email = "";
        Phone = "";
    }
    public override string ToString(){
        return $"Name: {Name} {LastName}\nAddress: {Address}\nEmail: {Email}\nPhone: {Phone}";
    }

}
using System;

class Company
{
    private String name;
    private String rank;
    public Company(string name, string rank)
    {
        this.name = name;
        this.rank = rank;
        Console.WriteLine(name + "님께서는 " + rank + "입니다.");
    }
    public void Set_Company(String name, String rank)
    {
        this.rank = rank;
        this.name = name;
        Console.WriteLine(name + "님께서 " + rank + "로 승진하였습니다.");
    }
    public String GetName() { return this.name; }
    public String GetRank() { return this.rank;}
}
class MainClass{
    public static void Main(string[] args)
    {
      Company a = new Company("김범진", "부장");
      Company b = new Company("강민성", "차장");
      Company c = new Company("고석현", "대리");
      Company d = new Company("조대식", "사원");
      Company e = new Company("권부성", "사원");

        d.Set_Company("조대식" ,"대리");

    }
}

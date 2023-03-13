using System;

public class Company
{
    private string name;
    private string address;
    private string[] departments;
    private int numOfEmployees;
    private decimal revenue;
    private bool isPublic;
    private DateTime foundingDate;
    private string ceo;

    public Company()
    {
        name = "Unnamed Company";
        address = "Unknown";
        departments = new string[] { "Unknown" };
        numOfEmployees = 0;
        revenue = 0;
        isPublic = false;
        foundingDate = DateTime.Now;
        ceo = "Unknown";
    }

    public Company(string name, string address, string[] departments, int numOfEmployees, decimal revenue, bool isPublic, DateTime foundingDate, string ceo)
    {
        this.name = name;
        this.address = address;
        this.departments = departments;
        this.numOfEmployees = numOfEmployees;
        this.revenue = revenue;
        this.isPublic = isPublic;
        this.foundingDate = foundingDate;
        this.ceo = ceo;
    }

    public Company(string name, string address, string[] departments, int numOfEmployees)
    {
        this.name = name;
        this.address = address;
        this.departments = departments;
        this.numOfEmployees = numOfEmployees;
        this.revenue = 0;
        this.isPublic = false;
        this.foundingDate = DateTime.Now;
        this.ceo = "Unknown";
    }

    public Company(string name, string address)
    {
        this.name = name;
        this.address = address;
        this.departments = new string[] { "Unknown" };
        this.numOfEmployees = 0;
        this.revenue = 0;
        this.isPublic = false;
        this.foundingDate = DateTime.Now;
        this.ceo = "Unknown";
    }

    public Company(string name, decimal revenue, bool isPublic)
    {
        this.name = name;
        this.address = "Unknown";
        this.departments = new string[] { "Unknown" };
        this.numOfEmployees = 0;
        this.revenue = revenue;
        this.isPublic = isPublic;
        this.foundingDate = DateTime.Now;
        this.ceo = "Unknown";
    }

    public void AddEmployee()
    {
        numOfEmployees++;
    }

    public void RemoveEmployee()
    {
        numOfEmployees--;
    }

    public string GetCEO()
    {
        return ceo;
    }

    public void SetCEO(string newCEO)
    {
        ceo = newCEO;
    }

    public string[] GetDepartments()
    {
        return departments;
    }

    public void SetDepartments(string[] newDepartments)
    {
        departments = newDepartments;
    }

    public decimal GetRevenue()
    {
        return revenue;
    }

    public void SetRevenue(decimal newRevenue)
    {
        revenue = newRevenue;
    }

    public DateTime GetFoundingDate()
    {
        return foundingDate;
    }
}

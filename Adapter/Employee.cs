namespace Adapter;

public class Employee
{
    public int Id { get; set; }
    public String Nom { get; set; }
    public String Designation { get; set; }
    public Decimal Salaire { get; set; }

    public Employee(int id, string nom, string designation, Decimal salaire)
    {
        this.Id = id;
        this.Nom = nom;
        this.Designation = designation;
        this.Salaire = salaire;
    }
}
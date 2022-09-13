namespace Adapter;

public class ThridPartyBillingSystem
{
    public void ProcessSalary(List<Employee> listEmployees)
    {
        foreach ( Employee employee in listEmployees ) 
        {
            Console. WriteLine ( "Rs." + employee.Salaire + " Salaire crédité à " + employee.Nom + " Compte " ) ;
        }
    }
}
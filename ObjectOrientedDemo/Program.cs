using EMSModels;


internal class Program
{
    private static void Main(string[] args)
    {

        //Employee emp1 = new Employee();
        //emp1.AcceptDetails();
        //emp1.DisplayDetails();
        //ProjectManager projmgr=new ProjectManager();
        //projmgr.AcceptProjectManagerDetails();
        //projmgr.ShowProjectManagerDetails();

        VicePresident president=new VicePresident();
        president.AcceptVicePresidentDetails();
        president.DisplayVicePresidentDetails();

        //Bike honda = new Bike();
        //honda.AcceptBikeDetails();
        //honda.DisplayBikeDetails();
        //honda.CountBikes();

        
        Console.ReadKey();
    }
}
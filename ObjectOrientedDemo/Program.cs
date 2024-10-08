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

        //VicePresident president=new VicePresident();

        //president.AcceptVicePresidentDetails();
        //president.DisplayVicePresidentDetails();


        //SeniorEmployee emp = new SeniorEmployee()
        
        //Console.WriteLine("Enter Empid");
        //emp.Empid=Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter Name");
        //emp.EmpName = Console.ReadLine();
        ////Console.WriteLine("Enter your programming skill name");
        ////emp.SkillName = Console.ReadLine();
        ////Console.WriteLine("Enter fav color");
        ////emp.FavColor = Console.ReadLine();

        ////Console.WriteLine("Enter birthDate");
        ////emp.BirthDate = Convert.ToDateTime(Console.ReadLine());
        //Console.WriteLine("Enter city");
        //emp.City = Console.ReadLine();
        ////Console.WriteLine("Enter country");
        ////emp.Country = Console.ReadLine();
        ////Console.WriteLine("Enter email");
        ////emp.Email = Console.ReadLine();

        
        //Console.WriteLine($"You entered empid=  {emp.Empid}");
        //Console.WriteLine($"You entered name = {emp.EmpName}");
        ////Console.WriteLine($"You entered birthdate = {emp.BirthDate}");
        ////Console.WriteLine($"Your age=  {emp.CalculatedAge}");
        ////Console.WriteLine($"You entered the skill name = {emp.FavColor}" );
        //Console.WriteLine($"You entered the skill name = {emp.City}");
        //if (emp.IsValid)
        //{
        //    Console.WriteLine("Welcome");
        //}
        //else
        //{
        //    Console.WriteLine("Check credentials");
        //}

        ProjectLead lead = new ProjectLead(12, "Rima", "Mumbai", "EMS");
        Console.WriteLine($"{lead.Empid},{lead.EmpName},{lead.City},{lead.ProjectName}");
        //Console.WriteLine($"You entered the Email ID = {emp.Email}");
        ////Bike honda = new Bike();
        //honda.AcceptBikeDetails();
        //honda.DisplayBikeDetails();
        //honda.CountBikes();


        Console.ReadKey();
    }
}
using Day3Assignment;

BuilderEmpWge bridgelabz = new BuilderEmpWge("Bridgelabz", 25, 25, 120); // creating a object of EmpWageBuilder class to access methods
BuilderEmpWge reliance = new BuilderEmpWge("Reliance", 20, 20, 130); // creating a object of EmpWageBuilder class to access methods
BuilderEmpWge abc = new BuilderEmpWge("ABC", 30, 20, 150); // creating a object of EmpWageBuilder class to access methods
bridgelabz.calculateEmpWage();
Console.WriteLine(bridgelabz.toString());
reliance.calculateEmpWage();
Console.WriteLine(reliance.toString());
abc.calculateEmpWage();
Console.WriteLine(abc.toString());

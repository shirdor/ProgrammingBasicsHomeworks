using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone numer: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();
        string manager = managerFirstName + managerLastName;
        Console.WriteLine("{0}\nAddress:{1}\nTel.{2}\nFax:{3}\nWeb site:{4}\nManager:{5}(age:{6}, tel.{7})" ,
            companyName, companyAddress, phoneNumber, faxNumber, webSite, manager, managerAge, managerPhone);
    }

}


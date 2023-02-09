// See https://aka.ms/new-console-template for more information
using HRMS.Control;
using HRMS.Model;

Console.WriteLine("Hello, World!");
Repositry repositry = new Repositry();



#region ListData
var data = repositry.GetListData();
if (data != null)
{
    foreach (var item in data)
    {
    Console.WriteLine("Id : "+item.Id);
    Console.WriteLine("Name : "+item.Name);
    Console.WriteLine("Email : "+item.Emial);
    Console.WriteLine("Address : " + item.Address);
    Console.WriteLine("PhoneNumber : " + item.PhoneNumber);
    }
}
else
{
    Console.WriteLine("Done not found data");
}
#endregion

#region Create
//var data = repositry.Add(new Employees());
//if (data != null)
//{
//    Console.WriteLine("Done Added");
//}
//else
//{
//    Console.WriteLine("Done not Added");
//}
#endregion


#region Update
//var data = repositry.Update();
//if (data != null)
//{
//    Console.WriteLine("Done Updated");
//}
//else
//{
//    Console.WriteLine("Done not Updated");
//}
#endregion


#region Delete
//var data = repositry.Delete(2);
//if (data)
//{
//    Console.WriteLine("Done Deleted");
//}
//else
//{
//    Console.WriteLine("Done not Deleted");
//}
#endregion



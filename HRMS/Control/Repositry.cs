using HRMS.DBContext;
using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Control
{
    public class Repositry
    {
        DataBaseContext dataBaseContext= new DataBaseContext();
        public Employees Add(Employees reg)
        {
            try
            {
            //reg.Id = 2;
            reg.Name = "Mohammed";
            reg.Emial = "Mohammed@gmail.com";
            reg.PhoneNumber = "7777777777";
            reg.Address = "sana'a";

            dataBaseContext.Employees.Add(reg);
            dataBaseContext.SaveChanges();
            return reg;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "" + ex.InnerException.Message);
                return null;
            }

        }

        public Employees Update()
        {
            try
            {
                Employees reg=new Employees();
                reg.Id = 2;
                reg.Name = "Mohammedsaleh";
                reg.Emial = "Mohammed@gmail.com";
                reg.PhoneNumber = "788888888";
                reg.Address = "sana'a";

                dataBaseContext.Employees.Update(reg);
                dataBaseContext.SaveChanges();
                return reg;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message+""+ex.InnerException.Message);
                return null;
            }
        }
        public bool Delete(int Id)
        {
            try
            {
                Employees reg = new Employees();
                reg = dataBaseContext.Employees.FirstOrDefault(x => x.Id == Id);
                dataBaseContext.Employees.Remove(reg);
                dataBaseContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "" + ex.InnerException.Message);
                return false;
            }


        }
        public List<Employees> GetListData()
        {
            try
            {
                var data = dataBaseContext.Employees.ToList();
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "" + ex.InnerException.Message);
                return null;
            }
        }
    }
}

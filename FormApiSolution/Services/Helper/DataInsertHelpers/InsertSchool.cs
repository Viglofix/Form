using DataBase.Model;

namespace Services.Helper.DataInsertHelpers;
    public class InsertSchool
   {
    public List<School> GetSchools()
    {
        List<School> schools = new List<School>
            {
                new School()
         {
        Name = "ZST Jasło"
                },
                new School()
       {
        Name = "ZST Rzeszów"
                },
                new School()
         {
        Name = "Politechnika Rzeszowska"
        },
                new School()
       {
        Name = "Uniwersytet Rzeszowski"
                },
                new School()
       {
        Name = "ZST Leżajsk"
                }
        };
        return schools;
        }
      }

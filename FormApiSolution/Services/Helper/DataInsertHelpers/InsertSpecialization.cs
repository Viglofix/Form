using DataBase.Model;

namespace Services.Helper.DataInsertHelpers;

public class InsertSpecialization {
     public List<Specialization> GetAllSpecializations() {
     List<Specialization> list = new() {
       new Specialization() {
         Domain = "Frontend",
         Role = "react"
        },
        new Specialization() {
         Domain = "Frontend",
         Role = "react native"
        },
        new Specialization() {
         Domain = "Backend",
         Role = ".net"
        },
        new Specialization() {
         Domain = "Backend",
         Role = "node.js"
        },
         new Specialization() {
         Domain = "Others",
         Role = "ui/ux"
        },
         new Specialization() {
         Domain = "Others",
         Role = "grafika"
        },
          new Specialization() {
         Domain = "Others",
         Role = "marketing"
        },
         new Specialization() {
         Domain = "Others",
         Role = "pm"
        },
        new Specialization() {
          Domain = "Others",
          Role = "copywriting"
        }
        };

        return list;
     }
}
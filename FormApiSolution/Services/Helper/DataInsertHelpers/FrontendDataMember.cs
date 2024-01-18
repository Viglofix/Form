using DataBase.Model;

namespace Services.Helper.DataInsertHelpers; 

public class FrontendDataMember {
    public long? Id {get;set;}
    public string? ColumnId {get;set;}
    public string? FullName {get;set;}
    public FrontendDataSpecialization? Specialization {get;set;}
    public string? NameOfUniversityOrOccupation { get;set;}
    public string? Note {get;set;}
    public long? AssignedToProjectId {get;set;}
    public long? Range {get;set;} 
}
using System.ComponentModel.DataAnnotations;

namespace BolidIntegrServ.Models;

public class pList
{
    [Key]
    public int ID { get; set; }
    
    public string Name { get; set; }
    
    public string FirstName { get; set; }
    
    public string? MidName { get; set; }
    
    public int Status { get; set; }
    
    public string? WorkPhone { get; set; }
    
    public string? HomePhone { get; set; }
    
    public byte[]? Picture { get; set; }

    public DateTime? BirthDate { get; set; }
    
    public string? Address { get; set; }
    
    public int? Company { get; set; }
    
    public int? Section { get; set; }
    
    public int? Post { get; set; }
    
    public int? Schedule { get; set; }
    
    public string? Avto { get; set; }
    
    public int? Spack { get; set; }
    
    public int? Config { get; set; }

    public string? TabNumber { get; set; }

    public int? GrStatus { get; set; }
    
    public DateTime? ChangeTime { get; set; }

    public int? IndexForContactId { get; set; }
    
    public int? StatusRecord { get; set; }
    
    public int? Patterns_ID { get; set; }
    
    public string? ID_Number_List { get; set; }
    
    public int? weight { get; set; }
    
    public int? delta_weight { get; set; }
    
    public int? AutoID { get; set; }
    
    public string? GUID_1C { get; set; }
    
    public string? INN { get; set; }
}
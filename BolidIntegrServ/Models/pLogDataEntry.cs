using System.ComponentModel.DataAnnotations;

namespace BolidIntegrServ.Models;

public class pLogData
{
    public DateTime TimeVal { get; set; }
    
    public int? NumCom { get; set; }
    
    public int? IDComp { get; set; }
    
    public int? Par1 { get; set; }
    
    public int? Par2 { get; set; }
    
    public int? Par3 { get; set; }
    
    public int? Par4 { get; set; }
    
    public int Event { get; set; }
    
    public int? IndexKey { get; set; }
    
    public int? RazdIndex { get; set; }
    
    public int? HozOrgan { get; set; }
    
    public int? HozGuest { get; set; }
    
    public string? Remark { get; set; }
    
    public int? DoorIndex { get; set; }
    
    public int? Mode { get; set; }
    
    public DateTime? DeviceTime { get; set; }
    
    public int? VEvent { get; set; }
    
    public int? ZReserv { get; set; }
    
    public int? ZoneIndex { get; set; }
    
    public int? ReaderIndex { get; set; }
    
    public int? Sign { get; set; }
    
    public int? tpRzdIndex { get; set; }
    
    public int? tpPar4 { get; set; }
    
    public int? IndexZone { get; set; }
    
    public int? tpIndex { get; set; }
    
    [Key]
    public Guid GUID { get; set; }
}
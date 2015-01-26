using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for Horario
/// </summary>
[DataContract]
public class cHorario
{
	public cHorario()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    [DataMember(IsRequired = true)]
    public int HoraioID
    { get; set; }

    [DataMember(IsRequired = true)]
    public int DiaID
    { get; set; }

    [DataMember(IsRequired = true)]
    public string DiaStr
    { get; set; }

    [DataMember(IsRequired = true)]
    public DateTime HoraInicial
    { get; set; }

    [DataMember(IsRequired = true)]
    public DateTime HoraFinal
    { get; set; }

    [DataMember(IsRequired = true)]
    public bool Activo
    { get; set; }

    [DataMember(IsRequired = true)]
    public int SucursalID
    { get; set; }

    [DataMember(IsRequired = true)]
    public string SucursalStr
    { get; set; }



}
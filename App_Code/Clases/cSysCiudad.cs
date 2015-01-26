using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for cSysCiudad
/// </summary>
[DataContract]

public class cSysCiudad
{
	public cSysCiudad()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    [DataMember(IsRequired = true)]
    public int CiudadID
    { get; set; }

    [DataMember(IsRequired = true)]
    public int EstadoID
    { get; set; }

    [DataMember(IsRequired = true)]
    public string EstadoStr
    { get; set; }

    [DataMember(IsRequired = true)]
    public string Descripcion
    { get; set; }

    [DataMember(IsRequired = true)]
    public bool Activo
    { get; set; }

    }
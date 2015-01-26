using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de cTelefono
/// </summary>
public class cTelefono
{
	public cTelefono()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}

    
    [DataMember(IsRequired=true)]
    public int TelefonoID {get;set;}

    
    [DataMember(IsRequired=true)]
    public string Descripcion {get;set;}

    
    [DataMember(IsRequired=true)]
    public int TipoTelefonoID {get;set;}

    [DataMember(IsRequired=true)]
    public string TipoTelefonoStr { get; set; }

    
    [DataMember(IsRequired=true)]
    public int SucursalID {get;set;}

    [DataMember(IsRequired=true)]
    public string SucursalStr {get;set;}


}
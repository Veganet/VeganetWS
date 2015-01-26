using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de cSucursalTipoAlimentacion
/// </summary>

[DataContract]
public class cSucursalTipoAlimentacion
{
	public cSucursalTipoAlimentacion()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}

    
    [DataMember(IsRequired=true)]
    public int SucursalTipoAlimentacionID {get;set;}

    
    [DataMember(IsRequired=true)]
    public int SucursalID {get;set;}

    
    [DataMember(IsRequired=true)]
    public string SucursalStr {get;set;}

    
    [DataMember(IsRequired=true)]
    public int TipoAlimentacionID {get;set;}

    
    [DataMember(IsRequired=true)]
    public string TipoAlimentacionStr {get;set;}

}
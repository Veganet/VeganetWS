using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de cCorreo
/// </summary>
[DataContract]
public class cCorreo
{
	public cCorreo()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}

    
    [DataMember(IsRequired=true)]
    public int CorreoID {get;set;}

    
    [DataMember(IsRequired=true)]
    public string Descripcion {get;set;}

    
    [DataMember(IsRequired=true)]
    public int SucursalID {get;set;}

    
    [DataMember(IsRequired=true)]
    public string SucursalStr {get;set;}
}
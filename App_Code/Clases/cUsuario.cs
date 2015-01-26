using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de cUsuario
/// </summary>

[DataContract]
public class cUsuario
{
	public cUsuario()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}

    
    [DataMember(IsRequired=true)]
    public int UsuarioID {get;set;}

    
    [DataMember(IsRequired=true)]
    public string Nombre {get;set;}

    
    [DataMember(IsRequired=true)]
    public string Correo {get;set;}

    
    [DataMember(IsRequired=true)]
    public byte Fotografia {get;set;}

    
    [DataMember(IsRequired=true)]
    public string CiudadID {get;set;}

    
    [DataMember(IsRequired=true)]
    public int TipoAlimentacionID {get;set;}

    
    [DataMember(IsRequired=true)]
    public string TipoAlimentacionStr {get;set;}

}
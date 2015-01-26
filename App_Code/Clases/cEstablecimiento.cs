using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de cEstablecimiento
/// </summary>
[DataContract]
public class cEstablecimiento
{
	public cEstablecimiento()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}

    [DataMember(IsRequired=true)]
    public int EstablecimientoID {get;set;}

    
    [DataMember(IsRequired=true)]
    public string Nombre {get;set;}

    
    [DataMember(IsRequired=true)]
    public string Descripcion {get;set;}

    
    [DataMember(IsRequired=true)]
    public byte Logo {get;set;}

    
    [DataMember(IsRequired=true)]
    public string Eslogan {get;set;}

    
    [DataMember(IsRequired=true)]
    public bool Activo {get;set;}

    
    [DataMember(IsRequired=true)]
    public DateTime FechaCreacion {get;set;}

    
}
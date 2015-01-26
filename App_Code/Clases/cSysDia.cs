using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de cSysDia
/// </summary>
[DataContract]
public class cSysDia
{
	public cSysDia()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}

    
    [DataMember(IsRequired=true)]
    public int SysDiaID {get;set;}

    
    [DataMember(IsRequired=true)]
    public string Descripcion {get;set;}

    
    [DataMember(IsRequired=true)]
    public bool Activo {get;set;}
}
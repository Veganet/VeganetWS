using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de cCalificacion
/// </summary>
public class cCalificacion
{
	public cCalificacion()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}

    
    [DataMember(IsRequired=true)]
    public int CalificacionID {get;set;}

    
    [DataMember(IsRequired=true)]
    public int SucursalID {get;set;}

    
    [DataMember(IsRequired=true)]
    public string SucursalStr {get;set;}

    
    [DataMember(IsRequired=true)]
    public int UsuarioID {get;set;}

    
    [DataMember(IsRequired=true)]
    public string UsuarioStr {get;set;}

    
    [DataMember(IsRequired=true)]
    public string Comentario {get;set;}

    
    [DataMember(IsRequired=true)]
    public int Calificacion {get;set;}
}
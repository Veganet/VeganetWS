using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for cSysEstado_
/// </summary>
[DataContract]

public class cSysEstado
{
	public cSysEstado()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    [DataMember(IsRequired = true)]
    public int EstadoID
    { get; set; }

    [DataMember(IsRequired = true)]
    public int PaisID
    { get; set;}

    [DataMember(IsRequired = true)]
    public string PaisStr
    { get; set;}

    [DataMember(IsRequired = true)]
    public string Descripcion
    { get; set; }


}
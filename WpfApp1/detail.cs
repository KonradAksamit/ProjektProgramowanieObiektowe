
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace WpfApp1
{

using System;
    using System.Collections.Generic;
    
public partial class detail
{

    public int Id { get; set; }

    public int Id_book { get; set; }

    public System.DateTime DateFrom { get; set; }

    public System.DateTime DateTo { get; set; }



    public virtual booking booking { get; set; }

}

}

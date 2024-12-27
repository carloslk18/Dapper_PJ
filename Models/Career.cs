using System;
using System.ComponentModel;

namespace Data_Access.Models{   
public class Career{

    public Career(){
        CareerItems = new List<CareerItem>();
    }


    public Guid Id {get; set;}
    public string Title {get; set;}
    public IList<CareerItem> CareerItems {get; set;}

}
}  
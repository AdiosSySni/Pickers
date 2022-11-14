using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;

namespace Picket;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Person> people { get; set; }
    //public Person person { get; set; }
    //public Person person1{ get; set; }

    public MainPage()
	{
        people = new ObservableCollection<Person>();
       

        //person = new Person();
        //person.Name = "Alexander";
        //person.Surname = "Vladimir";
        //person.Patronomic = "Sanchis";

        //person1 = new Person();
        //person1.Name = "Alexander1";
        //person1.Surname = "Vladimi1r";
        //person1.Patronomic = "Sanc1his";

        people.Add(new Person("Paul", "Vlad", "Pavlov"));
        people.Add(new Person("Elena", "Alexander", "Pavlov"));

        BindingContext = this;

        InitializeComponent();
    }
       

	public void Picker_SelectedIndexChanged(object sender, EventArgs e)
	{
        
    }

}


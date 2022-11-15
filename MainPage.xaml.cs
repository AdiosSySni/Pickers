using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;

namespace Picket;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Person> people { get; set; }
    //public string textValue;
    public MainPage()
	{
        people = new ObservableCollection<Person>();
        people.Add(new Person("Гегель", "Пауль", "Викторович")); // 0
        people.Add(new Person("Васькин", "Илья", "Владимирович")); // 1

        //BindingContext = this;

        InitializeComponent();
        FirstPicker.ItemsSource = people;
        FirstPicker.ItemDisplayBinding = new Binding("Surname");

        //Entry.Text = textValue;
    }
       
	public void PickerFirst(object sender, EventArgs e)
    {
        ObservableCollection<String> strings = new ObservableCollection<string>(); // коллекция свойств обьекта

        var person = people[(sender as Picker).SelectedIndex];// обьект

        SecondPicker.ItemsSource = strings;
        strings.Add(person.Surname);
        strings.Add(person.Name);
        strings.Add(person.Patronymic);
    }

    public void PickerTwo(object sender, EventArgs e)
    {
        if((sender as Picker).SelectedItem != null)
        {
            Entry.Text = (sender as Picker).SelectedItem.ToString();
        }
    }

    public void ButtonClicked(object sender, EventArgs e)
    { 
        if ((FirstPicker.SelectedItem as Person).Name== SecondPicker.SelectedItem as string)
        {
            (FirstPicker.SelectedItem as Person).Name = Entry.Text;
        }

        if ((FirstPicker.SelectedItem as Person).Surname == SecondPicker.SelectedItem as string)
        {
            (FirstPicker.SelectedItem as Person).Surname = Entry.Text;
        }

        if ((FirstPicker.SelectedItem as Person).Patronymic == SecondPicker.SelectedItem as string)
        {
            (FirstPicker.SelectedItem as Person).Patronymic = Entry.Text;
        }

        //else if (c == d.Name)
        //{
        //    d.Name = Entry.Text;
        //}
        //else
        //{
        //    d.Patronymic = Entry.Text;
        //}   
    }

}


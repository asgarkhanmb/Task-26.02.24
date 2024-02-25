
using Conustructors_Praktik;

Person person = new()
{
    id = 1,
    fullname = "Asgarkhan Bayramov",
    age = 27,
    position = "Students",
};

using Conustructors_Praktik;

Person person = new(1, "Asgarkhan Bayramov", 27, "Student");

Console.WriteLine(person.fullname);


using Conustructors_Praktik;

Person person1 = new("Azerbaycan");

Person person1 = new("Azerbaycan", "Turkiye");


using Conustructors_Praktik;
using System;
using System.Globalization;

Person person1 = new()
{
    id = 1,
    fullname = "Ilqar Shriyev",
    age = 26
};
Person person2 = new()
{
    id = 2,
    fullname = "Reshad Agayev",
    age = 21,

};
Person person3 = new()
{
    id = 3,
    fullname = "Nurlan Umudov",
    age = 22,
};
Person person4 = new()
{
    id = 4,
    fullname = "Elmir Qafarzade",
    age = 21,
};




Person[] people = { person1, person2, person3, person4 };

Person FindStudentById(Person[] people, int id)
{
    return people.FirstOrDefault(p => p.id == id);


}
Person result = FindStudentById(people, 2);

string response = $"Id: {result.id} Fullname:{result.fullname} Age:{result.age}";


Console.WriteLine(response);







Person[] people = { person1, person2, person3, person4 };

Person FindStudentById(Person[] people, int id)
{
    return people.FirstOrDefault(p => p.id == id);


}
Person result = FindStudentById(people, 100);

if (result != null)
{
    string response = $"id:{result.id} fullname:{result.fullname}Age:{result.age}";

    Console.WriteLine(response);
}
else
{
    Console.WriteLine("Data not found");
}






Person[] people = { person1, person2, person3, person4 };

Person FindPersonById(Person[] people, int id)
{
    return people.FirstOrDefault(p => p.id == id);


}
Person result = FindPersonById(people, 100);

var result1 = result != null ? $"id:{result.id} fullname:{result.fullname}Age:{result.age}" : "not found";

//Console.WriteLine(result1);




void ShowPersonById(Person person)
{
    if (person != null)
    {
        string response = $"id:{person.id} fullname:{person.fullname}Age:{person.age}";

        Console.WriteLine(response);
    }
    else
    {
        Console.WriteLine("Data not found");
    }
    Person result = FindPersonById(people, 100);
}
//ShowPersonById(result);



Person[] GetAllPerson(Person[] datas)
{
    return datas;
}
var allPeople = GetAllPerson(people);

void ShowAllPeople(Person[] datas)
{
    foreach (var item in datas)
    {
        string response = $"Id:{item.id} Fullname:{item.fullname}Age:{item.age}";
        Console.WriteLine(response);
    }

}










Person[] GetAllPerson()
{
    Person person1 = new()
    {
        id = 1,
        fullname = "Ilqar Shriyev",
        age = 26
    };
    Person person2 = new()
    {
        id = 2,
        fullname = "Reshad Agayev",
        age = 21,

    };
    Person person3 = new()
    {
        id = 3,
        fullname = "Nurlan Umudov",
        age = 22,
    };
    Person person4 = new()
    {
        id = 4,
        fullname = "Elmir Qafarzade",
        age = 21,
    };

    Person[] people = { person1, person2, person3, person4 };

    return people;
}
void ShowAllPeople(Person[] datas)
{
    foreach (var item in datas)
    {
        string response = $"Id:{item.id} Fullname:{item.fullname}Age:{item.age}";
        Console.WriteLine(response);
    }

}


var result = GetAllPerson();
ShowAllPeople(result);


Person FindPersonById(Person[] people, int id)
{
    return people.FirstOrDefault(p => p.id == id);


}
void ShowPersonById(Person person)
{
    if (person != null)
    {
        string response = $"id:{person.id} fullname:{person.fullname}Age:{person.age}";

        Console.WriteLine(response);
    }
    else
    {
        Console.WriteLine("Data not found");
    }
    Person result = FindPersonById(people, 100);
}


ShowPersonById(FindPersonById(GetAllPerson(), 3));




Person[] GetPeopleByName(Person[] people, string name)
{
    return people.Where(m => m.fullname == name).ToArray();
}


void ShowPeopleByName(Person[] datas)
{
    foreach (var item in datas)
    {
        string response = $"Id:{item.id} Fullname:{item.fullname}Age:{item.age}";
        Console.WriteLine(response);
    }
}

ShowPeopleByName(GetPeopleByName(GetAllPerson(), "Bahruz"))







Animal animal = new();

animal.id = 5;
animal.name = "Qartal";

Console.WriteLine(animal.name);


Bird bird = new()
{
    id = 1,
    name = "Qaranqush",
    age = 10
};
//Console.WriteLine(bird.name);

bird.Sound();





Fish fish = new();